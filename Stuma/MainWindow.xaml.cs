using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Stuma.ViewModels;
using Stuma.Views;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;

namespace Stuma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "q5RDnge7vWIoAtuDJa1avsgkTjAt1FHbEcitVhQM",
            BasePath = "https://student-manager-21372-default-rtdb.firebaseio.com/"
        };

        FirebaseClient client;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            client = new FirebaseClient(config);
        }

        private async void BTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Setting data
                //await client.SetAsync("Test123/data1", TXT.Text);
                // Pushing data; Good for no replacement since it creates a random shell ID
                //await client.PushAsync("Test123/PushData", TXT.Text);

                // Getting data from the database
                //FirebaseResponse response = await client.GetAsync("Test123/data1");
                //string st = response.ResultAs<string>();

                // Setting data as an object
                //Student student = new Student
                //{
                //    Age = 20,
                //    Faculty = "Toronto",
                //    Department = "Computer Science"
                //};
                //await client.PushAsync("USERS", student);

                // TODO: Login, and if the account is not in the database already, create it.
                MessageBox.Show("Done");
            }
            catch
            {

            }
        }
    }
}
