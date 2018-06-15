
namespace FestivaliAS.Commands
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class RefreshEditCommand : ICommand
    {
        private ManifestacijaViewModel _ViewModel;



        public RefreshEditCommand(ManifestacijaViewModel viewModel)
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
            return _ViewModel.canRefresh();
        }

        public void Execute(object parameter)
        {
            _ViewModel.RefreshEditManifestacija();
        }
    }
}