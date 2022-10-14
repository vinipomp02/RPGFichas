using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFichas
{
    class VerticalLabel : Label
    {
        private int _rotateAngle = 1;
        [Category("Additional Options")]
        public int RotateAngle
        {
            get
            {
                return _rotateAngle;
            }
            set
            {
                _rotateAngle = value;
                Invalidate();//redraw component after change value from VS Properties section
            }
        }

        private string _textRotate =  "";
        [Category("Additional Options")]
        public string TextRotate
        {
            get
            {
                return _textRotate;
            }
            set
            {
                _textRotate = value;
                Invalidate();//redraw component after change value from VS Properties section
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(this.Width / 8, this.Height/2 + TextRenderer.MeasureText(_textRotate, this.Font).Width/2);
            e.Graphics.RotateTransform(this.RotateAngle);
            e.Graphics.DrawString(this._textRotate, this.Font, b, 0f, 0f);
            base.OnPaint(e);
        }
    }
}