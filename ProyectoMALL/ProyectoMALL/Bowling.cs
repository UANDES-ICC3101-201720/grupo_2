﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{
    class Bowling : LEntretencion
    {
        private string Nombre;
        private string SubTipo;
        private int Piso;
        public Bowling(int NEmpleados, int AreaLocal, int PrecioMin, int PrecioMax, string Nombre, int Piso) :
            base(NEmpleados, AreaLocal, PrecioMin, PrecioMax)
        {
            this.Nombre = Nombre;
            this.SubTipo = "Bowling";
            this.Piso = Piso;
        }
    }
}
