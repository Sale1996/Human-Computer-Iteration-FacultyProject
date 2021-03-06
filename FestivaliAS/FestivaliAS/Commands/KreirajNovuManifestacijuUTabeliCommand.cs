﻿
namespace FestivaliAS.Commands
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class KreirajNovuManifestacijuUTabeliCommand : ICommand
    {
        private ManifestacijaViewModel _ViewModel;



        public KreirajNovuManifestacijuUTabeliCommand(ManifestacijaViewModel viewModel)
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
            _ViewModel.KreirajNovuManifestacijuUTabeli();
        }
    }
}
