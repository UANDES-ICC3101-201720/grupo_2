using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entrega_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciar Juego
            Console.WriteLine("x**  JUEGO MALL  **x");
            int horas;
            int dinero;

            while (true)
            {
                Console.Write("Ingrese Horas \n>>");
                horas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese Dinero \n>>");
                dinero = Convert.ToInt32(Console.ReadLine());
                Console.Write("DESEA COMENZAR EL JUEGO??(si/no)\n>>");
                string resp = Console.ReadLine();
                if (resp != "si")
                {
                    //Seguir preguntando
                }
                else
                {
                    break;
                }
            }
            //Iniciar Mall
            Mall mall = new Mall(horas, dinero);
            //Crear Mall
            //Crear Pisos
            mall.Crear_Pisos(); 
            //Crear Locales
            mall.Crear_Locales();
            int dia = 1;
            while (horas > 24)
            {
                Console.Write("<<Presione P para pausar>>");
                ConsoleKey key = Console.ReadKey().Key;
                while (key != ConsoleKey.P)
                {
                    Console.WriteLine("horas disponibles: {0}", mall.horas);
                    Console.WriteLine("Dia {0}", dia);
                    //Jugar
                    //Crear Pisos
                    Console.Write("Desea crear piso?(si/no)\n>>");
                    string resp = Console.ReadLine();
                    if (resp == "si") { mall.Crear_piso(); }
                    //Crear Locales
                    Console.Write("Desea crear local?(si/no)\n>>");
                    resp = Console.ReadLine();
                    if (resp == "si") { mall.Crear_Locales(); }
                    horas -= 24;
                    dia ++;
                }
                /*Reportes parte 4
                StreamWriter sw = new StreamWriter("reporte.txt");
                //Clientes recepcionados
                int clientes_recepcionados = mall.lista_pisos.Sum
                    (pisos => pisos.lista_negocio.Sum(locales => locales.CMAX(locales.c_anterior)));
                Console.WriteLine("Clientes Recepcionados: {0}", clientes_recepcionados);
                /*Clientes Promedio
                double clientes_promedio = mall.lista_pisos.Average
                    (pisos => pisos.lista_negocio.Average(clientes => clientes.c_anterior));
                Console.WriteLine("Clientes Promedio: {0}", clientes_promedio);
                //Ganancia Total
                double ganancia_total = 0;
                double ganancia = 0;
                double ganancia_mayor = 0;
                string local_mayor_ganancia="";
                foreach (Piso piso in mall.lista_pisos)
                {
                    for (int i = 0; i < piso.lista_negocio.Count(); i++)
                    {
                        ganancia = piso.Ganancia_Local(piso.lista_negocio[i]);
                        if( ganancia_mayor < ganancia)
                        {
                            ganancia_mayor = ganancia;
                            local_mayor_ganancia = piso.lista_negocio[i].nombre;
                        }
                    }
                    ganancia_total += ganancia;
                }
                Console.WriteLine("Ganancia Total: {0}", ganancia_total);
                //Ganancia Promedio por dia
                double cant_locales = 0;
                foreach (Piso piso in mall.lista_pisos)
                {
                    int cant = piso.lista_negocio.Count();
                    cant_locales += cant;
                }
                double ganancia_promedio = ganancia_total / cant_locales;
                Console.WriteLine("Ganancia Promedio Por Dia: {0}", ganancia_promedio);
                //Local con mayor ganancia total
                Console.WriteLine("Local con mayor ganancia: {0}\n{1}", local_mayor_ganancia, ganancia_mayor);
                //escribir a archivo
                sw.WriteLine(clientes_recepcionados);
                //sw.WriteLine(clientes_promedio);
                sw.WriteLine(ganancia_total);
                sw.WriteLine(ganancia_promedio);*/
            }
            Console.WriteLine("Fin del juego");
            Console.ReadLine();
        }
    }
}
