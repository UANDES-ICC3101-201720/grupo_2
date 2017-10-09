using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_POO
{
    class Mall
    {
        public int dinero, horas;
        public List<Piso> lista_pisos= new List<Piso>();

        public Mall(int horas, int dinero)
        {
            this.horas = horas;
            this.dinero = dinero;
        }

        public void Crear_Pisos()
        {
            Console.Write("Indique Cantidad de pisos \n>>");
            int Cantidad = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=Cantidad)
            {
                Console.Write("Indique Area a ingresar para el piso {0} \n>>", i);
                int Area = Convert.ToInt32(Console.ReadLine());
                if (lista_pisos.Count() == 0)
                {
                    Piso piso = new Piso(Area);
                    this.lista_pisos.Add(piso);
                    Console.WriteLine("PRIMER PISO CREADO\n");
                    i++;
                }
                else
                {
                    if (lista_pisos.Last().precioArriendo < Area)
                    {
                        Console.WriteLine("Error, Area mayor al piso anterior"); //ERROR area mayor al piso anterior
                    }
                    else if (lista_pisos.Last().precioArriendo >= Area)
                    {
                        Piso piso = new Piso(Area);
                        this.lista_pisos.Add(piso);
                        Console.WriteLine("PISO CREADO\n");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Error, numero invalido"); //ERROR de tipeo (?)
                    }
                }
            }
        }
        public void Crear_piso()
        {
            Console.Write("Indique Area a ingresar para el piso {0} \n>>", lista_pisos.Count()+1);
            int Area = Convert.ToInt32(Console.ReadLine());
            if (lista_pisos.Last().precioArriendo < Area)
            {
                Console.WriteLine("Error, Area mayor al piso anterior({0})", lista_pisos.Last().precioArriendo); //ERROR area mayor al piso anterior
            }
            else if (lista_pisos.Last().precioArriendo >= Area)
            {
                Piso piso = new Piso(Area);
                this.lista_pisos.Add(piso);
                Console.WriteLine("PISO CREADO\n");
            }
            else
            {
                Console.WriteLine("Error, numero invalido"); //ERROR de tipeo (?)
            }
        }
        public void Crear_Locales()
        {
            Console.Write("Ingrese piso al cual agregar los locales (cantidad de pisos: {0})\n>>", lista_pisos.Count());
            int piso = Convert.ToInt32(Console.ReadLine());
            while ((piso<0)||(piso>lista_pisos.Count())||(piso==0))
            {
                Console.Write("Error, numero invalido\nIngrese piso al cual agregar los locales (cantidad de pisos: {0})\n>>", lista_pisos.Count());
                piso = Convert.ToInt32(Console.ReadLine());
                if (piso > 0) { break; }
            }
            piso--;
            if (lista_pisos[piso].ocupado == false)
            {
  
                Console.WriteLine("Area Disponible para piso {0}: {1}m2", piso+1, lista_pisos[piso].precioArriendo);
                Console.Write("Ingrese Cantidad de locales\n>>");
                int cant_locales = Convert.ToInt32(Console.ReadLine());
                int area_total_locales = 0;
                int area_piso = lista_pisos[piso].precioArriendo;
                int contador = 0;
                while ((area_piso != area_total_locales) && (cant_locales != contador))
                {
                    Console.Write("Ingrese Area de local {0}\n>>", contador + 1);
                    int area_local = Convert.ToInt32(Console.ReadLine());
                    area_total_locales += area_local;

                    if (area_piso < area_total_locales)
                    {
                        area_total_locales -= area_local;
                        Console.WriteLine("Problema al crear el local ...");
                        Console.WriteLine("Puede ingresar un numero menor a: {0}", (area_piso - area_total_locales));
                        Console.WriteLine("Ingrese otro valor para Area de local\n");
                    }
                    else
                    {
                        contador += 1;
                        Console.WriteLine("Creando Local numero {0} ...\n", contador);
                        //CREAR LOCAL (Creamos locales iguales para prueba)
                        string nombre = "Nombre Prueba";
                        int c_empleados = 5;
                        int area_del_local = area_local;
                        int precio_min = 100;
                        int precio_max = 200;
                        string categoria = "categoria ejemplo";
                        int c_anterior = 20;

                        Local local = new Local(nombre, c_empleados, area_del_local, precio_min, precio_max, categoria, c_anterior);
                        lista_pisos[piso].Add(local);
                        if ((area_piso == area_total_locales) && (cant_locales == contador))
                        { break; }
                    }
                    if ((area_piso - area_total_locales == 0) && (cant_locales != 0))
                    {
                        Console.WriteLine("SIN ESPACIO DISPONIBLE, QUEDAN LOCALES POR HACER");
                        Console.Write("...RESET...\n");
                        Console.Write("Ingrese Cantidad de locales\n>>");
                        cant_locales = Convert.ToInt32(Console.ReadLine());
                        area_piso = 0;
                        contador = 0;

                    }
                    Console.WriteLine("Cantidad de Locales en piso {1}: {0}", contador, lista_pisos.Count());
                    Console.WriteLine("Locales por hacer: {0}", (cant_locales - contador));
                    Console.WriteLine("Area Disponible: {0}\n", (area_piso - area_total_locales));
                }
            Console.WriteLine("LOCALES CREADOS CON EXITO.\n");
            lista_pisos[piso].ocupado = true;
            }
            else
            {
                Console.WriteLine("ERROR, Piso ocupado");
            }            
        }        
    }
}
