

namespace FestivaliAS.Commands.Etiketa
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;

    class AddEtiketaCommand : ICommand
    {
        private EtiketaViewModel _ViewModel;



        public AddEtiketaCommand(EtiketaViewModel viewModel)
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
            return _ViewModel.CanAdd;
        }

        public void Execute(object parameter)
        {
            _ViewModel.AddEtiketa(parameter);
        }
    }

}

