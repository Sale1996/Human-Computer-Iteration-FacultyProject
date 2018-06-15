namespace FestivaliAS.Commands.Tip
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class UbaciPostojeciTipCommand : ICommand
    {
        private TipViewModel _ViewModel;



        public UbaciPostojeciTipCommand(TipViewModel viewModel)
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
            return _ViewModel.canRemove() ;
        }

        public void Execute(object parameter)
        {
            _ViewModel.UbaciPostojeciTip();
        }
    }
}