using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding
{
    public class Numbers
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Decode()
        {
            if (number >= 'A' && number <= 'Z' || number >= 'a' && number <= 'z')
            {
                return "Это буква " + $"{(char)number}";
            }
            else
            {
                return "Это не буква, а символ " + $"{(char)number}";
            }
        }
    }
}
