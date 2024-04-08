using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retroalimentacion
{
    internal class animal
    {
        //atributos
        public string nombre { get; set; }
        public int numpatas { get; set; }
        public string habitat { get; set; }

        //constructor
        public animal(string nombre, int npatas, string habitat)
        {
            this.nombre = nombre;
            this.numpatas = npatas;
            this.habitat = habitat;
        }

        //metodos
        public string informacion()
        {
            return nombre;
        }
        public string informacion(double a)
        {
            string texto = "el numero ingresado es: " + a;
            return texto;
        }
    }
}
