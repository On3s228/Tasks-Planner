using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.CustomControls
{
    public interface ICustomTextBox
    {
        string Text { get; set; }
        Color BorderColor { get; set; }
    }
}
