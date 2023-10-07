using System;
using System.Collections;

namespace primeraEntrega
{
    internal class Program
    {
        static int captarEnteroPorConsola(String texto)
        {
            int numero=-1;

            System.Console.Write(texto);
            try
            {
                numero = Convert.ToInt32(System.Console.ReadLine());
            }
            catch (System.OverflowException SOex)
            {
                System.Console.WriteLine(SOex.Message);
            }
            catch(System.FormatException SFex)
            {
                System.Console.WriteLine(SFex.Message);
            }
            catch(System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return numero;
        }

        static Boolean esBisiesto(int anio)
        {
            Boolean bisiesto = false;
            if((anio%4 == 0 && anio%100 != 0)||anio%400 == 0){
                bisiesto=true;
            }
            return bisiesto;
        }

        static void imprimirTableroSinAlfil()
        {
            for(int columna = 0; columna < 8; columna++)
            {
                if(columna==0){
                    System.Console.Write("   ");
                    for (int i = 0; i < 8; i++)
                    {
                        System.Console.Write((i + 1) + " ");
                    }
                    System.Console.WriteLine("\n");
                }

                for(int fila = 0; fila <= 8; fila++)
                {
                    if (fila == 0)
                    {
                        System.Console.Write(columna + 1 + "  ");
                    }
                    else if((columna+fila)%2 == 0)
                    {
                        System.Console.Write("B ");
                    }
                    else if ((columna + fila) % 2 != 0)
                    {
                        System.Console.Write("N ");
                    }
                }
                System.Console.WriteLine();
            }
        }

        static void imprimirTableroConAlfil(int filaAlfil, int columnaAlfil)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                if (columna == 0)
                {
                    System.Console.Write("   ");
                    for (int i = 0; i < 8; i++)
                    {
                        System.Console.Write((i + 1) + " ");
                    }
                    System.Console.WriteLine("\n");
                }

                for (int fila = 0; fila <= 8; fila++)
                {
                    if (fila == 0)
                    {
                        System.Console.Write(columna + 1 + "  ");
                    }
                    else if (columna == columnaAlfil-1 && fila == filaAlfil)
                    {
                        System.Console.Write("A ");
                    }
                    else if ((columna + fila) % 2 == 0)
                    {
                        System.Console.Write("B ");
                    }
                    else if ((columna + fila) % 2 != 0)
                    {
                        System.Console.Write("N ");
                    }
                }
                System.Console.WriteLine();
            }
        }

        static bool movimientoValidoAlfil(int fila, int columna, int filaAlfil, int columnaAlfil)
        {
            bool movimientoValido = false;
            int desplazamiento_fila = Math.Abs(filaAlfil - fila);
            int desplazamiento_columna = Math.Abs(columnaAlfil-1 - columna);

            if(desplazamiento_columna == desplazamiento_fila)
            {
                movimientoValido = true;
            }
            
            return movimientoValido;
        }

        static void imprimirTableroConMovimientos(int filaAlfil, int columnaAlfil)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                if (columna == 0)
                {
                    System.Console.Write("   ");
                    for (int i = 0; i < 8; i++)
                    {
                        System.Console.Write((i + 1) + " ");
                    }
                    System.Console.WriteLine("\n");
                }

                for (int fila = 0; fila <= 8; fila++)
                {
                    if (fila == 0)
                    {
                        System.Console.Write(columna + 1 + "  ");
                    }
                    else if (columna == columnaAlfil - 1 && fila == filaAlfil)
                    {
                        System.Console.Write("A ");
                    }
                    else if (movimientoValidoAlfil(fila, columna, filaAlfil, columnaAlfil))
                    {
                        System.Console.Write("* ");
                    }
                    else if ((columna + fila) % 2 == 0)
                    {
                        System.Console.Write("B ");
                    }
                    else if ((columna + fila) % 2 != 0)
                    {
                        System.Console.Write("N ");
                    }
                }
                System.Console.WriteLine();
            }
        }

        static void holaMundo()
        {
            System.Console.WriteLine("\n¡Hola, mundo!");
        }

        static void calculosFijos()
        {
            double numero1 = 3.0, numero2 = 18.0;

            System.Console.WriteLine("\nBienvenido a la calculadora torpecilla.\nTe diré los cálculos con " + numero1 + " y " + numero2 + ".\n");

            //Suma
            System.Console.WriteLine("El resultado de " + numero1 + "+" + numero2 + " es: " + (numero1 + numero2));
            //Resta
            System.Console.WriteLine("El resultado de " + numero1 + "-" + numero2 + " es: " + (numero1 - numero2));
            //Multiplicación
            System.Console.WriteLine("El resultado de " + numero1 + "*" + numero2 + " es: " + (numero1 * numero2));
            //División
            System.Console.WriteLine("El resultado de " + numero1 + "/" + numero2 + " es: " + (numero1 / numero2).ToString("N4"));
            //Módulo 1%2
            System.Console.WriteLine("El resultado de " + numero1 + "%" + numero2 + " es: " + (numero1 % numero2));
            //Módulo 2%1
            System.Console.WriteLine("El resultado de " + numero2 + "%" + numero1 + " es: " + (numero2 % numero1));
        }

        static void calcularMayor()
        {
            System.Console.WriteLine("\nBienvenido a la calculadora de mayores.\nTe diré cuál es el mayor de los dos números que introduzcas.\n");

            int numero1 =0, numero2=0;
            numero1 = captarEnteroPorConsola("Introduzca el primer número entero: ");
            numero2 = captarEnteroPorConsola("Introduzca el segundo número entero: ");
           
            if(numero1 == numero2)
            {
                System.Console.WriteLine("Los números " + numero1 + " y " + numero2 + " son iguales.");
            }
            else if (numero1 > numero2)
            {
                System.Console.WriteLine("El número " + numero1 + " es mayor que " + numero2 + ".");
            }
            else
            {
                 System.Console.WriteLine("El número " + numero2 + " es mayor que " + numero1 + ".");
            }
        }

        static void sonPares()
        {
            System.Console.WriteLine("\nBienvenido al comparador de pares e impares.\nTe diré de dos números que introduzcas si son pares o impares.\n");

            int numero1 = 0, numero2 = 0;
            numero1 = captarEnteroPorConsola("Introduzca el primer número entero: ");
            numero2 = captarEnteroPorConsola("Introduzca el segundo número entero: ");

            if (numero1%2 == 0 && numero2%2 == 0)
            {
                System.Console.WriteLine("Los números " + numero1 + " y " + numero2 + " son pares.");
            }
            else if(numero1%2 !=0 && numero2%2 !=0)
            {
                System.Console.WriteLine("Los números " + numero1 + " y " + numero2 + " son impares.");
            }
            else if (numero1%2 !=0 && (numero2 % 2 == 0))
            {
                System.Console.WriteLine("El número " + numero1 + " es impar y el número " + numero2 + " es par.");
            }
            else
            {
                System.Console.WriteLine("El número " + numero1 + " es par y el número " + numero2 + " es impar.");
            }
        }
        
        static void adivino()
        {
            System.Console.WriteLine("\nBienvenido al juego de adivinar números.\nTienes 5 oportunidades para introducir números del 0 al 20.\nMientras no aciertes, te iré dando pistas.");

            int numero1 = 0, numero2 = 0;
            Boolean acertado = false;
            /*    
                do
                {
                    numero1 = captarEnteroPorConsola();
                } while (numero1 < 0 || numero1 > 20);
                //Borrar el número "secreto"
                System.Console.Clear();
            */

            //Generamos un número aleatorio
            numero1 = new Random().Next(0, 20);
            //Empieza la partida
            System.Console.WriteLine("¡Intenta adivinar el número!\n");
            for(int i = 0; i < 5 && !acertado ; i++)
            {
                do
                {
                    numero2 = captarEnteroPorConsola("Introduzca un número entre 0 y 20: ");
                } while (numero2 < 0 || numero2 > 20);

                if (numero1 == numero2)
                {
                    acertado = true;
                }
                else if (i != 4) {
                    if (numero2 > numero1)
                    {
                        System.Console.WriteLine("Intenta con un número más pequeño...");
                    }
                    else
                    {
                        System.Console.WriteLine("Intenta con un número más grande...");
                    }
                }
            }

            //Mostrar resultado
            if (acertado)
            {
                System.Console.WriteLine("\n¡ENHORABUENA!! Has encontrado el número secreto.");
            }
            else
            {
                System.Console.WriteLine("\nSe te agotaron los intentos. El número era " + numero1 + ". Prueba más suerte la próxima vez...");
            }
        }

        static void cuentasietes()
        {
            int numeroIntroducido = 0, digitoInt=0, cantidadSietes=0;
            String numero = "";

            System.Console.WriteLine("\nBienvenido a la calculadora de sietes en un número entero.\nTe diré cuántos 7 tiene el número que introduzcas.\n");

            numeroIntroducido = captarEnteroPorConsola("Introduzca un número entero: ");
            numero = numeroIntroducido.ToString();

            //Solución con entero
            System.Console.WriteLine("Resolución do while con entero: ");
            do
            {
                digitoInt = numeroIntroducido % 10;
                if(digitoInt == 7)
                {
                    cantidadSietes++;
                }
                numeroIntroducido /= 10;
            }
            while (numeroIntroducido > 0);
            System.Console.WriteLine("El número de sietes es: " + cantidadSietes + "\n");

            //Solución con cadena
            cantidadSietes = 0;
            System.Console.WriteLine("Resolución for each con cadena: ");
            foreach(char digito in numero)
            {
                if (digito == '7')
                {
                    cantidadSietes++;
                }
            }
            System.Console.WriteLine("El número de sietes es: " + cantidadSietes + "\n");
        }
        
        static void diasDelMes()
        {
            int mes = 0, anio = 0, dias = 0;
            System.Console.WriteLine("\nBienvenido a la calculadora de días del mes.\nTe diré los días que tiene el mes del año que quieras.\n");
            do
            {
                mes= captarEnteroPorConsola("Introduzca el mes (1-20): ");
            }while(mes < 1 || mes > 12);
            do
            {
                anio = captarEnteroPorConsola("Introduzca el año (0-2100): ");
            } while (anio < 0 || anio > 2100);

            switch(mes)
            {
                case 4:
                case 6:
                case 8:
                case 11:
                    dias = 30;
                    break;
                case 2:
                    dias = 28;
                    if (esBisiesto(anio))
                    {
                        dias = 29;
                    }
                    break;
                default:
                    dias = 31;
                    break;
            }

            System.Console.WriteLine("\nEl mes " + mes + " del año " + anio + " tiene " + dias + " días.\n");
        }

        static void ajedrez()
        {
            int fila = 0, columna = 0;
            //Bienvenida e instrucciones
            System.Console.WriteLine("\nCalculadora de movimientos válidos del alfil\n\nBienvenido, introduzca la posición del alfil en el tablero: \n");
            imprimirTableroSinAlfil();
            
            //Solicitar datos al usuario
            do
            {
                fila = captarEnteroPorConsola("\nIntroduzca la fila (1-8) en la que se encuentra el alfil: ");

            }while(fila<1 || fila > 8);
            do
            {
                columna = captarEnteroPorConsola("Introduzca la columna (1-8) en la que se encuentra el alfil: ");

            } while (columna< 1 || columna > 8);

            //Dibujar el alfil en el tablero
            imprimirTableroConAlfil(fila, columna);

            //Mostrar los movimientos válidos
            System.Console.WriteLine("\n\nCalculando los movimientos válidos...\n");
            imprimirTableroConMovimientos(fila, columna);
            System.Console.WriteLine();
        }

        static void divisiones()
        {
            int numero1=0, numero2=0;
            double resultado=0.0;
            bool numeroCorrecto = true, operacionValida=true;

            //Bienvenido
            System.Console.WriteLine("\nCalculadora de divisiones\n\n");

            //Introducir datos por el usuario
            do {
                numeroCorrecto = true;
                System.Console.Write("Introduce un número entero para el dividendo: ");
                try
                {
                    numero1 = Convert.ToInt32(System.Console.ReadLine());
                }
                catch(System.OverflowException SOEx)
                {
                    System.Console.WriteLine(SOEx.Message);
                    numeroCorrecto = false;
                }
                catch(System.FormatException SFEx)
                {
                    System.Console.WriteLine(SFEx.Message);
                    numeroCorrecto = false;
                }
                catch(System.Exception SEx)
                {
                    System.Console.WriteLine(SEx.Message);
                    numeroCorrecto = false;
                }
            } while (!numeroCorrecto);

            do
            {
                numeroCorrecto = true;
                System.Console.Write("Introduce un número entero para el divisor: ");
                try
                {
                    numero2 = Convert.ToInt32(System.Console.ReadLine());
                }
                catch (System.OverflowException SOEx)
                {
                    System.Console.WriteLine(SOEx.Message);
                    numeroCorrecto = false;
                }
                catch (System.FormatException SFEx)
                {
                    System.Console.WriteLine(SFEx.Message);
                    numeroCorrecto = false;
                }
                catch (System.Exception SEx)
                {
                    System.Console.WriteLine(SEx.Message);
                    numeroCorrecto = false;
                }
            } while (!numeroCorrecto);

            //Realizar los cálculos
            try
            {
                resultado = (Double) numero1 / (Double) numero2;
            }
            catch(System.DivideByZeroException DBZex) { 
                System.Console.WriteLine(DBZex.Message);
                operacionValida = false;
            }
            catch(System.Exception Ex)
            {
                System.Console.WriteLine(Ex.Message);
                operacionValida=false;
            }

            //Mostrar resultado
            if (operacionValida)
            {
                System.Console.WriteLine("Resultado: " + numero1 + "/" + numero2 + " = " + resultado + ".\n");

            }
        }

        static void Main(string[] args)
        {
            int eleccion;
            Boolean continuar = true;
            do
            {
                System.Console.WriteLine("\n\nMENÚ INICIAL:\n\n1. Hola mundo\n2. Cálculos fijos\n3. Calcular mayor" +
                                            "\n4. ¿Son pares?\n5. Adivino\n6. Cuentasietes\n7. Días del mes\n8. Ajedrez" +
                                            "\n9. Divisiones\nCualquier otro: Salir\n");

                eleccion = captarEnteroPorConsola("Introduzca el número del programa a ejecutar: ");
                System.Console.Clear();

                switch (eleccion)
                {
                    case 1:
                        holaMundo();
                        break;
                    case 2:
                        calculosFijos();
                        break;
                    case 3:
                        calcularMayor();
                        break;
                    case 4:
                        sonPares();
                        break;
                    case 5:
                        adivino();
                        break;
                    case 6:
                        cuentasietes();
                        break;
                    case 7:
                        diasDelMes();
                        break;
                    case 8:
                        ajedrez();
                        break;
                    case 9:
                        divisiones();
                        break;
                    default:
                        continuar = false;
                        break;
                }
            } while (continuar);

            System.Console.WriteLine("\n¡Hasta pronto!\n");
        }
    }
}
