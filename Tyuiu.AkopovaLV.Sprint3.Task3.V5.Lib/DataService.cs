using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AkopovaLV.Sprint3.Task3.V5.Lib
{
    public class DataService : ISprint3Task3V5
    {
        public string ReplaceCharInString(string value, char replaceable, char replacement)
        {
            foreach (char i in value)
            {
                if (i == replaceable) 
                {
                    value = value.Replace(i, replacement);
                }
            }
            return value;
        }
    }
}
