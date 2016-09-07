using System;
using System.Windows.Controls;
using CS317_project.Student;

namespace CS317_project
{
    public static class Switcher
    {
        public static PageNav pageSwitcher;

        public static void Switch(UserControl newPage)
        {
            pageSwitcher.Navigate(newPage);
        }

        public static void Switch(UserControl newPage, object state)
        {
            pageSwitcher.Navigate(newPage, state);
        }

        
    }
}
