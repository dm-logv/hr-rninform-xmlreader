using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rn.rn_inform.test
{
    public partial class AddFileForm : Form
    {
        public AddFileForm()
        {
            InitializeComponent();
            this.CancelButton = this.cancelButton;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = openFileDialog.FileName;
            }
        }
    }
}
