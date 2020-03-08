using System;
using System.Windows.Input;

namespace HW3
{
    public class DelegateCommand : ICommand
    {
		private readonly Action<object> execute;
		private readonly Predicate<object> canExecute;
		public event EventHandler CanExecuteChanged;

		public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
		{
			if (execute == null)
				throw new ArgumentNullException("execute");
			if (canExecute == null)
				throw new ArgumentNullException("execute");

			this.execute = execute;
			this.canExecute = canExecute;
		}

		public DelegateCommand(Action<object> execute)
		{
			if (execute == null)
				throw new ArgumentNullException("execute");

			this.execute = execute;
		}

		public bool CanExecute(object parameter)
		{
			if (canExecute == null)
			{
				return true;
			}
			else
			{
				return canExecute(parameter);
			}
		}

		public void Execute(object parameter)
		{
			execute(parameter);
		}

		public void RaiseCanExecuteChanged()
		{
			DelegateCommand delegateCommand = this;
			delegateCommand.OnCanExecuteChanged();
		}

		protected virtual void OnCanExecuteChanged()
		{
			EventHandler handler = CanExecuteChanged;
			if (handler != null)
			{
				handler.Invoke(this, EventArgs.Empty);
			}
		}

	}
}