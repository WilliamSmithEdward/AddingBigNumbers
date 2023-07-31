//https://www.codewars.com/kata/525f4206b73515bffb000b21/train/csharp

namespace AddingBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("999999999", "1"));
        }

        public static string Add(string a, string b)
        {
            string string1;
            string string2;

            if (a.Length >= b.Length)
            {
                string1 = string.Join("", a.Reverse());
                string2 = string.Join("", b.Reverse());
            }
            else
            {
                string1 = string.Join("", b.Reverse());
                string2 = string.Join("", a.Reverse());
            }

            string newValueAsString = "";
            int carryover = 0;

            int index = 0;

            foreach (char c in string1)
            {
                int tempValue = 0;

                if (index < string2.Length) tempValue = int.Parse(c.ToString()) + int.Parse(string2[index].ToString()) + carryover;
                else tempValue = int.Parse(c.ToString()) + carryover;

                if (tempValue > 9)
                {
                    carryover = 1;
                    tempValue -= 10;
                }
                else
                {
                    carryover = 0;
                }

                newValueAsString = tempValue.ToString() + newValueAsString;

                if (index >= string1.Length - 1 && carryover > 0)
                {
                    newValueAsString = "1" + newValueAsString;
                }

                index++;
            }

            return newValueAsString;
        }
    }
}