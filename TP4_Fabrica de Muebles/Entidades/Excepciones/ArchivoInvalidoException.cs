using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoInvalidoException : Exception
    {
        public ArchivoInvalidoException (string message): base(message)
        {

        }
        public ArchivoInvalidoException(string message, Exception inner) : base(message,inner)
        {

        }
    }
}
