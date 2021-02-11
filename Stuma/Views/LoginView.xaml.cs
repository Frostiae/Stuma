using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Stuma.Control;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FireSharp.Config;
using FireSharp;

namespace Stuma.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }

        MainWindow mainWindow { get => Application.Current.MainWindow as MainWindow; }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student("Frost"); // Temporary user for testing
            Database.currentUser = s;

            bool userExists = await Database.DataExists("Users/" + s.username);
            if (!userExists)
                Database.SetData(s);

            mainWindow.mainFrame.Navigate(new Uri("/Views/HomeView.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
