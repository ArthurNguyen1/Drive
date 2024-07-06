using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Drive.CustomControl
{
    public class TransparentTxb : TextBox
    {
        public TransparentTxb()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do not call base.OnPaintBackground(e) to prevent background painting.
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x14) // WM_ERASEBKGND
            {
                IntPtr hdc = m.WParam;
                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    g.FillRectangle(new SolidBrush(Color.Transparent), this.ClientRectangle);
                }
                m.Result = (IntPtr)0;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default; // Đặt con trỏ khi rê chuột vào
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Cursor = Cursors.IBeam; // Khôi phục con trỏ khi rê chuột ra
        }
    }
}