using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    public class ViewInfrastracture
    {
		public View View { get; private set; }

		public ViewModel ViewModel { get; private set; }

		public Model Model { get; private set; }

		public ViewInfrastracture(View view, ViewModel viewModel, Model model)
		{
			this.View = view;
			this.ViewModel = viewModel;
			this.Model = model;
		}
	}
}
