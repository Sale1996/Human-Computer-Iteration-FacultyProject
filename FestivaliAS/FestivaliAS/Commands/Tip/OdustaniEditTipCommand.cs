﻿namespace FestivaliAS.Commands.Tip
{
    using System;
    using System.Windows.Input;
    using FestivaliAS.ViewModels;
    class OdustaniEditTipCommand : ICommand
    {
        private TipViewModel _ViewModel;



        public OdustaniEditTipCommand(TipViewModel viewModel)
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
            _ViewModel.OdustaniEditTipa();
        }
    }
}