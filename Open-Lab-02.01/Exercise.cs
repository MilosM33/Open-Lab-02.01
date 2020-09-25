using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            Random r = new Random();
            double[] num = new double[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = r.NextDouble();
            }

            return num;
        }

        public double GetSecond(double[] numbers) => numbers[1];
        
    }
}