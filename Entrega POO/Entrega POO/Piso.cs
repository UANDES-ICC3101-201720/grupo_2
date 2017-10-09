using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_POO
{
    class Piso
    {
        public int precioArriendo;
        public List<Local> lista_negocio;
        public bool ocupado;

        public Piso(int Area)
        {
            lista_negocio = new List<Local>();
            this.precioArriendo = Area;
            this.ocupado = false;
        }

        public double Ganancia_Local(Local local)
        {
            Random rnd = new Random();
            int V = rnd.Next(local.precio_min, local.precio_max);
            int costoArriendo = local.area_local * precioArriendo;
            int ganancia = V * local.c_anterior - (local.c_empleados + costoArriendo);
            return ganancia;
        }

        public void Add(Local local)
        {
            lista_negocio.Add(local);
        }

    }
}
