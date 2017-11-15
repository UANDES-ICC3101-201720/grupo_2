using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMALL
{
    class Program
    {
        static void Main(string[] args)
        {
            int HorasDiarias = 10;
            int MinutosDiarios = HorasDiarias * 60;
            int PlataInicial = 1000000;
            bool Pausa = true; //Cuando Pausa == true, el reloj esta parado
            int NPisos = 0;
            int VolumenMall = 0;
            Console.WriteLine("El mall estara abierto {0} horas.\nUsted posee {1} pesos para comenzar la construccion", HorasDiarias, PlataInicial);
            Console.WriteLine("Cuantos pisos quiere que tenga su Mall?");
            NPisos = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Excelente!\nCreando los {0} pisos....", NPisos);
            List<int> vpisos = new List<int>();
            Piso pisos = new Piso(vpisos);
            List<object> locales = new List<object>();
            List<List<string>> Locs = new List<List<string>>();
            Random rnd = new Random();
            


            for (int i = 1; i < NPisos + 1; i++)
            {
                Console.WriteLine("Ingrese que volumen desea para el piso {0}", i);
                int result;
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    vpisos.Add(result); // Indice 0 es el 1er piso, indice 1 el 2do y asi 
                }
                else
                    Console.WriteLine("Por favor ingrese un numero adecuado.");
                if (vpisos.Count == 1)
                {

                }
                else if (vpisos[vpisos.Count - 2] < result)
                {
                    vpisos.RemoveAt(vpisos.Count - 1);
                    Console.Write("Los pisos superiores deben ser menores o iguales a los inferiores\nPor favor, nuevamente ");
                    i += -1;
                }
                else
                {

                }
            }
            for (int j = 0; j < vpisos.Count; j++)
            {
                VolumenMall += vpisos[j];
            }
            int PrecioArriendo = 1 * VolumenMall; // POR AHORA el precio de arriendo por m2 es de $1
            Console.WriteLine("Por el tamaño de su Mall, usted ya tiene un costo de arriendo de {0} .", PrecioArriendo);
            Console.WriteLine("Ahora debe elegir sus tiendas y repartirlas de la manera que prefiera");
            string r1 = "Partimos!!";
            int r2 = 0;

            while (r1 != "0")
            {

                if (r1 == "Partimos!!")
                {
                    Console.WriteLine("Usted posee una gran variedad de tiendas. Estas estan repartidas en 3 grandes categorias y estas, individualmente, poseen " +
                    "tiendas especialisadas.\nDebera elegir por piso que tiendas desea y que volumen tendran estas.\n\nComencemos!\n");
                }
                Console.WriteLine("Locales Comerciales:\n\t\t1.-Local de Ropa\n\t\t2.-Local para el Hogar\n\t\t3.-Local de Alimentos\n\t\t4.-Ferreteria\n\t\t5.-Local de Tecnologia\n\n" +
                    "Locales de Comida:\n\t\t6.-Comida Rapida\n\t\t7.-Restaurant\n\n" +
                    "Locales de Entretencion:\n\t\t8.-Cine\n\t\t9.-Juegos\n\t\t10.-Bowling\n");
                List<string> l1 = new List<string>();
                for (int i = 1; i < NPisos + 1; i++) //Cada piso 1 for
                {
                    int VolDisponible = vpisos[i - 1];
                    string r3 = " ";
                    
                    while (r3 != "NO")
                    {

                        l1.Clear();
                        Console.WriteLine("Escriba el numero del tipo de local que desea agregar en el piso {0}:", i);
                        string TipoTienda = Console.ReadLine();
                        Console.WriteLine("Excelente!\nDe que porte quiere su tienda? (tenga en cuenta que debe ser menor que el volumen del piso en que se encuetra.)");

                        int VolTienda = 0;
                        int NEmpleados = 0;
                        while (r3 != "pasa")
                        {
                            VolTienda = (int.Parse(Console.ReadLine()));
                            if (VolTienda < VolDisponible + 1)
                            {
                                r3 = "pasa";
                                Console.WriteLine("Muy bien! Creando la tienda de {0} m2", VolTienda);
                                Console.WriteLine("Calculando el numero de empleados necesarios....");
                                NEmpleados = (VolTienda / 10);
                                
                            }
                            else
                            {
                                Console.WriteLine("El tamaño ingresado es muy grande para este piso. Por favor ingrese otro tamaño.");
                            }
                        }
                        Console.WriteLine("Este local tendra "+ NEmpleados+" empleados.");
                        Console.WriteLine("Como desea que se llame su tienda ?");
                        string NomTienda = Console.ReadLine();
                        Console.WriteLine("Ahora, elija el precio maximo de algun elemto que vendera la tienda: ");
                        int PMaxT = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Precio Minimo?");
                        int PMinT = (int.Parse(Console.ReadLine()));
                        if (TipoTienda == "1")
                        {
                            Ropa ropa = new Ropa(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            //Local ropa = new Local(NEmpleados, VolTienda, PMinT, PMaxT);
                        }
                        else if (TipoTienda == "2")
                        {
                            Hogar hogar = new Hogar(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(hogar);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "3")
                        {
                            Alimento alimento = new Alimento(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(alimento);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "4")
                        {
                            Ferreteria ferreteria = new Ferreteria(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(ferreteria);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "5")
                        {
                            Tecnologia tecnologia = new Tecnologia(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(tecnologia);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "6")
                        {
                            Rapida rapida = new Rapida(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(rapida);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);

                        }
                        else if (TipoTienda == "7")
                        {
                            Restaurant restaurant = new Restaurant(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(restaurant);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "8")
                        {
                            Cine cine = new Cine(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(cine);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "9")
                        {
                            Juegos juegos = new Juegos(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(juegos);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else if (TipoTienda == "10")
                        {
                            Bowling bowling = new Bowling(NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i);
                            locales.Add(bowling);
                            l1.Add(NEmpleados.ToString());
                            l1.Add(VolTienda.ToString());
                            l1.Add(PMinT.ToString());
                            l1.Add(PMaxT.ToString());
                            l1.Add(NomTienda);
                            l1.Add(i.ToString());
                            Locs.Add(l1);
                        }
                        else
                        {
                            Console.WriteLine("No se logro crear el local. .l..");
                        }
                        VolDisponible = VolDisponible - VolTienda;
                        if (VolDisponible == 0)
                        {
                            r3 = "NO";
                        }
                        else
                        {
                            Console.WriteLine("Le quedan {0} m2 para seguir contruyendo sus tiendas en este piso.\nDesea contruir otra tienda en este piso?", (VolDisponible));
                            r3 = Console.ReadLine().ToUpper();
                        }
                        

                    }

                }
                r1 = "0"; // PAARA SALIR DEL WHILE!
            }
            //NEmpleados, VolTienda, PMinT, PMaxT, NomTienda, i
            int C = 0; //Clientes dia anterior
            int TiempoTrans = 1;
            int GanMayor = 0;
            string NomGMayor = "";
            int GanMenor = 0;
            string NomGMenor = "";
            int CliMayor = 0;
            string NomCliMayor = "";
            int CliMenor = 0;
            string NomCliMenor = "";
            string GananciaHist = "0";
            int GanTotales = 0;
            int ClientesTotales = 0;
            int NumEmpleados = 0;
            int V3Tienda = 0;
            for (int it = 0; it < Locs.Count(); it++)
            {
                Locs[it].Add(GananciaHist);
            }
            Pausa = false;
            while (TiempoTrans < 11)
            {
                Pausa = false;
               while (Pausa != true) //pausa OFF
                {
                    
                    for (int z = 0; z < Locs.Count(); z++) // Cada iteracion 1 local
                    { 
                        NumEmpleados = int.Parse(Locs[z][0]);
                        V3Tienda = int.Parse(Locs[z][1]);
                        int PMinL = int.Parse(Locs[z][2]);
                        int PMaxL = int.Parse(Locs[z][3]);
                        int PisoT = int.Parse(Locs[z][5]);
                        string Nombre = Locs[z][4];
                        int PromPrecioL = (PMaxL + PMinL) / 2;
                        int x1 = V3Tienda / 10;
                        int x2 = PromPrecioL/100; // EN la pauta sale que es div en 10 pero seria siempre muy bajo
                        int CMax = (C + (x1) * (x2) * NumEmpleados);
                        C = rnd.Next(0, CMax);
                        int GananciaL = 0;
                        int PrecioDiario = rnd.Next(PMinL, PMaxL);
                        int CostoArriendoL = V3Tienda * PrecioArriendo;
                        GananciaL = (C * PrecioDiario) - (NumEmpleados + CostoArriendoL);
                        int G = int.Parse(Locs[z][5]);
                        G += GananciaL;
                        Locs[z][6] = G.ToString();
                        string GTH1 = "";
                        string GTH2 = "";
                        GanTotales += GananciaL;
                        ClientesTotales += C;
                        if (GanMayor < GananciaL)
                        {
                            GanMayor = GananciaL;
                            NomGMayor = Nombre;
                            GTH1 = G.ToString();
                        }
                        if (GananciaL < GanMenor)
                        {
                            GanMenor = GananciaL;
                            NomGMenor = Nombre;
                            GTH2 = G.ToString();
                        }
                        if (CliMayor < C)
                        {
                            NomCliMayor = Nombre;
                        }
                        if (C < CliMenor)
                        {
                            NomCliMenor = Nombre;
                        }
                    
                    }
                    Pausa = true;   
                }
                int CliProm = ClientesTotales / TiempoTrans;
                Console.WriteLine("DIA {0}\nUsted Ha tenido:\n\t\t{1} Clientes en su Mall.\n\t\tEn promedio ha recibido {2} clientes diarios.\n\t\t" +
                    "Ha obtenido una ganancia total de ${3}.\n\t\tSu local con mayor ganacia este dia es {4}. Este local lleva ${5} recolectados.\n\t\t" +
                    "Su local con menor ganacia este dia es {6}. Este local lleva ${7} recolectados.\n\t\tSu local con mayor clientela este dia es {8}.\n\t\t" +
                    "Su local con menor clientela este dia es {9}.\n\t\t", TiempoTrans, ClientesTotales, CliProm, GanTotales, NomGMayor, GanMayor, NomGMenor, GanMenor, NomCliMayor, NomCliMenor);
                System.Threading.Thread.Sleep(1000);
                TiempoTrans += 1;
                

            }
            
            


            Console.ReadLine();
        }
    }
}
