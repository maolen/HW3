using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    public class ViewFactory
    {
		public ViewInfrastracture Create()
		{
			var eraseDelegateCommand = new EraseDelegateCommand();
			var saveDelegateCommand = new SaveDelegateCommand();
			var model = new Model();
			var viewModel = new ViewModel(model, saveDelegateCommand.Command, eraseDelegateCommand.Command);
			var view = new View();
			eraseDelegateCommand.ViewModel = viewModel;
			saveDelegateCommand.ViewModel = viewModel;

			return new ViewInfrastracture(view, viewModel, model);
		}
	}
}
