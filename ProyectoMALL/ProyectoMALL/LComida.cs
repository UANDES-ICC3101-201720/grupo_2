using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{
    class LComida : Local
    {
        private string Tipo; // Para diferenciar Locales Comerciales (C), Comida (F) y Entretencion (E)
        public LComida(int NEmpleados, int AreaLocal, int PrecioMin, int PrecioMax) :
            base(NEmpleados, AreaLocal, PrecioMin, PrecioMax)
        {
            this.Tipo = "Comida";
        }
    }
}
