﻿

namespace FestivaliAS.Commands.Etiketa
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;

    class KreirajNovuEtiketuUTabeliCommand : ICommand
    {
        private EtiketaViewModel _ViewModel;



        public KreirajNovuEtiketuUTabeliCommand(EtiketaViewModel viewModel)
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
            _ViewModel.kreirajNovuEtiketu();
        }
    }

}