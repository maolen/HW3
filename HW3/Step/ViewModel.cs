using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HW3.Step
{
    public class ViewModel : INotifyPropertyChanged
    {
        private readonly Model _model;
        public string Name 
        {
            get
            {
                return _model.Name;
            }
            set
            {
                if(_model.Name != value)
                {
                    _model.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public ViewModel(Model model)
        {
            _model = model;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
