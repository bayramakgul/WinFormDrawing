using DxfLibrary.Tables;

using Microsoft.VisualBasic;

namespace WinFormsApp1
{
    public partial class FrmLayer : Form
    {
        public FrmLayer()
        {
            InitializeComponent();
        }


        public Action<Layer> SetCurrentLayer;
        public List<Layer> Layers;

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            string layerName = Interaction.InputBox("Layer Adı:", "Layer", $"Layer{listBox1.Items.Count+1}");

            if (layerName != null && layerName != "")
            {
                Layer layer = new Layer(){ Level = 0, Color = Color.Black, Name = layerName, LineWeight = 1 };

                Layers.Add(layer);

                listBox1.Items.Add(layer);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = (Layer)listBox1.SelectedItem;
            SetCurrentLayer((Layer)listBox1.SelectedItem);

        }
    }
}
