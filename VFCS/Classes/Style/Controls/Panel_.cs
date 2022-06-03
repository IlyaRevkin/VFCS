using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFCS.Classes.Style.Controls
{
    public class Panel_ : Panel
    {
        public Color LineColor;
        public float LineWidth = 2.0F;

        public Panel_()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            LineColor = BackColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, ClientRectangle);

            Pen PenCust = new Pen(LineColor, LineWidth);

            e.Graphics.DrawRectangle(PenCust, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        }

    }
}
