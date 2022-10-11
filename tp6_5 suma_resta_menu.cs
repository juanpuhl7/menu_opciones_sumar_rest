using System;

namespace prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            //suma, resta, division, multiplicacion con menu.

            int num1, num2, opcion;
            float resultado=0f;

            Console.WriteLine("- - - - - - - - - - - - - -");
            Console.WriteLine("||  BIENVENIDO AL SISTEMA  ||");
            Console.WriteLine("- - - - - - - - - - - - - -");
        

            Console.WriteLine(" ");
            Console.WriteLine("Presione una tecla para continuar. . .  ");
            Console.ReadKey();
            Console.Clear();

            //Menu de opciones.
            do{
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Ingrese opcion: ");   
                opcion=Convert.ToInt32(Console.ReadLine());

                if(opcion !=1 && opcion !=2 && opcion !=3 && opcion !=4 && opcion !=0 ){
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un numero valido.");
                }

            } while ((opcion >4 || opcion <1) && opcion != 0);

            if(opcion !=0){
            
            Console.Clear();

            Console.WriteLine("Ingrese NUMERO 1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese NUMERO 2: ");
            num2=Convert.ToInt32(Console.ReadLine());

            // opcion de casos, segun la opcion elegida.
            switch(opcion){
                case 1: 
                Console.Clear();               
                Console.WriteLine("SUMA DE: " + num1 + " y " + num2);
                resultado=num1 + num2;
                break;
                case 2:
                Console.Clear();
                Console.WriteLine("RESTA DE: " + num1 + " y " + num2);
                resultado=num1-num2;
                break;
                case 3:
                Console.Clear();
                if(num2 == 0){
                    Console.Clear();
                    Console.WriteLine("El numero 2 ingresado es: 0; la division por cero es indeterminado.");
                    Console.WriteLine("Presione una tecla para continuar. . .  ");
                    Console.ReadKey();
                    Console.Clear();    
                    Console.WriteLine("INGRESE OPCION: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("1 - Cambiar valor del Divisor");
                    Console.WriteLine("0 - Continuar igual...  ");
                    opcion=Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                if(opcion == 1){
                        Console.WriteLine("Ingrese NUMERO 2: ");
                        num2=Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }


                }
                Console.WriteLine("DIVISION DE: " + num1 + " y " + num2);
                resultado=((float)num1 / (float)num2);
                break;
                case 4:
                Console.Clear();
                Console.WriteLine("MULTIPLICACION DE: " + num1 + " y " + num2);
                resultado= num1 * num2;
                break;
               
                default:
                Console.WriteLine("No selecciono opcion valida.");
                break;

            }
            Console.WriteLine("El resultado es : " + resultado);

            }
            Console.WriteLine("Finalizo el programa...");
        }
    }
}