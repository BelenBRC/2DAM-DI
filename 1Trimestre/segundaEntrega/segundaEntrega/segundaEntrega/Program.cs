

using System;
using System.Reflection.Emit;

namespace segundaEntrega
{
    internal class Program
    {
        static int captarEnteroPorConsola(String texto)
        {
            int numero = -1;

            System.Console.Write(texto);
            try
            {
                numero = Convert.ToInt32(System.Console.ReadLine());
            }
            catch (System.OverflowException SOex)
            {
                System.Console.WriteLine(SOex.Message);
            }
            catch (System.FormatException SFex)
            {
                System.Console.WriteLine(SFex.Message);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return numero;
        }

        static String captarCadenaPorConsola(String texto)
        {
            String cadena = "";

            System.Console.Write(texto);
            try
            {
                cadena = System.Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            return cadena;
        }

        static void divisiones()
        {
            int numero1 = 0, numero2 = 0;
            double resultado = 0.0;
            bool numeroCorrecto = true, operacionValida = true;

            //Bienvenido
            System.Console.WriteLine("\nCalculadora de divisiones\n\n");

            //Introducir datos por el usuario
            do
            {
                numeroCorrecto = true;
                System.Console.Write("Introduce un número entero para el dividendo: ");
                try
                {
                    numero1 = Convert.ToInt32(System.Console.ReadLine());
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
                resultado = (Double)numero1 / (Double)numero2;
            }
            catch (System.DivideByZeroException DBZex)
            {
                System.Console.WriteLine(DBZex.Message);
                operacionValida = false;
            }
            catch (System.Exception Ex)
            {
                System.Console.WriteLine(Ex.Message);
                operacionValida = false;
            }

            //Mostrar resultado
            if (operacionValida)
            {
                System.Console.Write("Resultado: " + numero1 + "/" + numero2 + " = ");
                if (resultado % 1 != 0)
                {
                    System.Console.WriteLine("{0:N2}", resultado);
                }
                else
                {
                    System.Console.WriteLine(resultado);
                }
                System.Console.WriteLine();

            }
        }

        static void imprimirVector(int[] vectorEnteros)
        {
            System.Console.Write("Valores: ");
            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                System.Console.Write(vectorEnteros[i] + " ");
            }
            System.Console.WriteLine();
        }

        static int buscarMinimo(int[] vectorEnteros)
        {
            int minimo = vectorEnteros[0];

            for(int i = 1; i < vectorEnteros.Length; i++)
            {
                if (vectorEnteros[i] < minimo)
                {
                    minimo = vectorEnteros[i];
                }
            }

            return minimo;
        }

        static int buscarMaximo(int[] vectorEnteros)
        {
            int maximo = vectorEnteros[0];

            for (int i = 1; i < vectorEnteros.Length; i++)
            {
                if (vectorEnteros[i] > maximo)
                {
                    maximo = vectorEnteros[i];
                }
            }

            return maximo;
        }

        static int[] ordenarVectorMenorAMayor(int[] vectorEnteros)
        {
            int brecha = vectorEnteros.Length;
            bool intercambio = true;
            
            //Copiamos el vector
            int[] vectorOrdenado = new int[vectorEnteros.Length];
            for(int i = 0; i<vectorEnteros.Length; i++)
            {
                vectorOrdenado[i] = vectorEnteros[i];
            }

            //Ordenamos el nuevo vector siguiendo el método de comboSort
            while(brecha!=1 || intercambio)
            {
                //Establecemos la separación entre números a comprobar
                brecha = (int) ((Double) brecha / 1.3);
                if (brecha < 1)
                {
                    brecha = 1;
                }

                //Actualizamos el booleano de intercambios a false
                intercambio = false;

                for(int i = 0; i<vectorEnteros.Length - brecha; i++)
                {
                    if (vectorOrdenado[i] > vectorOrdenado[i + brecha])
                    {
                        //Intercambiamos los valores
                        int aux = vectorOrdenado[i];
                        vectorOrdenado[i] = vectorOrdenado[i + brecha];
                        vectorOrdenado[i + brecha] = aux;
                        //Actualizamos booleano
                        intercambio = true;
                    }
                }
            }

            return vectorOrdenado;
        }

        static void vectorValores()
        {
            int elementos = 0;
            Random numerosAleatorios = new Random();

            //Bienvenida
            System.Console.WriteLine("\n¡Bienvenido al programa de gestión de enteros en vactores!\nEl programa generará un vector con tantos números enteros aleatorios como indiques.\n");

            //Solicitar el número de elementos a generar
            do
            {
                elementos = captarEnteroPorConsola("Indique la cantidad de números a generar (mínimo 2): ");
            } while (elementos < 2);

            //Crear el vector
            int[] vectorEnteros = new int[elementos];

            //Rellenar el vector con números [0-100] generados aleatoriamente
            for(int i = 0; i < vectorEnteros.Length; i++)
            {
                vectorEnteros[i] = numerosAleatorios.Next(0, 101);
            }

            //Imprimir el vector
            System.Console.WriteLine("\nEste es tu vector: ");
            imprimirVector(vectorEnteros);


            //Ordenar el vector de menor a mayor
            System.Console.WriteLine("\nOrdenemos el vector de menor a mayor...: ");
            imprimirVector(ordenarVectorMenorAMayor(vectorEnteros));

            //Mostrar el valor mayor del vector
            System.Console.WriteLine("El valor más alto del vector es: " + buscarMaximo(vectorEnteros));


            //Mostrar el valor menor del vector
            System.Console.WriteLine("El valor más bajo del vector es: " + buscarMinimo(vectorEnteros));
        }

        static void cuentaceros()
        {
            int[] vector = new int[10];
            int totalCeros = 0;

            //Bienvenida
            System.Console.WriteLine("\n¡Bienvenido al programa de cuentaceros. \nIntroduce 10 números enteros y te diré cuántos ceros hay.\n");

            //Solicitud de números
            System.Console.WriteLine("Por favor, introduce los 10 números enteros (0-9): ");
            for(int i = 0; i < vector.Length; i++)
            {
                do
                {
                    vector[i] = captarEnteroPorConsola("Número " + (i+1) + ": ");
                } while(vector[i] < 0 || vector[i] > 9);
                if (vector[i] == 0)
                {
                    totalCeros++;
                }
            }

            //Imprimir resultado
            System.Console.WriteLine();
            imprimirVector(vector);
            System.Console.WriteLine("En este vector hay " + totalCeros + " ceros.");

        }

        static double calcularPorcentaje(int veces, int total)
        {
            double porcentaje = 0.0;
            porcentaje = ((Double) veces / (Double) total)*100.0;
            return porcentaje;
        }

        static void dados()
        {
            int tiradas = 0, total1=0, total2=0, total3=0, total4=0, total5=0, total6=0;
            Random numerosAleatorios = new Random();

            //Bienvenida
            System.Console.WriteLine("\n¡Bienvenido al programa de tiradas de dados. \nEl programa tirará el dado tantas veces como indiques, y se mostrará las veces que sale cada número.\n");

            //Solicitar el número de tiradas
            do
            {
                tiradas = captarEnteroPorConsola("Indique el número de tiradas de dado a generar (mínimo 2): ");
            } while (tiradas < 2);

            //Crear el vector
            int[] vectorTiradas = new int[tiradas];

            //Rellenar el vector con tiradas [1-6] generadas aleatoriamente
            for (int i = 0; i < vectorTiradas.Length; i++)
            {
                vectorTiradas[i] = numerosAleatorios.Next(1, 7);
            }

            //Mostrar los valores de las tiradas
            imprimirVector(vectorTiradas);

            //Contar las veces que sale cada tirada
            for(int i = 0; i < vectorTiradas.Length; i++)
            {
                switch (vectorTiradas[i])
                {
                    case 1:
                        total1++;
                        break;
                    case 2:
                        total2++;
                        break;
                    case 3:
                        total3++;
                        break;
                    case 4:
                        total4++;
                        break;
                    case 5:
                        total5++;
                        break;
                    case 6:
                        total6++;
                        break;
                    case 7:
                        System.Console.WriteLine("¡Error! Valor no permitido en el vector de tiradas");
                        break;
                }
            }

            //Mostrar resultado de las tiradas
            System.Console.Write("\nEstos son los resultados de la tirada:" +
                                     "\nTotal 1: " + total1 + "\t");
            System.Console.Write("{0:N2}" , calcularPorcentaje(total1, tiradas));
            System.Console.Write("%" + "\nTotal 2: " + total2 + "\t");
            System.Console.Write("{0:N2}", calcularPorcentaje(total2, tiradas));
            System.Console.Write("%" + "\nTotal 3: " + total3 + "\t");
            System.Console.Write("{0:N2}", calcularPorcentaje(total3, tiradas));
            System.Console.Write("%" + "\nTotal 4: " + total4 + "\t");
            System.Console.Write("{0:N2}", calcularPorcentaje(total4, tiradas));
            System.Console.Write("%" + "\nTotal 5: " + total5 + "\t");
            System.Console.Write("{0:N2}", calcularPorcentaje(total5, tiradas));
            System.Console.Write("%" + "\nTotal 6: " + total6 + "\t");
            System.Console.Write("{0:N2}", calcularPorcentaje(total6, tiradas));
            System.Console.Write("%\n");
        }

        static String traducirJugada(int jugada)
        {
            String jugadaTraducida = "";
            switch (jugada)
            {
                case 1:
                    jugadaTraducida = "Piedra";
                    break;
                case 2:
                    jugadaTraducida = "Papel";
                    break;
                case 3:
                    jugadaTraducida = "Tijera";
                    break;
            }
            return jugadaTraducida;
        }

        static void printMarcador(int[,] marcador, int ronda)
        {
            System.Console.WriteLine("\nMarcador:");
            System.Console.WriteLine("Ronda\tUsuario\tOrdenador");
            for(int i = 0; i <= ronda; i++)
            {
                System.Console.WriteLine((i+1) + "\t" + marcador[i, 0] + "\t" + marcador[i, 1]);
            }
        }

        static void piedraPapelTijera()
        {
            int jugadaOrdenador=0, jugadaUsuario = 0, puntosUsuario = 0, puntosOrdenador = 0;
            String cadenaJugadaUsuario = "";
            Random jugadaAleatoria = new Random();
            //Matriz que almacena los pares de puntos de cada jugada
            int[,] marcador = new int[5, 5];

            //Bienvenida
            System.Console.WriteLine("\n¡Bienvenido al juego piedra, papel o tijera. \nJugaremos 5 rondas. ¿Puedes ganarme?.\n");

            //Jugadas
            for(int i=0; i<5; i++)
            {
                System.Console.WriteLine("\nRonda " + (i + 1) + ": \n¡Piensa tu jugada!");
                //Jugada del ordenador
                jugadaOrdenador = jugadaAleatoria.Next(1, 4);

                //Jugada del usuario
                System.Console.WriteLine("¿Piedra, papel o tijera?");
                do
                {
                    cadenaJugadaUsuario = captarCadenaPorConsola("Escribe tu jugada: ");
                } while (!cadenaJugadaUsuario.Trim().ToLower().Equals("piedra") && !cadenaJugadaUsuario.ToLower().Equals("papel") && !cadenaJugadaUsuario.ToLower().Equals("tijera"));

                //Traducir jugada usuario
                switch (cadenaJugadaUsuario.ToLower())
                {
                    case "piedra":
                        jugadaUsuario = 1;
                        break;
                    case "papel":
                        jugadaUsuario = 2;
                        break;
                    case "tijera":
                        jugadaUsuario = 3;
                        break;
                }

                //Mostrar jugadas
                System.Console.WriteLine("\nTu jugada: " + traducirJugada(jugadaUsuario) + "\nJugada del ordenador: " + traducirJugada(jugadaOrdenador));

                if (jugadaUsuario == jugadaOrdenador)
                {
                    puntosOrdenador++;
                    puntosUsuario++;
                    System.Console.WriteLine("¡Empate!");
                    marcador[i, 0]= puntosUsuario;
                    marcador[i, 1] = puntosOrdenador;
                }
                else if (Math.Abs(jugadaOrdenador-jugadaUsuario) == 1)
                {
                    //Piedra vs papel o papel vs tijera
                    if (jugadaOrdenador > jugadaUsuario)
                    {
                        puntosOrdenador++;
                        System.Console.WriteLine("¡Gano yo!");
                        marcador[i, 0] = puntosUsuario;
                        marcador[i, 1] = puntosOrdenador;
                    }
                    else
                    {
                        puntosUsuario++;
                        System.Console.WriteLine("¡Ganas tú!");
                        marcador[i, 0] = puntosUsuario;
                        marcador[i, 1] = puntosOrdenador;
                    }
                }
                else
                {
                    //Piedra vs tijera
                    if (jugadaOrdenador > jugadaUsuario)
                    {
                        puntosUsuario++;
                        System.Console.WriteLine("¡Ganas tú!");
                        marcador[i, 0] = puntosUsuario;
                        marcador[i, 1] = puntosOrdenador;
                    }
                    else
                    {
                        puntosOrdenador++;
                        System.Console.WriteLine("¡Gana el ordenador!");
                        marcador[i, 0] = puntosUsuario;
                        marcador[i, 1] = puntosOrdenador;
                    }
                }

                printMarcador(marcador, i);
            }

            //Mostrar resultado
            System.Console.WriteLine("\n\n¡Fin del juego!");
            if(puntosOrdenador > puntosUsuario)
            {
                System.Console.WriteLine("¡Gano yo! Más suerte la próxima vez...\n");
            }
            else if (puntosOrdenador < puntosUsuario)
            {
                System.Console.WriteLine("¡Tú ganas! ¡¡Enhorabuena!!\n");
            }
            else
            {
                System.Console.WriteLine("¡Empate! Gran jugada.\n");
            }
        }

        static void Main(string[] args)
        {
            int eleccion;
            Boolean continuar = true;
            do
            {
                System.Console.WriteLine("\n\nMENÚ INICIAL:\n\n1. Divisiones\n2. Vector de valores\n3. Cuentaceros" +
                                            "\n4. Dados\n5. Piedra, papel o tijera\nCualquier otro: Salir\n");

                eleccion = captarEnteroPorConsola("Introduzca el número del programa a ejecutar: ");
                System.Console.Clear();

                switch (eleccion)
                {
                    case 1:
                        //Divisiones
                        divisiones();
                        break;
                    case 2:
                        //Vector de valores
                        vectorValores();
                        break;
                    case 3:
                        //Cuentaceros
                        cuentaceros();
                        break;
                    case 4:
                        //Dados
                        dados();
                        break;
                    case 5:
                        //Piedra, papel o tijera
                        piedraPapelTijera();
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