using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MyMath
    {
        //What file do you right-click on in the solution explorer to add your Class Library to a project?
        //To get Solution Explorer, we should have to right-click the solution node and
        //choose Add > New Project.In the Add a new project window, type class library in the Search box.
        //Choose the C# Class library project template, and then select Next.

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Average(this List<int> list)
        {
            double sum = 0;

            foreach (int item in list)
            {
                sum += item;
            }

            return sum / list.Count;
        }

    }
}