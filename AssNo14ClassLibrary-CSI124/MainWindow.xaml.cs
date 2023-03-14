using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyLibrary;

namespace AssNo14ClassLibrary_CSI124
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> numbers = new List<int> { 1, 34, 76, 3, 43, 2, 5, 34, 56 };
        //Can a Class Library run on its own?
	    //The solution to this question is No.Because we could not run a.NET class library.
        //We should try creating a new project and adding a reference to that library.

        public MainWindow()
        {
            InitializeComponent();

            // MyMath mathObject = new MyMath();
            int diceRoll = "20".RollTheDie().ToString().RollTheDie();
            MessageBox.Show(MyMath.Average(numbers).ToString());

             Team seahawks = new Team("Seahawks");

             seahawks = null;
        }

        //When you build a Class Library, what file format does it turn into?
        //When we build a class library, a.dll file is created.
        //By referencing this DLL file in our other projects,
        //we will be able to use the classes and methods contained within.

        public void Example()
        {
          try
            {
                "a".RollTheDie().ToString();
            }
            catch (diceRollException dre)
            {
                MessageBox.Show(dre.Message, "What is this");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This was a regular exception " + ex.StackTrace);
            }
        }
    }
}
