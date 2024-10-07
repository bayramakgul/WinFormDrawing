using DxfLibrary.Entity;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frmLayer = new FrmLayer() { StartPosition = FormStartPosition.CenterParent, Text = "Layer", Layers = drwPanel1.Layers, SetCurrentLayer = drwPanel1.SetCurrentLayer };
        }


        FrmLayer frmLayer;

        private void btnLayer_Click(object sender, EventArgs e)
        {
            frmLayer.ShowDialog();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            drwPanel1.CurrentCommand = DrwPanel.DCommand.Line;
            cnt = 0;
        }

        private void btnPolyline_Click(object sender, EventArgs e)
        {
            drwPanel1.CurrentCommand = DrwPanel.DCommand.Polyline;
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            drwPanel1.CurrentCommand = DrwPanel.DCommand.Rectancle;

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            drwPanel1.CurrentCommand = DrwPanel.DCommand.Circle;

        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            drwPanel1.CurrentCommand = DrwPanel.DCommand.Ellipse;

        }

        private void btnText_Click(object sender, EventArgs e)
        {
            drwPanel1.CurrentCommand = DrwPanel.DCommand.Text;

        }

        int cnt=0;
        PointF p1, p2;
        private void drwPanel1_MouseClick(object sender, MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Right)
            {
                drwPanel1.CurrentCommand = DrwPanel.DCommand.None;
                cnt = 0;
                return;
            }

            PointF p = new PointF(e.X, e.Y);
            switch (drwPanel1.CurrentCommand)
            {
                case DrwPanel.DCommand.Line:
                    if (cnt == 0)
                        p1 = new PointF(e.X, e.Y);
                    else
                        p2 = new PointF(e.X, e.Y);

                    if (cnt > 0)
                    {
                        Line ln = new Line(p1, p2);
                        ln.Layer = drwPanel1.CurrentLayer;

                        drwPanel1.Entities.Add(ln);

                        p1 = new PointF(p2.X, p2.Y);
                    }

                    cnt++;
                    break;


            }
        }

        private void drwPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (drwPanel1.CurrentCommand)
            {
                case DrwPanel.DCommand.None:
                    break;
                case DrwPanel.DCommand.Line:
                    if (cnt > 0)
                        drwPanel1.CurrentEntity = new Line(p1, new PointF(e.X, e.Y));
                    break;
            }
        }
    }
}
