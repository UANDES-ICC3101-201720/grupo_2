using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{ 
    class Restaurant : LComida
    {
        private string Nombre;
        private string SubTipo;
        private int Piso;
        public Restaurant(int NEmpleados, int AreaLocal, int PrecioMin, int PrecioMax, string Nombre, int Piso) :
            base(NEmpleados, AreaLocal, PrecioMin, PrecioMax)
        {
            this.Nombre = Nombre;
            this.SubTipo = "Restaurant";
            this.Piso = Piso;
        }
    }
}
