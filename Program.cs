using System;

class MainClass
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        string[] populationInput = Console.ReadLine().Split(' ');
        int[] population = new int[N];
        for (int i = 0; i < N; i++)
        {
            population[i] = int.Parse(populationInput[i]);
        }

        int maxCustomers = GetMaxCustomers(population, N, K);
        Console.WriteLine(maxCustomers);
    }

    static int GetMaxCustomers(int[] population, int N, int K)
    {
        int maxCustomers = 0;

        // Loop through all possible store locations
        for (int i = 0; i < N; i++)
        {
            int sum = 0;

            // Count the customers within the range of the store location
            for (int j = Math.Max(0, i - K); j <= Math.Min(N - 1, i + K); j++)
            {
                sum += population[j];
            }

            // Update the maximum number of customers
            if (sum > maxCustomers)
            {
                maxCustomers = sum;
            }
        }

        return maxCustomers;
    }
}
