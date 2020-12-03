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

namespace njackson_3A
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
            //1) Initialize control variable
            //2) Type of loop and condition test
            //3) calculation of loop
            //4) Need to change value of control variable
            //5) Show beginning and end of loop
        {
            Result0.Text = Ex3aLoops.Calc0(Input0A.Text, Input0B.Text, Input0C.Text);
            Result1.Text = Ex3aLoops.Calc1(Input1A.Text, Input1B.Text, Input1C.Text);
            Result2.Text = Ex3aLoops.Calc2(Input2A.Text, Input2B.Text, Input2C.Text);
            Result3.Text = Ex3aLoops.Calc3(Input3A.Text, Input3B.Text, Input3C.Text);
            Result4.Text = Ex3aLoops.Calc4(Input4A.Text, Input4B.Text, Input4C.Text);
            Result5.Text = Ex3aLoops.Calc5(Input5A.Text, Input5B.Text, Input5C.Text);
            Result6.Text = Ex3aLoops.Calc6(Input6A.Text, Input6B.Text);
            Result7.Text = Ex3aLoops.Calc7(Input7A.Text, Input7B.Text);
            Result8.Text = Ex3aLoops.Calc8(Input8A.Text, Input8B.Text);
        }
    }
}
