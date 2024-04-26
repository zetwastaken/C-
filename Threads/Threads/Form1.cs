using System.Collections.Concurrent;
using System.Diagnostics;



namespace Threads
{
    public partial class Form1 : Form
    {
        private static readonly object locking = new object(); // Lock object for thread safety
        private volatile static int[,] result; // Result matrix
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void MultiplyArraysNormal(int[,] array1, int[,] array2, ref int[,] result, out TimeSpan elapsedTime)
        {
            var watch = Stopwatch.StartNew();

            result = MultiplyMatrix(array1, array2);

            elapsedTime = watch.Elapsed;
        }

        private void MultiplyArraysThreaded(int[,] array1, int[,] array2, int numCores, ref int[,] result, out TimeSpan elapsedTime)
        {
            var watch = Stopwatch.StartNew();

            result = ThreadMultiply(array1, array2, numCores);

            elapsedTime = watch.Elapsed;
        }

        private void MultiplyArraysParallel(int[,] array1, int[,] array2, int numCores, ref int[,] result, out TimeSpan elapsedTime)
        {
            var watch = Stopwatch.StartNew();

            result = ParallelMultiply(array1, array2, numCores);

            elapsedTime = watch.Elapsed;
        }

        private int[,] MultiplyMatrix(int[,] matrix, int[,] mb)
        {
            int size = matrix.GetLength(0);
            int[,] result = new int[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    int temp = 0;
                    for (int t = 0; t < size; t++)
                    {
                        temp += matrix[x, t] * mb[t, y];
                    }
                    result[x, y] = temp;
                }
            }

            return result;
        }

        private int[,] ThreadMultiply(int[,] matrix, int[,] mb, int numCores)
        {
            int size = matrix.GetLength(0);
            int[,] result = new int[size, size];

            int s = size / numCores;
            Thread[] threads = new Thread[numCores];
            for (int x = 0; x < numCores; x++)
            {
                int start = x * s;
                int end = (x + 1) * s;
                threads[x] = new Thread(() =>
                {
                    for (int x = start; x < end; x++)
                    {
                        for (int y = 0; y < size; y++)
                        {
                            int temp = 0;
                            for (int t = 0; t < size; t++)
                            {
                                temp += matrix[x, t] * mb[t, y];
                            }
                            lock (locking)
                            {
                                result[x, y] = temp;
                            }
                        }
                    }
                });
            }

            foreach (Thread thread in threads) thread.Start();
            foreach (Thread thread in threads) thread.Join();

            return result;
        }

        private int[,] ParallelMultiply(int[,] matrix, int[,] mb, int numCores)
        {
            int size = matrix.GetLength(0);
            int[,] result = new int[size, size];

            int s = size / numCores;
            Parallel.For(0, numCores, i =>
            {
                for (int x = i * s; x < (i + 1) * s; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        int temp = 0;
                        for (int z = 0; z < size; z++)
                        {
                            temp += matrix[x, z] * mb[z, y];
                        }
                        lock (locking)
                        {
                            result[x, y] = temp;
                        }
                    }
                }
            });

            return result;
        }

        private void DisplayResult(string methodName, int[,] result, TimeSpan elapsedTime)
        {
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);
            string resultStr = $"Result for {methodName}:";
/*            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultStr += result[i, j] + " ";
                }
                resultStr += "\n";
            }*/
            resultTextBox.AppendText(resultStr + $"Time taken: {elapsedTime.TotalMilliseconds} ms\n");
        }

        private int[,] GenerateRandomArray(int rows, int cols)
        {
            Random random = new Random();
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 101); // Generate random numbers between 1 and 100
                }
            }
            return array;
        }

        private void multiplyButton_Click_1(object sender, EventArgs e)
        {
            resultTextBox.AppendText("Result number: " + counter.ToString() +"\n");
            int rows = (int)sizeNumericUpDown.Value;
            int cols = (int)sizeNumericUpDown.Value;

            int[,] array1 = GenerateRandomArray(rows, cols);
            int[,] array2 = GenerateRandomArray(rows, cols);

            int numCores = (int)coresNumericUpDown.Value;

            try
            {
                TimeSpan elapsedTime;

                MultiplyArraysNormal(array1, array2, ref result, out elapsedTime);
                DisplayResult("Normal", result, elapsedTime);

                MultiplyArraysThreaded(array1, array2, numCores, ref result, out elapsedTime);
                DisplayResult("Threaded", result, elapsedTime);

                MultiplyArraysParallel(array1, array2, numCores, ref result, out elapsedTime);
                DisplayResult("Parallel", result, elapsedTime);
                resultTextBox.AppendText("----------\n");
                counter++;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}