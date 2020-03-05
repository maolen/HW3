using System;
using System.Collections.Generic;
using System.Text;

namespace HW3.Step
{
    public class ViewInfrastracture
    {
        public View View { get; set; }
        public ViewModel ViewModel { get; set; }
        public Model Model { get; set; }
        public ViewInfrastracture(Model model, ViewModel viewModel, View view)
        {
            View = view;
            ViewModel = viewModel;
            Model = model;
        }
    }
}
