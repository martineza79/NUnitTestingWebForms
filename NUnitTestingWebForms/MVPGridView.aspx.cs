using NUnitTestingWebForms.Presenter;
using NUnitTestingWebForms.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NUnitTestingWebForms
{
    public partial class MVPGridView : System.Web.UI.Page, IDisplayDataView
    {
        private DisplayDataPresenter Presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            Presenter = new DisplayDataPresenter(this);
        }

        public List<string> Data
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler DataRequested;

        public void Bind()
        {
            ListBox1.DataSource = Data;
            ListBox1.DataBind();
        }        
    }
}