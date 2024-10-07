namespace WinFormsApp1
{
    partial class FrmLayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            listBox1 = new ListBox();
            toolStrip1 = new ToolStrip();
            btnAddLayer = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDeleteLayer = new ToolStripButton();
            propertyGrid1 = new PropertyGrid();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(propertyGrid1);
            splitContainer1.Size = new Size(603, 406);
            splitContainer1.SplitterDistance = 287;
            splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(287, 375);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAddLayer, toolStripSeparator1, btnDeleteLayer });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(287, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAddLayer
            // 
            btnAddLayer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddLayer.Image = Properties.Resources.layers_current_add;
            btnAddLayer.ImageTransparentColor = Color.Magenta;
            btnAddLayer.Name = "btnAddLayer";
            btnAddLayer.Size = new Size(28, 28);
            btnAddLayer.Text = "Add Layer";
            btnAddLayer.Click += btnAddLayer_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnDeleteLayer
            // 
            btnDeleteLayer.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeleteLayer.Image = Properties.Resources.trash;
            btnDeleteLayer.ImageTransparentColor = Color.Magenta;
            btnDeleteLayer.Name = "btnDeleteLayer";
            btnDeleteLayer.Size = new Size(28, 28);
            btnDeleteLayer.Text = "Delete Layer";
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(312, 406);
            propertyGrid1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(603, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // FrmLayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 428);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Name = "FrmLayer";
            Text = "FrmLayer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private PropertyGrid propertyGrid1;
        private ToolStripButton btnAddLayer;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDeleteLayer;
        private ListBox listBox1;
        private StatusStrip statusStrip1;
    }
}