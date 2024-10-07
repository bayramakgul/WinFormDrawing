using DxfLibrary.Entity;
using DxfLibrary.Tables;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DrwPanel : Panel
    {

        public enum DCommand
        {
            None,
            Line,
            Circle,
            Ellipse,
            Polyline,
            Rectancle,
            Text,
        }

        public List<BaseEntity> Entities;
        public List<Layer>      Layers;
        public DCommand         CurrentCommand = DCommand.None;

        public Layer            CurrentLayer;
        Point   CursorPoint;
        Pen     CurrentPen;


        public BaseEntity CurrentEntity;

        public void SetCurrentLayer(Layer layer)
        {
            CurrentLayer = layer;
        }

        public DrwPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            this.Cursor = Cursors.Cross;
            CurrentPen = new Pen(Color.Black);
            CurrentLayer = new Layer() { Name="0", Color = Color.Black, Level = 0, LineType = new LineType(), LineWeight = 1, Locked = false, Visible = true };
            Entities = new List<BaseEntity>();
            Layers = new List<Layer>();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            CursorPoint = e.Location;
            Invalidate();
        }

        public void AddEntity(BaseEntity entity)
        {
            Entities.Add(entity);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics = e.Graphics;

            foreach (var entity in Entities)
            {

                CurrentPen.Color = entity.Layer.Color;
                CurrentPen.Width = entity.Layer.LineWeight;

                if (entity is Line)
                {
                    var line = (Line)entity;
                    DrawLine(line);
                }
                else if (entity is Circle)
                {
                    var circle = (Circle)entity;
                    DrawCircle(circle);
                }
                else if (entity is Ellipse)
                {
                    var ellipse = (Ellipse)entity;
                    DrawEllipse(ellipse);
                }

            }


            e.Graphics.DrawLine(Pens.DarkGray, CursorPoint.X, 0, CursorPoint.X, Height);
            e.Graphics.DrawLine(Pens.DarkGray, 0, CursorPoint.Y, Width, CursorPoint.Y);

            DrawCurrent(CurrentEntity);

        }

        private void DrawCurrent(BaseEntity current)
        {
            if (current is Line)
            {
                var line = (Line)current;
                DrawLine(line);
            }
            else if (current is Circle)
            {
                var circle = (Circle)current;
                DrawCircle(circle);
            }
            else if (current is Ellipse)
            {
                var ellipse = (Ellipse)current;
                DrawEllipse(ellipse);
            }

        }

        Graphics Graphics; 

        public void DrawLine(Line line)
        {
            Graphics.DrawLine(CurrentPen, line.SP.ToPointF(), line.EP.ToPointF());

        }

        public void DrawCircle(Circle circle)
        {
            PointF p0 = circle.Center.Offset(-circle.Radius, -circle.Radius).ToPointF();
            Graphics.DrawEllipse(CurrentPen, p0.X, p0.Y, (float)circle.Radius, (float)circle.Radius);

        }

        public void DrawEllipse(Ellipse ellipse)
        {
            PointF p0 = ellipse.Center.Offset(-ellipse.MajorAxis, -ellipse.MinorAxis).ToPointF();
            Graphics.DrawEllipse(CurrentPen, p0.X, p0.Y, (float)ellipse.MajorAxis, (float)ellipse.MinorAxis);

        }
    }
}
