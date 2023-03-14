using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class DiceRollException : Exception
    {
        // Few constructors you might want to build
        public DiceRollException() { }

        public DiceRollException(string message) : base(message) { }

        public DiceRollException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
