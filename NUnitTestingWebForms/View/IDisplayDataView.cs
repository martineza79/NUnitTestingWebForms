using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingWebForms.View
{
    public interface IDisplayDataView
    {
        event EventHandler DataRequested; // EventHandler Delegate see "delegate void EventHandler MSDN" for more info.
        List<string> Data { get; set; }
        void Bind();
    }    
}
