using System;
using System.Collections.Generic;
using System.Text;

namespace HW3.Step
{
    public class ViewFactory
    {
        public ViewInfrastracture Create()
        {
            var model = new Model();
            var viewModel = new ViewModel(model);
            var view = new View();
            return new ViewInfrastracture(model, viewModel, view);
        }
    }
}
