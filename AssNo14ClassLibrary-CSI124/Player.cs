using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Support;

namespace AssNo14ClassLibrary_CSI124
{
    public class Player
    {
        string _name;
        string _number;
        static int count;

        public Player(string name, string number)
        {
            Name = name;
            Number = number;
            count++;
        }

        public string Name
        {
            get => _name;

            set
            {

                if (!value.Equals(string.Empty) || value.Length <= 2)
                {
                    _name = value;
                }
                else
                {
                    //throw new PlayerException("Enter a valid name ( between 3 and 16 characters )");
                }

            }
        }
        public string Number
        {

            get => _number;
            set
            {

                bool length = value.Length >= 1 && value.Length <= 3;
                int tempValue = 0;

                bool isANumber = int.TryParse(value, out tempValue);

                if (length && isANumber)
                {
                    _number = value;
                }
                else
                {
                    //throw new PlayerException("Enter a valid number between 1 and 999");
                }

            } // set
        } // Number

        public override string ToString()
        {
            return $"{Name} - {Number}";
        }

        // Deconstructor
        //~Player()
        //{
        //    MessageBox.Show($"Object containing {ToString()} was just disposed of.");
        //}
    }
}

