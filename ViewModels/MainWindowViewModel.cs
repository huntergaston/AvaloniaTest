using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;

namespace AvaloniaTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _number;

        public int Number
        {
            get => _number;
            set => this.RaiseAndSetIfChanged(ref _number, value);
        }
    

        public MainWindowViewModel()
        {
        
            Increment = ReactiveCommand.Create(IncrementNumber);

        }
        public ReactiveCommand<Unit, Unit> Increment { get; }

        void IncrementNumber()
        {
            Number += 1;


        }
    }
}
