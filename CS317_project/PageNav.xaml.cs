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
using System.Windows.Shapes;

namespace CS317_project
{
    /// <summary>
    /// Interaction logic for PageNav.xaml
    /// </summary>
    public partial class PageNav : Window
    {
        public PageNav()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Nav.Login());
        }
        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(UserControl nextPage, object state)
        {
            this.Content = nextPage;
            IntSwitchPage s = nextPage as IntSwitchPage;

            if (s != null)
                s.UtState(state);
            else
                throw new ArgumentException("NextPage is not ISwitchable! "
                  + nextPage.Name.ToString());
        }
    }
}
