using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RPGFichas.Domain
{
    public class Visual
    {
        RectangleF ClientRectangle { get; set; }
        Font Font { get; set; }
        GraphicsPath GetStringPath(Label lbl)
        {

            StringFormat f = new StringFormat();
            RectangleF rect = new RectangleF(lbl.Location.X, lbl.Location.Y, lbl.Width, lbl.Height);
            GraphicsPath path = new GraphicsPath();
            // Convert font size into appropriate coordinates
            float emSize = lbl.DeviceDpi * lbl.Font.Size/ 72;
            path.AddString(lbl.Text, lbl.Font.FontFamily, (int)lbl.Font.Style, emSize, rect, f);

            return path;
        }

        public void Form_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            Graphics g = e.Graphics;
            using (GetStringPath(lbl))
            {
                g.DrawPath(Pens.White, GetStringPath(lbl));
            }
        }
    }
}
