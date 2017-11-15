using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{
    class LComercial : Local
    {
        private string Tipo; // Para diferenciar Locales Comerciales (C), Comida (F) y Entretencion (E)
        public LComercial(int NEmpleados, int AreaLocal, int PrecioMin, int PrecioMax) : 
            base(NEmpleados,  AreaLocal,  PrecioMin,  PrecioMax)
        {
            this.Tipo = "Comercial";
        }
    }
}
