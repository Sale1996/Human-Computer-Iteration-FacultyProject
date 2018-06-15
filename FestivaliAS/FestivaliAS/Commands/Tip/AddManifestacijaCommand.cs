
namespace FestivaliAS.Commands.Tip
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class AddTipCommand : ICommand
    {
        private TipViewModel _ViewModel;



        public AddTipCommand(TipViewModel viewModel)
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
            _ViewModel.AddTip(parameter);
        }
    }
}