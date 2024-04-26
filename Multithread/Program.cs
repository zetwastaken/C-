
using System;
using System.Diagnostics;
using System.Threading;
class ArrayMultiplier
{

    static volatile int[,] arrayZ;
    public static void MultiplyArrays(int[,] array1, int[,] array2, int[] rowsToMultiply, int[] columnsToMultiply, int arraySize)
    {
        if (array1.GetLength(1) != array2.GetLength(0))
        {
            throw new ArgumentException("Number of columns in the first array must be equal to the number of rows in the second array.");
        }

        arrayZ = new int[arraySize, arraySize];

        for (int i = 0; i < rowsToMultiply.Length; i++)
        {
            for (int j = 0; j < columnsToMultiply.Length; j++)
            {
                int sum = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    sum += array1[rowsToMultiply[i], k] * array2[k, columnsToMultiply[j]];
                }
                arrayZ[i, j] = sum;
            }
        }
    }
    public static void printArrayZ()
    {

        for (int i = 0; i < arrayZ.GetLength(0); i++)
        {
            for (int j = 0; j < arrayZ.GetLength(1); j++)
            {
                Console.Write(arrayZ[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
internal class Program
{

    
    static void Main(string[] args)
    {
        int threadsNumber = Environment.ProcessorCount;
        int arraySize = 1000;

        Random rnd = new Random();
        int[,] arrayX = new int[arraySize,arraySize];
        int[,] arrayY = new int[arraySize,arraySize];
        int[,] arrayZ = new int[arraySize,arraySize];
        
        for (int i = 0; i < arraySize; i++)
        {
            for (int j = 0; j < arraySize; j++)
            {
                arrayX[i, j] = rnd.Next(1, 2);
                arrayY[i, j] = rnd.Next(1, 2);
            }
        }
        //Environment.ProcessorCount
        // Console.WriteLine("Array X");
        // for (int i = 0; i < arraySize; i++)
        // {
        //     for (int j = 0; j < arraySize; j++)
        //     {
        //         Console.Write(arrayX[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine("Array Y");
        // for (int i = 0; i < arraySize; i++)
        // {
        //     for (int j = 0; j < arraySize; j++)
        //     {
        //         Console.Write(arrayY[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }


        Thread thread;
        int chunkSize = (int)Math.Ceiling((double)arraySize / Environment.ProcessorCount );


        Stopwatch stopWatch = new Stopwatch();
        Stopwatch stopWatch2 = new Stopwatch();
        stopWatch.Start();

        var tupleList = new List<(int, int)>{

        };
        for (int i = 0; i < arraySize; i += chunkSize)
        {
            Console.WriteLine("Kawałek {0}:", (i / chunkSize) + 1);
            for (int j = i; j < Math.Min(i + chunkSize, arraySize); j++)
            {
                tupleList.Add((i, j));
                //thread = new Thread(() => ArrayMultiplier.MultiplyArrays(arrayX, arrayY, [i,j], [i,j]));
                //thread.Start();
            }
        }
        Thread[] threads = new Thread[tupleList.Count];
        for (int i=0; i<tupleList.Count; i++)
        {
            int[] arr = new int[]{tupleList[i].Item1, tupleList[i].Item2};
            threads[i] = new Thread(() => ArrayMultiplier.MultiplyArrays(arrayX, arrayY, arr, arr, arraySize));
            threads[i].Start();
        }
        foreach (Thread t in threads)
        {
            t.Join();
        }
        stopWatch.Stop();

        //ArrayMultiplier.printArrayZ();

        stopWatch2.Start();
        rowsByColumns(arrayX, arrayY, arrayZ, arraySize, 0, arraySize);
        stopWatch2.Stop();
        
        TimeSpan ts = stopWatch.Elapsed;
        TimeSpan ts2 = stopWatch.Elapsed;
        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            
        Console.WriteLine("RunTime" + elapsedTime);
        string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            ts2.Hours, ts2.Minutes, ts2.Seconds,
            ts2.Milliseconds);
        Console.WriteLine("RunTime 2 " + elapsedTime2);
    }
    static void rowsByColumns(int[,] arrayX, int[,] arrayY, int[,] arrayZ, int arraySize, int start, int end)
    {
        for (int i = start; i < arraySize; i++)
        {
            for (int j = start; j < arraySize; j++)
            {
                arrayZ[i, j] = 0;
                for (int k = 0; k < arraySize; k++)
                {
                    arrayZ[i, j] += arrayX[i, k] * arrayY[k, j];
                }
            }
        }
    }
}

