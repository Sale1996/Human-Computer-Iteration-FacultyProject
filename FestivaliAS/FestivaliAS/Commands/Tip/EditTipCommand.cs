namespace FestivaliAS.Commands.Tip
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class EditTipCommand : ICommand
    {
        private TipViewModel _ViewModel;



        public EditTipCommand(TipViewModel viewModel)
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
            return _ViewModel.CanEdit;
        }

        public void Execute(object parameter)
        {
            _ViewModel.EditTip(parameter);
        }
    }
}

