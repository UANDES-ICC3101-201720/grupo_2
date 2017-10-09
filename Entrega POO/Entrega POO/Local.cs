using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_POO
{
    public class Local
    {
        public string nombre;
        public int c_empleados;
        public int area_local;
        public int precio_min;
        public int precio_max;
        public string categoria;
        public int c_anterior;

        public Local(string nombre, int c_empleados, int area_local, int precio_min, int precio_max, string categoria,int c_anterior)
        {
            this.nombre = nombre;
            this.c_empleados = c_empleados;
            this.area_local = area_local;
            this.precio_min = precio_min;
            this.precio_max = precio_max;
            this.categoria = categoria;
            this.c_anterior = c_anterior;
        }

        public int CMAX(int c_anterior)
        {
            Random rnd = new Random();
            int prom = (precio_max - precio_min) / 2;
            int CMAX = c_anterior + (area_local / 10) * ((System.Math.Max(100 - prom, 0)) / 100) * c_empleados;
            return rnd.Next(0, CMAX+1);
        }       
    }
}
