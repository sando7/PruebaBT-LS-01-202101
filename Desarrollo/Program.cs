using System;

namespace Desarrollo
{
    class Programa_Matriz
    {
        private int[,] Matriz;
        private int[,] MatrizColumna3;
        private int[,] MatrizRedimensionada;
        private Double[,] MatrizActualizada;
        private Double[,] MatrizCalculosActualizada;
        static void Main(string[] args)
        {
            Programa_Matriz Matriz = new Programa_Matriz();
            // Creación de la matriz de 10*3 con valores Random
            Matriz.CrearMatriz();
            // Impresion de la matriz creada
            Matriz.ImprimirMatriz();
            // Se suma la columna 1 y 2 y se agrega el resultado en la columna3
            Matriz.SumarColumna3();
            // Agregar dos filas y una columna (vacías)
            Matriz.RedimensionarMatriz();
            // Trasladar los valores de las[filas 1 y 2][columna 1] hacia las filas nuevas y suma de ([filas 1 y 2] [columna 2])
            Matriz.TrasladoValores();
            // agregar valores en columna 4 y eliminando los valores de las[filas 1 y 2] [columna 2]
            Matriz.ActualizarValores();
            // Alistar la matriz con los calculos finales
            Matriz.CalcularTotalValoresActualizados();
        }
        public static class Globals
        {
            // Variable Global para guardar valores eliminados.
            public static Int32 Total_Fila1_2_Columna2 = 0;
            public static Double ValoresFila3_7_Columna4 = 0.0;
        }
        public void CrearMatriz()
        {
            try
            {
                // Declarando las filas y columnas de la Matriz
                int Filas = 10;
                int Columnas = 3;
                Matriz = new int[Filas, Columnas];
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                // Imprimiendo las dimensiones de la Matriz
                Console.WriteLine("Cantidad de filas de la Matriz: " + Matriz.GetLength(0));
                Console.WriteLine("Cantidad de columnas de la Matriz: " + Matriz.GetLength(1));
                // Declarando variable para generar número random
                Random NumRandom = new Random();
                // Llenando las columnas 1 y 2 con numeros random
                for (int Fila = 0; Fila < Matriz.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < Matriz.GetLength(1) - 1; Columna++)
                    {
                        Matriz[Fila, Columna] = NumRandom.Next(1, 10);
                    }
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Creación y Carga de Datos Completa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de crear y cargar la matriz: " + ex.Message);
            }
        }
        public void ImprimirMatriz()
        {
            try
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Matriz Creada:");
                for (int Fila = 0; Fila < Matriz.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < Matriz.GetLength(1); Columna++)
                    {
                        // Imprimiendo valores por fila
                        Console.Write(Matriz[Fila, Columna] + "\t");
                    }
                    // Siguiente linea
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de imprimir datos: " + ex.Message);
            }
        }
        public void SumarColumna3()
        {
            try
            {
                // Creamos la matriz que guarda la suma de columna 1 y 2
                int Filas = Matriz.GetLength(0);
                int Columnas = Matriz.GetLength(1);
                int Total = 0;
                MatrizColumna3 = new int[Filas, Columnas];
                //Sumamos la columnas 1 y 2 en columna 3
                for (int Fila = 0; Fila < Filas; Fila++)
                {
                    // llenando la nueva matriz y agregando la suma de las columnas 1 y 2
                    MatrizColumna3[Fila, 0] = Matriz[Fila, 0];
                    MatrizColumna3[Fila, 1] = Matriz[Fila, 1];
                    MatrizColumna3[Fila, 2] = Matriz[Fila, 0] + Matriz[Fila, 1];
                }
                // Imprimimos los resultados de la sumatoria
                Console.WriteLine("Valores de la matriz con sumatoria en columna 3");
                for (int Fila = 0; Fila < MatrizColumna3.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < MatrizColumna3.GetLength(1); Columna++)
                    {
                        // Imprimiendo valores por fila
                        Console.Write(MatrizColumna3[Fila, Columna] + "\t");
                    }
                    // Siguiente linea
                    Console.WriteLine();
                }
                // Sumamos la columnas 3 en variable Total
                for (int Fila = 0; Fila < MatrizColumna3.GetLength(0); Fila++)
                {
                    Total = Total + MatrizColumna3[Fila, 2];
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("El Total de suma de las columnas 1 y 2: " + Total);
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de sumar columnas 1 y 2 en columna 3: " + ex.Message);
            }
        }
        public void RedimensionarMatriz()
        {
            try
            {
                int Filas = 12;
                int Columnas = 4;
                MatrizRedimensionada = new int[Filas, Columnas];
                //Ingresamos los valores a la nueva matriz
                for (int Fila = 0; Fila < Matriz.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < Matriz.GetLength(1); Columna++)
                    {
                        MatrizRedimensionada[Fila, Columna] = MatrizColumna3[Fila, Columna];
                    }
                }
                Console.WriteLine("Matriz Redimensionada:");
                for (int Fila = 0; Fila < MatrizRedimensionada.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < MatrizRedimensionada.GetLength(1); Columna++)
                    {
                        // Imprimiendo valores por fila
                        Console.Write(MatrizRedimensionada[Fila, Columna] + "\t");
                    }
                    // Siguiente linea
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de redimencionar la matriz: " + ex.Message);
            }
        }
        public void TrasladoValores()
        {
            try
            {
                // Trasladar los valores de las[filas 1 y 2][columna 1] hacia las filas nuevas
                for (int Fila = 0; Fila < MatrizRedimensionada.GetLength(0); Fila++)
                {
                    if (Fila == 10)
                    {
                        MatrizRedimensionada[Fila, 0] = MatrizRedimensionada[0, 0];
                    }
                    if (Fila == 11)
                    {
                        MatrizRedimensionada[Fila, 0] = MatrizRedimensionada[1, 0];
                    }
                }
                Console.WriteLine("Matriz con datos actualizados (Trasladar los valores de las[filas 1 y 2][columna 1] hacia las filas nuevas) :");
                for (int Fila = 0; Fila < MatrizRedimensionada.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < MatrizRedimensionada.GetLength(1); Columna++)
                    {
                        // Imprimiendo valores por fila
                        Console.Write(MatrizRedimensionada[Fila, Columna] + "\t");
                    }
                    // Siguiente linea
                    Console.WriteLine();
                }
                // Sumamos [filas 1 y 2] [columna 2]
                for (int Fila = 0; Fila <= 1; Fila++)
                {
                    Globals.Total_Fila1_2_Columna2 = Globals.Total_Fila1_2_Columna2 + MatrizRedimensionada[Fila, 1];
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("El total de la sumar de ([filas 1 y 2] [columna 2]) es : " + Globals.Total_Fila1_2_Columna2);
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de trasladar los valores de las[filas 1 y 2][columna 1] hacia las filas nuevas: " + ex.Message);
            }
        }
        public void ActualizarValores()
        {
            try
            {
                //Borrar los valores de [filas 1 y 2] [columna 2]
                int Filas = MatrizRedimensionada.GetLength(0);
                int Columnas = MatrizRedimensionada.GetLength(1);
                MatrizActualizada = new double[Filas, Columnas];
                // Calculando valores a ingresar en columna 4
                Globals.ValoresFila3_7_Columna4 = Convert.ToDouble(Globals.Total_Fila1_2_Columna2) / 5;
                Console.WriteLine("Las partes iguales para columna 4 seran de (" + Convert.ToDouble(Globals.Total_Fila1_2_Columna2) + "/5): " + Globals.ValoresFila3_7_Columna4);
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Eliminando los valores de las [filas 1 y 2] [columna 2]");
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                for (int Fila = 0; Fila < Filas; Fila++)
                {
                    for (int Columna = 0; Columna < Columnas; Columna++)
                    {
                        // Eliminar los valores de la columna 2
                        if (Columna == 1 && Fila == 0 || Columna == 1 && Fila == 1)
                        {
                            MatrizActualizada[Fila, Columna] = 0;
                        }
                        // Agregar las partes iguales en la columna 4
                        else if (Columna == 3 && Fila == 2 || Columna == 3 && Fila == 3 || Columna == 3 && Fila == 4 || Columna == 3 && Fila == 5 || Columna == 3 && Fila == 6)
                        {
                            MatrizActualizada[Fila, Columna] = Globals.ValoresFila3_7_Columna4;
                        }
                        else
                        {
                            MatrizActualizada[Fila, Columna] = MatrizRedimensionada[Fila, Columna];
                        }
                    }
                }
                Console.WriteLine("Matriz Actual:");
                for (int Fila = 0; Fila < MatrizActualizada.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < MatrizActualizada.GetLength(1); Columna++)
                    {
                        // Imprimiendo valores por fila
                        Console.Write(MatrizActualizada[Fila, Columna] + "\t");
                    }
                    // Siguiente linea
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar valores en columna 4 y eliminando los valores de las [filas 1 y 2] [columna 2]: " + ex.Message);
            }
        }
        public void CalcularTotalValoresActualizados()
        {
            try
            {
                // Actualizando las sumatorias de columnas y calculando total de columna3
                int Filas = MatrizActualizada.GetLength(0);
                int Columnas = MatrizActualizada.GetLength(1);
                Double Total = 0.0;
                MatrizCalculosActualizada = new double[Filas, Columnas];
                //Ingresamos los valores a la nueva matriz
                for (int Fila = 0; Fila < Filas; Fila++)
                {
                    for (int Columna = 0; Columna < Columnas; Columna++)
                    {
                        // Actualizando las sumas de columnas
                        if (Columna == 2)
                        {
                            MatrizCalculosActualizada[Fila, Columna] = MatrizActualizada[Fila, 0] + MatrizActualizada[Fila, 1] + MatrizActualizada[Fila, 3];
                        }
                        else
                        {
                            MatrizCalculosActualizada[Fila, Columna] = MatrizActualizada[Fila, Columna];
                        }
                    }
                }
                Console.WriteLine("Matriz con valores finales:");
                for (int Fila = 0; Fila < MatrizCalculosActualizada.GetLength(0); Fila++)
                {
                    for (int Columna = 0; Columna < MatrizCalculosActualizada.GetLength(1); Columna++)
                    {
                        // Imprimiendo valores por fila
                        Console.Write(MatrizCalculosActualizada[Fila, Columna] + "\t");
                    }
                    // Siguiente linea
                    Console.WriteLine();
                }
                // Sumamos la columnas 3 en variable Total
                for (int Fila = 0; Fila < MatrizCalculosActualizada.GetLength(0); Fila++)
                {
                    Total = Total + MatrizCalculosActualizada[Fila, 2];
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("El Total en Columna 3 es: " + Total);
                Console.WriteLine("---------------------------------------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Alistar la matriz con los calculos finales: " + ex.Message);
            }
        }
    }
}
