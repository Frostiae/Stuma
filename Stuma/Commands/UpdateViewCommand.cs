using System;
using Stuma.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Stuma.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // TODO: Use enums and possibly a switch statement here.
            if (parameter.ToString() == "Home")
            {
                viewModel.selectedViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "Login")
            {
                viewModel.selectedViewModel = new LoginViewModel();
            }
        }
    }
}
