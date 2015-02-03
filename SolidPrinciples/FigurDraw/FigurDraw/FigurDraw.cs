using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FigurDraw
{
    public partial class FigurDraw : Form
    {
        public FigurDraw()
        {
            InitializeComponent();
        }

        private void FormDraw_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(10, 10, 50, 75));
        }

        private void tnrAppTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void FigurDraw_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(FormDraw_Paint);                                  
        }
    }
}
