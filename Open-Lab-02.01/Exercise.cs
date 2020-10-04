using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] cisla = new double[5];
            Random nahodne = new Random();
            for (int i = 0; i < 5; i++)
            {
                cisla[i] = nahodne.NextDouble();
            }
            return cisla;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}