
namespace FestivaliAS.Commands
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class UbaciTipCommand : ICommand
    {
        private ManifestacijaViewModel _ViewModel;



        public UbaciTipCommand(ManifestacijaViewModel viewModel)
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
            _ViewModel.UbaciTip();
        }
    }
}