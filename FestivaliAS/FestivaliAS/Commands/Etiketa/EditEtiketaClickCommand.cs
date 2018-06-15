

namespace FestivaliAS.Commands.Etiketa
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;

    class EditEtiketaClickCommand : ICommand
    {
        private EtiketaViewModel _ViewModel;



        public EditEtiketaClickCommand(EtiketaViewModel viewModel)
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
            return _ViewModel.canRemove();
        }

        public void Execute(object parameter)
        {
            _ViewModel.EditClickEtiketa(parameter);
        }
    }
}
