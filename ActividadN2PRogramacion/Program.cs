using System;

namespace ActividadN2PRogramacion
{

    class Program
    {
        static void Main(string[] args)
        {



            int Opcion;
            Opcion = 0;
                
            Console.WriteLine("::Menu");

                Console.WriteLine("Opcion 1");
                Console.WriteLine(" ");
                Console.WriteLine("Opcion 2");
                Console.WriteLine(" ");
                Console.WriteLine("Opcon 3");
                Console.WriteLine("             ");
                Console.WriteLine("Opcion 4");
                Console.WriteLine("             ");
                Console.WriteLine("");
                Console.WriteLine("_________________________________________");
                Console.Write("Digite una Opcion del menu");
                Console.WriteLine("");
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                    Programa1();
                        break;

                    case 2:
                    Programa2();
                        break;

                    case 3:
                    Programa3();
                        break;
                    case 4:
                    Programa4();
                        break;
                    case 0:
                        Console.Write("adios, vuelve pronto....!!");
                        break;

                    default:
                        Console.Write("Lo siento, la opcion que marco no se encuentra en el menu");
                        break;
                }

            static void Programa1()
            {
                System.Console.WriteLine("Este es el programa 1");
            }




            static void Programa2()
            {
                System.Console.WriteLine("Este es el programa 2");
            }



            static void Programa3()
            {
                System.Console.WriteLine("Este es el programa 3");

            }




            static void Programa4()
            {
                System.Console.WriteLine("Este es el programa 4");
            }
        }
    }
        }
  
  

