

namespace FestivaliAS.Commands.Etiketa
{

    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;

    class removeEtiketaIzManifestacije : ICommand
    {

        private EtiketaViewModel _ViewModel;



        public removeEtiketaIzManifestacije(EtiketaViewModel viewModel)
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
            return _ViewModel.canObrisatiEtiketuIzManifestacije();
        }

        public void Execute(object parameter)
        {
            _ViewModel.RemoveEtiketaIzManifestacije();
        }
    }
}
