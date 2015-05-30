using System;
using System.Windows.Forms;
using rn.rn_inform.test.Storage;




namespace rn.rn_inform.test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addFile(object sender, EventArgs e)
        {
            AddFileForm AddFileForm = new AddFileForm();
            AddFileForm.ShowDialog();
        }

        private void importXml(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RNUObj RNUObj = RNUObj.Instance();
                RNUObj = Xml.ImportXml<RNUObj>(openFileDialog.FileName);

                treeView.Nodes.Clear();
                treeView.Nodes.Add(Tree.PopulateTreeRoot(RNUObj));
            }
        }

        private void exportXml(object sender, EventArgs e)
        {

        }
    }
}
