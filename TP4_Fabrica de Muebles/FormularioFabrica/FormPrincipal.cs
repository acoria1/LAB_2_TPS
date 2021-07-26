using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Materiales;
using Entidades.Modelos;
using Entidades.Muebles;

namespace FormularioFabrica
{
    public partial class FormPrincipal : Form
    {       

        Fabrica miFabrica;
        FrmHistorialDeEnvios frmHistorial;
        Thread nuevoMuebleThread;
        Thread fabricandoMueblesThread;
        public FormPrincipal()
        {
            InitializeComponent();
            this.miFabrica = new Fabrica();
            try
            {
                this.miFabrica = Fabrica.LeerFabricaDesdeArchivos();
            }
            catch (ArchivoInvalidoException ex)
            {
                MessageBox.Show(LogException(ex), "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.bsStockMuebles.DataSource = miFabrica.stockMuebles;
            this.bsMueblesProduccion.DataSource = miFabrica.mueblesEnProduccion.ToList();
            this.bsMateriales.DataSource = miFabrica.stockMateriales.Values.ToList();
            this.listBoxModelos.DataSource = miFabrica.modelosDisponibles.Values.ToList();
            this.btnPausarReanudar.Text = "Reanudar Produccion";
        }

        public static string LogException(Exception error)
        {
            Exception currentException = error;
            StringBuilder sb = new StringBuilder(currentException.Message);
            while (currentException.InnerException != null)
            {
                currentException = currentException.InnerException;
                sb.AppendLine(currentException.ToString());
            }
            return sb.ToString(); 
        }

        private void btnAddMateriales_Click(object sender, EventArgs e)
        {
            FrmAgregarMateriales frmAgregarMateriales = new FrmAgregarMateriales();
            frmAgregarMateriales.ShowDialog();
            if (frmAgregarMateriales.DialogResult == DialogResult.OK)
            {
                foreach (Material item in frmAgregarMateriales.MaterialesAgregados)
                {
                    miFabrica = miFabrica + item;
                }
                this.bsMateriales.DataSource = miFabrica.stockMateriales.Values.ToList();
            }
        }

        private void btnAdminModelos_Click(object sender, EventArgs e)
        {
            FrmModelos frmModelos = new FrmModelos(this.miFabrica);           
            frmModelos.ShowDialog();
            if (frmModelos.DialogResult == DialogResult.OK)
            {
                this.miFabrica.modelosDisponibles = frmModelos.Modelos;
                this.listBoxModelos.DataSource = this.miFabrica.modelosDisponibles.Values.ToList();
            }
        }

        private void bsStockMuebles_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                this.rtxbMuebleDetails.Text = MuebleDAO.GetDetalleMueble((Mueble)this.bsStockMuebles.Current);
            }
            catch (Exception)
            {
                this.rtxbMuebleDetails.Text = string.Empty;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirmar envío del mueble " +
                $"{((Mueble)this.bsStockMuebles.Current).CodigoGuid}", 
                "Envio", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MuebleDAO.Insert(((Mueble)this.bsStockMuebles.Current));
                    this.bsStockMuebles.Remove(((Mueble)this.bsStockMuebles.Current));
                } catch (Exception ex)
                {
                    if (MessageBox.Show("Error al insertar en base de datos \n¿Enviar de todos modos?", "Error de envío", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.bsStockMuebles.Remove(((Mueble)this.bsStockMuebles.Current));
                    }                  
                }               
            }            
        }

        private void btnHistorialEnvios_Click(object sender, EventArgs e)
        {
            frmHistorial = new FrmHistorialDeEnvios();
            frmHistorial.cerrandoForm += HabilitarBotonHistorial;
            frmHistorial.Show();
            this.btnHistorialEnvios.Enabled = false;
        }      

        public void HabilitarBotonHistorial()
        {
            if (this.InvokeRequired)
            {
                CerrandoForm cf = new CerrandoForm(HabilitarBotonHistorial);
                object[] objs = new object[] { };
                this.Invoke(cf, objs);
            } else
            {
                this.btnHistorialEnvios.Enabled = true;
            }
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            FrmNuevoMueble frmNuevoMueble = new FrmNuevoMueble(this.miFabrica.modelosDisponibles.Values.ToList());
            frmNuevoMueble.fabriqueNuevoMueble += AgregarAQueueDeProduccion;
            frmNuevoMueble.avisoFormClosing += AbortThread;
            this.nuevoMuebleThread = new Thread(frmNuevoMueble.ShowDialogNoReturn);
            this.nuevoMuebleThread.Start();    
        }

        public void AgregarAQueueDeProduccion(Mueble m)
        {
            if (this.InvokeRequired)
            {
                FabriqueNuevoMueble fnm = new FabriqueNuevoMueble(AgregarAQueueDeProduccion);
                object[] objs = new object[] { m };
                this.Invoke(fnm, objs);
            }
            else
            {
                List<Material> materialesSinStockDeModelo;
                if (this.miFabrica.FabricarMueble(m, out materialesSinStockDeModelo))
                {
                    this.bsMateriales.DataSource = miFabrica.stockMateriales.Values.ToList();
                    this.bsMueblesProduccion.DataSource = miFabrica.mueblesEnProduccion.ToList();
                } else if (materialesSinStockDeModelo.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    double diferencia;
                    // Por cada material necesario del modelo que no puedo fabricar,
                    // calculo la diferencia de pesos entre lo que necesito y lo que hay
                    // en stock. 
                    // Informa cuanto necesito agregar a mi fábrica de cada material.
                    foreach (Material item in materialesSinStockDeModelo)
                    {
                        diferencia = item.PesoEnKG - this.miFabrica.GetPesoDeMaterialEnFabrica(item);
                        sb.AppendLine($"{item.Key}: faltan {diferencia}kgs.");
                    }
                    MessageBox.Show(sb.ToString(),"STOCK INSUFICIENTE",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }               
            }          
        }

        public void AbortThread()
        {
            if (this.InvokeRequired)
            {
                AvisoFormClosing av = new AvisoFormClosing(AbortThread);
                object[] objs = new object[] { };
                this.Invoke(av, objs);
            } else
            {
                this.nuevoMuebleThread.Abort();
            }
        }

        public void ComenzarProduccion ()
        {
            if (this.InvokeRequired)
            {
                ComenzoProduccion cp = new ComenzoProduccion(ComenzarProduccion);
                object[] objs = new object[] { };
                this.Invoke(cp, objs);
            }
            else
            {
                Mueble currentMueble;
                if (this.miFabrica.mueblesEnProduccion.TryPeek(out currentMueble))
                {
                    currentMueble.Estado = EEstadoMueble.EnProduccion;
                    this.bsMueblesProduccion.DataSource = miFabrica.mueblesEnProduccion.ToList();
                }
            }
        }

        public void MoverMuebleAStock()
        {
            if (this.InvokeRequired)
            {
                TerminoProduccion tp = new TerminoProduccion(MoverMuebleAStock);
                object[] objs = new object[] { };
                this.Invoke(tp, objs);
            } else
            {
                Mueble muebleTerminado;
                if (this.miFabrica.mueblesEnProduccion.TryDequeue(out muebleTerminado))
                {
                    muebleTerminado.Estado = EEstadoMueble.Terminado;
                    this.bsMueblesProduccion.DataSource = miFabrica.mueblesEnProduccion.ToList();
                    this.bsStockMuebles.Add(muebleTerminado);
                }
            }          
        }
        /// <summary>
        /// Aborta o vuelve a inicializar el Thread que fabrica muebles.
        /// Quise usar los métodos Suspend y Resume pero aparecen como "deprecated".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPausarReanudar_Click(object sender, EventArgs e)
        {
            if (this.btnPausarReanudar.Text == "Reanudar Produccion") // Está en pausa
            {
                SimuladorDeFabricacion miSimulador = new SimuladorDeFabricacion();
                miSimulador.comenzoProduccionDeMueble += this.ComenzarProduccion;
                miSimulador.terminoProduccionDeMueble += this.MoverMuebleAStock;
                this.fabricandoMueblesThread = new Thread(new ParameterizedThreadStart(miSimulador.SimularFabricacion));
                this.fabricandoMueblesThread.Start(this.miFabrica.mueblesEnProduccion);
                this.btnPausarReanudar.Text= "Pausar Produccion";              
            } else // está corriendo
            {
                this.fabricandoMueblesThread.Abort();
                this.btnPausarReanudar.Text = "Reanudar Produccion";
            }           
        }

        /// <summary>
        /// AL cerrarse el formulario intentará guardar la fabrica en archivos.
        /// Si el formulario de historial está abierto lo cerrará.
        /// SI hay un error al guardar la fabrica mostrará por messagebox
        /// Abortará el thread que simula la fabricacion de muebles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.miFabrica.GuardarFabricaEnArchivos();
                if (this.frmHistorial != null)
                {
                    this.frmHistorial.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LogException(ex));
            }
            finally
            {
                if (this.fabricandoMueblesThread != null)
                    this.fabricandoMueblesThread.Abort();
            }
        }
    }
}
