using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLogic
{
    public class NoLetterException : Exception
    {
        public NoLetterException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
