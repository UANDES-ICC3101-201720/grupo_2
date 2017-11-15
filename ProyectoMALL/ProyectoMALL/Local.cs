using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{
    class Local
    {
        int NEmpleados;
        int AreaLocal;
        int PrecioMin;
        int PrecioMax;

        public Local(int NEmpleados, int AreaLocal, int PrecioMin, int PrecioMax)
        {
            this.NEmpleados = NEmpleados;
            this.AreaLocal = AreaLocal;
            this.PrecioMin = PrecioMin;
            this.PrecioMax = PrecioMax;
        }
        public int GetNEmpleados()
        { 
            return this.NEmpleados;
        }
    }
}
