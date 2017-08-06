using NUnit.Framework;
using NUnitTestingWebForms.Presenter;
using NUnitTestingWebForms.View;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace NUNitTestingWebForms.Test
{
    [TestFixture]
    public class DisplayDataPresenterTests
    {
        [Test]
        public void Ctor_should_hook_up_events()
        {
            IDisplayDataView view = MockRepository.GenerateMock<IDisplayDataView>();
            view.Expect(v => v.DataRequested += null).IgnoreArguments();

            new DisplayDataPresenter(view);
            view.VerifyAllExpectations();
        }

        [Test]
        public void GetData_should_populate_data()
        {
            IDisplayDataView view = MockRepository.GenerateStub<IDisplayDataView>();
            DisplayDataPresenter presenter = new DisplayDataPresenter(view);
            presenter.GetData(this, EventArgs.Empty);

            Assert.AreEqual(4, view.Data.Count);
        }

        [Test]
        public void GetData_should_call_Bind()
        {
            IDisplayDataView view = MockRepository.GenerateMock<IDisplayDataView>();
            view.Expect(v => v.Bind());
            DisplayDataPresenter presenter = new DisplayDataPresenter(view);
            presenter.GetData(this, EventArgs.Empty);
            view.VerifyAllExpectations();
        }        
    }
}
