using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace HW3
{
    public class ViewModel : INotifyPropertyChanged
    {
        private readonly Model model;

        public string Name
        {
            get
            {
                return model.Name;
            }
            set
            {
                if (model.Name != value)
                {
                    model.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Address
        {
            get
            {
                return model.Address;
            }
            set
            {
                if (model.Address != value)
                {
                    model.Address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        public string Email
        {
            get
            {
                return model.Email;
            }
            set
            {
                if (model.Email != value)
                {
                    model.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return model.PhoneNumber;
            }
            set
            {
                if (model.PhoneNumber != value)
                {
                    model.PhoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }


        public bool IsMale
        {
            get
            {
                return model.IsMale;
            }
            set
            {
                if (model.IsMale != value)
                {
                    model.IsMale = value;
                    OnPropertyChanged("IsMale");
                }
            }
        }

        public int BirthDay
        {
            get
            {
                return model.BirthDate.Day;
            }
            set
            {
                if (model.BirthDate.Day != value)
                {
                    model.BirthDate = new DateTime(model.BirthDate.Year, model.BirthDate.Month, value);
                    OnPropertyChanged("BirthDay");
                }
            }
        }

        public int BirthMonth
        {
            get
            {
                return model.BirthDate.Month;
            }
            set
            {
                if (model.BirthDate.Month != value)
                {
                    model.BirthDate = new DateTime(model.BirthDate.Year, value, model.BirthDate.Day);
                    OnPropertyChanged("BirthMonth");
                }
            }
        }

        public int BirthYear
        {
            get
            {
                return model.BirthDate.Year;
            }
            set
            {
                if (model.BirthDate.Year != value)
                {
                    model.BirthDate = new DateTime(value, model.BirthDate.Month, model.BirthDate.Day);
                    OnPropertyChanged("BirthYear");
                }
            }
        }

        public ICommand SaveCommand { get; private set; }

        public ICommand EraseCommand { get; private set; }

        public ViewModel(Model model, ICommand saveCommand, ICommand eraseCommand)
        {
            this.model = model;
            SaveCommand = saveCommand;
            EraseCommand = eraseCommand;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
