using NUnitTestingWebForms.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NUnitTestingWebForms.Presenter
{
    public class DisplayDataPresenter
    {
        public IDisplayDataView View { get; set; }

        public DisplayDataPresenter(IDisplayDataView view)
        {
            View = view;
            View.DataRequested += GetData; // Binds View to the Web Form's EventHandler
        }

        public void GetData(object sender, EventArgs e)
        {
            View.Data = new List<string> { "StringA", "StringB", "StringC", "StringD" };
            View.Bind();
        }
    }
}