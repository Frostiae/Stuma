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
using Stuma.Control;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stuma.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        Student currentUser = Database.currentUser;
        public HomeView()
        {
            InitializeComponent();
            taskListBox.ItemsSource = currentUser.tasks;
            /*
            foreach (Task task in currentUser.tasks)
            {
                taskListBox.Items.Add(task.title);
            }*/
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            Task t = new Task(TaskType.Regular, currentUser.tasks.Count.ToString(), "This is a task description", new DateTime(2020, 03, 30));
            currentUser.AddTask(t);
            UpdateTaskView();
        }

        private void UpdateTaskView()
        {
            taskListBox.Items.Refresh();
        }
    }
}
