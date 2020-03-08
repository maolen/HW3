using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace HW3
{
    public class SaveDelegateCommand
    {
		private ViewModel viewModel;

		public DelegateCommand Command { get; private set; }

		public ViewModel ViewModel
		{
			get
			{
				return viewModel;
			}
			set
			{
				if (viewModel != value)
				{
					if (viewModel != null)
					{
						viewModel.PropertyChanged -= OnViewModelPropertyChanged;
					}
					viewModel = value;
					viewModel.PropertyChanged += OnViewModelPropertyChanged;
				}
			}
		}

		public SaveDelegateCommand()
		{
			this.Command = new DelegateCommand(this.ExecuteSave, this.CanSave);
		}

		public void ExecuteSave(object unused)
		{
			MessageBox.Show("Save done");
		}

		public bool CanSave(object unused)
		{
			return ViewModel.BirthYear != 1 &&
				!string.IsNullOrEmpty(ViewModel.Address) &&
				!string.IsNullOrEmpty(ViewModel.Name) &&
				!string.IsNullOrEmpty(ViewModel.PhoneNumber) &&
				!string.IsNullOrEmpty(ViewModel.Email);
		}

		private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			Command.RaiseCanExecuteChanged();
		}
	}
}
