using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoQuanLyThuVien
{
    class DrawHinhThoi: Button 
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = pevent.Graphics;
            float w = this.Width;
            float h = this.Height;

            PointF[] poi = new PointF[] { new PointF(w / 2, 0), new PointF(w, h / 2), new PointF(w / 2, h), new PointF(0, h / 2)/*, 
                new PointF((w / 2) - 2, 0) ,new PointF() ,new PointF(w, h / 2),new PointF() ,
                new PointF(w / 2, h),new PointF(),new PointF(0, h / 2),new PointF()*/ };
            
            g.FillPolygon(new SolidBrush(this.BackColor), poi);
            gp.AddPolygon(poi);
            this.Region = new Region(gp);
            base.OnPaint(pevent);
        }
    }
}
