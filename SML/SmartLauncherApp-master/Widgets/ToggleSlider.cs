using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Artemis.Skeet_Controls
{
    internal class ToggleSlider : CheckBox  
    {
        private Color onBackColor = Color.FromArgb(128, 255, 128);
        private Color onToggleColor = Color.Gray;
        private Color offBackColor = Color.FromArgb(128, 128, 255);
        private Color offToggleColor = Color.Gray;
        
        public ToggleSlider()
        {
            this.MinimumSize = new Size(35, 20);
        }
        private GraphicsPath GetFigurePath()
        {
            int dimensiune = this.Height - 1;
            Rectangle parteStanga = new Rectangle(0, 0, dimensiune, dimensiune);
            Rectangle parteDreapta = new Rectangle(this.Width - dimensiune - 2, 0, dimensiune, dimensiune);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(parteStanga, 90, 180);
            path.AddArc(parteDreapta, 270, 180);
            path.CloseFigure();

            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked) // button ENABLED
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor),  GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else // button DISABLED
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
