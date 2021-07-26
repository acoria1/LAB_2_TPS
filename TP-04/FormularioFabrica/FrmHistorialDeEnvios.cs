using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Muebles;
using Entidades;

namespace FormularioFabrica
{
    public  delegate void CerrandoForm();
    public partial class FrmHistorialDeEnvios : Form
    {
        Thread myThread;
        public event CerrandoForm cerrandoForm;
        public FrmHistorialDeEnvios()
        {
            InitializeComponent();          
        }

        private void FrmHistorialDeEnvios_Load(object sender, EventArgs e)
        {           
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = MuebleDAO.GetMueblesFromDB("FechaDeEnvio",true).Tables[0];
            int c = dataGridView1.Columns.Count;
            for (int i = 0; i < c; i++)
            {
                this.cmbOrderBy.Items.Add(dataGridView1.Columns[i].HeaderText);
            }
            this.cmbOrderBy.SelectedIndex = 0;
            this.cmbOrderType.SelectedIndex = 0;
            try
            {
                Entidades.TablaMueblesListener myListener = new Entidades.TablaMueblesListener();
                myListener.dataBaseChanged += avisoCambioBD;
                myThread = new Thread(myListener.DataBaseListener);
                myThread.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay conexión con la base de datos, se cerrará este form");
                this.Close();
            }           
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            bool ascending = false;
            if (cmbOrderType.Text == "Ascending")
            {
                ascending = true;
            }
            try
            {
                dataGridView1.DataSource = MuebleDAO.GetMueblesFromDB(cmbOrderBy.Text, ascending).Tables[0];

            }
            catch (Exception)
            {
                MessageBox.Show("No hay conexión con la base de datos");
            }
        }

        private void avisoCambioBD (string text)
        {
            if (this.InvokeRequired)
            {
                AvisoCountCambio av = new AvisoCountCambio(avisoCambioBD);
                object[] objs = new object[] { text };
                this.Invoke(av, objs);
            } else
            {
                if (MessageBox.Show(text + "Ok para refrescar vista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    try
                    {
                        dataGridView1.DataSource = MuebleDAO.GetMueblesFromDB(cmbOrderBy.Text, true).Tables[0];
                        myThread.Abort();
                        Entidades.TablaMueblesListener myListener = new Entidades.TablaMueblesListener();
                        myListener.dataBaseChanged += avisoCambioBD;
                        myThread = new Thread(myListener.DataBaseListener);
                        myThread.Start();
                    } catch (Exception)
                    {
                        MessageBox.Show("No hay conexión con la base de datos, se cerrará este form");

                    }               
                }
            }                
        }

        private void FrmHistorialDeEnvios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.cerrandoForm != null)
            {
                this.cerrandoForm.Invoke();
            }
            myThread.Abort();
        }
    }
}
