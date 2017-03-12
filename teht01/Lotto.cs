using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Lotto
    {
        private Random rand = new Random();
        private int Number;
        private List<int> Numbers = new List<int>();
        private List<string> NumbersString = new List<string>();
        private List<string> Rows = new List<string>();

        public string GetRows(int NumberOfRows)
        {
            for (int i = 0; i < NumberOfRows; i++)
            {
                while (Numbers.Count < 7)
                {
                    Number = rand.Next(1, 39 + 1);
                    if (!Numbers.Contains(Number))
                    {
                        Numbers.Add(Number);
                    }

                }
                for (int j = 0; j < 7; j++)
                {
                    if (Numbers[j] < 10)
                    {
                        NumbersString.Add("0" + Numbers[j].ToString());
                    }
                    else
                    {
                        NumbersString.Add(Numbers[j].ToString());
                    }
                }
                NumbersString.Sort();
                Rows.Add(string.Join(" ", NumbersString));
                Numbers.Clear();
                NumbersString.Clear();
            }
            return string.Join(Environment.NewLine, Rows);
        }
    }
}
