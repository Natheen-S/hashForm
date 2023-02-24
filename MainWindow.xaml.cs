using System;
using System.Collections;
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

namespace hashForm
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.RightButton==MouseButtonState.Pressed)
            {
                Close();
            }
        }

        private void btn_main_Click(object sender, RoutedEventArgs e)
        {
            string content="";

            Hashtable hash = new Hashtable();
            hash.Add("Student Name", txtbox_name.Text.ToString());
            hash.Add("College Name", txtbox_clg.Text.ToString());
            hash.Add("Mark1", txtbox_mark1.Text.ToString());
            hash.Add("Mark2", txtbox_mark2.Text.ToString());
            hash.Add("Total", txtbox_total.Text.ToString());
            //string sname= "";
            //foreach (var item in hash.Keys)
            //{
            //    sname += item +":"+ "\n";
            //}
            //foreach(var item in hash.Values)
            //{
            //    content+= item.ToString() + "\n";
            //}
            foreach (DictionaryEntry item in hash)
            {

                content += $"\n{item.Key.ToString()}"+":"+$"{ item.Value.ToString()}";
            }
            MessageBox.Show(content);
        }

        private void txtbox_mark2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int m1=Convert.ToInt32(txtbox_mark1.Text);
            int m2=Convert.ToInt32(txtbox_mark2.Text);
            int total = m1 + m2;
            txtbox_total.Text = total.ToString();
        }
    }
}
