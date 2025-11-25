using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkopovaLV.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue <= stopValue)
            {
                sum = sum + 1 /(Math.Pow( startValue, 2));
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
