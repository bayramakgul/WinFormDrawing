namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnLayer = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnLine = new ToolStripButton();
            btnPolyline = new ToolStripButton();
            btnRect = new ToolStripButton();
            btnCircle = new ToolStripButton();
            btnEllipse = new ToolStripButton();
            btnText = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            drwPanel1 = new DrwPanel();
            propertyGrid1 = new PropertyGrid();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnLayer, toolStripSeparator1, btnLine, btnPolyline, btnRect, btnCircle, btnEllipse, btnText });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(972, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnLayer
            // 
            btnLayer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLayer.Image = Properties.Resources.layers_current;
            btnLayer.ImageTransparentColor = Color.Magenta;
            btnLayer.Name = "btnLayer";
            btnLayer.Size = new Size(36, 36);
            btnLayer.Text = "Layer";
            btnLayer.Click += btnLayer_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // btnLine
            // 
            btnLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLine.Image = Properties.Resources.draw_line;
            btnLine.ImageTransparentColor = Color.Magenta;
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(36, 36);
            btnLine.Text = "Line";
            btnLine.Click += btnLine_Click;
            // 
            // btnPolyline
            // 
            btnPolyline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPolyline.Image = Properties.Resources.draw_polyline;
            btnPolyline.ImageTransparentColor = Color.Magenta;
            btnPolyline.Name = "btnPolyline";
            btnPolyline.Size = new Size(36, 36);
            btnPolyline.Text = "Polyline";
            btnPolyline.Click += btnPolyline_Click;
            // 
            // btnRect
            // 
            btnRect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRect.Image = Properties.Resources.draw_rectangle_2_points;
            btnRect.ImageTransparentColor = Color.Magenta;
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(36, 36);
            btnRect.Text = "Rectangle";
            btnRect.Click += btnRect_Click;
            // 
            // btnCircle
            // 
            btnCircle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCircle.Image = Properties.Resources.draw_circle_radius;
            btnCircle.ImageTransparentColor = Color.Magenta;
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(36, 36);
            btnCircle.Text = "Circle";
            btnCircle.Click += btnCircle_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEllipse.Image = Properties.Resources.draw_ellipse_center_2_points;
            btnEllipse.ImageTransparentColor = Color.Magenta;
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(36, 36);
            btnEllipse.Text = "Ellipse";
            btnEllipse.Click += btnEllipse_Click;
            // 
            // btnText
            // 
            btnText.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnText.Image = Properties.Resources.text;
            btnText.ImageTransparentColor = Color.Magenta;
            btnText.Name = "btnText";
            btnText.Size = new Size(36, 36);
            btnText.Text = "Text";
            btnText.Click += btnText_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 675);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(972, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 39);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(drwPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(propertyGrid1);
            splitContainer1.Size = new Size(972, 636);
            splitContainer1.SplitterDistance = 727;
            splitContainer1.TabIndex = 2;
            // 
            // drwPanel1
            // 
            drwPanel1.BackColor = Color.White;
            drwPanel1.Dock = DockStyle.Fill;
            drwPanel1.Location = new Point(0, 0);
            drwPanel1.Name = "drwPanel1";
            drwPanel1.Size = new Size(727, 636);
            drwPanel1.TabIndex = 0;
            drwPanel1.MouseClick += drwPanel1_MouseClick;
            drwPanel1.MouseMove += drwPanel1_MouseMove;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(241, 636);
            propertyGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 697);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplitContainer splitContainer1;
        private PropertyGrid propertyGrid1;
        private ToolStripButton btnLayer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnLine;
        private ToolStripButton btnPolyline;
        private ToolStripButton btnRect;
        private ToolStripButton btnCircle;
        private ToolStripButton btnEllipse;
        private ToolStripButton btnText;
        private DrwPanel drwPanel1;
    }
}
