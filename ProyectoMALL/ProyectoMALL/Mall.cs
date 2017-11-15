using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{
    class Mall : Piso
    {
        private int Plata; // La plata del usuario
        private Local[] Locales;
        

        public Mall(int Plata, Local[] Locales, List<int> Pisos) : base(Pisos)
        {
            this.Plata = Plata;
            this.Locales = Locales;
        }
        public void ImprimirLocales()
        {
            Console.WriteLine(this.Locales);
        }

    }
}
