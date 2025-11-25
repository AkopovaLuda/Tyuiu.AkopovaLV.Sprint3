using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkopovaLV.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int x = startValue; x <= stopValue;x++)
            {
                for (int i = 12; i <= x; i++)
                {
                    if (x% i == 0)
                    {
                        sum = sum + i;
                    }
                }
            }
            return sum;
        }
    }
}
