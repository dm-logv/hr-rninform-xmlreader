namespace rn.rn_inform.test
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXmlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXmlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.importXmlButton = new System.Windows.Forms.ToolStripButton();
            this.exportXmlButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addFileButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.complectsCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.documentsCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.filesCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(694, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXmlMenuItem,
            this.exportXmlMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "&Файл";
            // 
            // importXmlMenuItem
            // 
            this.importXmlMenuItem.Name = "importXmlMenuItem";
            this.importXmlMenuItem.Size = new System.Drawing.Size(160, 22);
            this.importXmlMenuItem.Text = "&Импорт из XML";
            this.importXmlMenuItem.Click += new System.EventHandler(this.importXml);
            // 
            // exportXmlMenuItem
            // 
            this.exportXmlMenuItem.Name = "exportXmlMenuItem";
            this.exportXmlMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportXmlMenuItem.Text = "&Экспорт в XML";
            this.exportXmlMenuItem.Click += new System.EventHandler(this.exportXml);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitMenuItem.Text = "Вы&ход";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXmlButton,
            this.exportXmlButton,
            this.toolStripSeparator2,
            this.addFileButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(694, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // importXmlButton
            // 
            this.importXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.importXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("importXmlButton.Image")));
            this.importXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importXmlButton.Name = "importXmlButton";
            this.importXmlButton.Size = new System.Drawing.Size(23, 22);
            this.importXmlButton.Text = "Импорт из XML";
            this.importXmlButton.ToolTipText = "Импорт из XML";
            this.importXmlButton.Click += new System.EventHandler(this.importXml);
            // 
            // exportXmlButton
            // 
            this.exportXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("exportXmlButton.Image")));
            this.exportXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportXmlButton.Name = "exportXmlButton";
            this.exportXmlButton.Size = new System.Drawing.Size(23, 22);
            this.exportXmlButton.Text = "Экспорт в XML";
            this.exportXmlButton.Click += new System.EventHandler(this.exportXml);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addFileButton
            // 
            this.addFileButton.Image = ((System.Drawing.Image)(resources.GetObject("addFileButton.Image")));
            this.addFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(111, 22);
            this.addFileButton.Text = "Добавить файл";
            this.addFileButton.Click += new System.EventHandler(this.addFile);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complectsCountStatusLabel,
            this.documentsCountStatusLabel,
            this.filesCountStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 416);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(694, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // complectsCountStatusLabel
            // 
            this.complectsCountStatusLabel.Name = "complectsCountStatusLabel";
            this.complectsCountStatusLabel.Size = new System.Drawing.Size(86, 17);
            this.complectsCountStatusLabel.Text = "Комплектов: 0";
            this.complectsCountStatusLabel.ToolTipText = "Количество комплектов";
            // 
            // documentsCountStatusLabel
            // 
            this.documentsCountStatusLabel.Name = "documentsCountStatusLabel";
            this.documentsCountStatusLabel.Size = new System.Drawing.Size(86, 17);
            this.documentsCountStatusLabel.Text = "Документов: 0";
            this.documentsCountStatusLabel.ToolTipText = "Количество документов";
            // 
            // filesCountStatusLabel
            // 
            this.filesCountStatusLabel.Name = "filesCountStatusLabel";
            this.filesCountStatusLabel.Size = new System.Drawing.Size(61, 17);
            this.filesCountStatusLabel.Text = "Файлов: 0";
            this.filesCountStatusLabel.ToolTipText = "Количество файлов";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(694, 367);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(230, 367);
            this.treeView.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Property,
            this.Value});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(460, 367);
            this.dataGridView.TabIndex = 0;
            // 
            // Property
            // 
            this.Property.HeaderText = "Свойство";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.xml";
            this.openFileDialog.Filter = "\"XML-файл|*.xml|Все файлы|*.*\" ";
            this.openFileDialog.Title = "Открыть файл XML";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 438);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "rn.rn-inform.test";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importXmlMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportXmlMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton importXmlButton;
        private System.Windows.Forms.ToolStripButton exportXmlButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addFileButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel complectsCountStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel documentsCountStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel filesCountStatusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

