﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmUA2.Commands
{
    public class MyICommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _Excute { get; set; }
        private Predicate<object> _CanExcute { get; set; }


        public MyICommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {

            _Excute = ExcuteMethod;
            _CanExcute = CanExcuteMethod;

        }

        public bool CanExecute(object? parameter)
        {
            return _CanExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Excute(parameter);
        }
    }
}