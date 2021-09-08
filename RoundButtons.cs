using System;
using System.Collections.Generic;
using System.Text;
// we need to add those two librally's
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Licenta_V1
{
    public class RoundButtons : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(pevent);
        }
    }
}
