using System;
using System.Collections.Generic;
using System.Linq;
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

namespace QuestionMarks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Person newStaffMember = new Person();
            newStaffMember.IdentityNumber = null;

            //null coalescing
            newStaffMember.FirstName = "Juan";
            txtFirst.Text = newStaffMember.FirstName ?? "John";

            /*replaces syntax like:
            if (newStaffMember.IdentityNumber == null)
            {
	            MessageBox.Show("Id number is null");
            }
            */

            //newStaffMember.LastName = "Smith";
            txtLast.Text = newStaffMember.LastName.IsNull() ? Person.GetDoe() : newStaffMember.LastName;

            MessageBox.Show(5 > 10 ? "Yes" : "No");
        }
    }

    public static class CheckNull
    {
        public static bool IsNull(this string stringToCheck)
        {
            if (stringToCheck == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Person
    {       
        public static string GetDoe()
        {
            return "Doe";
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Nullable type, must be used on non-nullable types
        public int? IdentityNumber { get; set; }
    }
}
