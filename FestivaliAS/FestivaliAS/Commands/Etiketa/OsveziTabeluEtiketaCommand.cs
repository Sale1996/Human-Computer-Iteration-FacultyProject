using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivaliAS.Commands.Etiketa
{

    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;

    class OsveziTabeluEtiketaCommand : ICommand
    {
        private EtiketaViewModel _ViewModel;



        public OsveziTabeluEtiketaCommand(EtiketaViewModel viewModel)
        {
            _ViewModel = viewModel;
        }



        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _ViewModel.OsveziTabeluEtiketa();
        }
    }
}
