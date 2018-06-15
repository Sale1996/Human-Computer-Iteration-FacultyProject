namespace FestivaliAS.Commands
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class EditManifestacijaCommand : ICommand
    {
        private ManifestacijaViewModel _ViewModel;



        public EditManifestacijaCommand(ManifestacijaViewModel viewModel)
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
            _ViewModel.EditManifestacija(parameter);
        }
    }
}
