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
using System.Security;
using System.Runtime.InteropServices;

namespace CS317_project.Nav
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl, IntSwitchPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           int pass= int.Parse(passwordBox.SecurePassword.Length.ToString());

            if (txtBox_user.Text != "" && pass>0)// (txtBox_user.Text  && passwordBox. != "")
            {
                if ("user" == txtBox_user.Text && "pass" == passwordBox.Password)//(SecureStringToString(passwordBox.SecurePassword)))
                {
                    MessageBox.Show("Welcome Teacher, Click OK ");                  
                    Switcher.Switch(new Nav.Teacher_cntrl());
                }
                else if ("user1" == txtBox_user.Text && "pass" == passwordBox.Password)//(passwordBox.SecurePassword)))
                {
                    MessageBox.Show("Welcome Student, Click OK");
                    Switcher.Switch(new Student.student_testview());
                }
                else
                {
                    MessageBox.Show("Invalid User or passwor");
                }
            }
            else
            {
                MessageBox.Show("User and password is Required");
            }
        }
        //private String SecureStringToString(SecureString value)
        //{
        //    IntPtr bstr = Marshal.SecureStringToBSTR(value);

        //    try
        //    {
        //        return Marshal.PtrToStringBSTR(bstr);
        //    }
        //    finally
        //    {
        //        Marshal.FreeBSTR(bstr);
        //    }
        //}
        public void UtState(object state)
        {
            throw new NotImplementedException();
        }

        private void bttnbypasstech_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Nav.Teacher_cntrl());
        }
    }
}
