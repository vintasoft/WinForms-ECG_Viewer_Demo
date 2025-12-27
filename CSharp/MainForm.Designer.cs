
namespace EcgViewerDemo
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
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard1 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings1 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gain5mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gain10mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gain20mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gain40mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridTypeNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridType1mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridType5mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorRedBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBlueBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorGreenBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorGrayGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caliperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caliperOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caliperDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caliperDurationAndMVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.openDicomFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ecgVisualToolSelectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imagePrintDocument1 = new Vintasoft.Imaging.Print.ImagePrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.imageViewerToolStrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.fileMetadataTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.printToolStripMenuItem,
            this.pageSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printToolStripMenuItem.Text = "Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // pageSettingsToolStripMenuItem
            // 
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pageSettingsToolStripMenuItem.Text = "Page Settings";
            this.pageSettingsToolStripMenuItem.Click += new System.EventHandler(this.pageSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gainToolStripMenuItem,
            this.gridTypeToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.caliperToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gainToolStripMenuItem
            // 
            this.gainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gain5mmToolStripMenuItem,
            this.gain10mmToolStripMenuItem,
            this.gain20mmToolStripMenuItem,
            this.gain40mmToolStripMenuItem});
            this.gainToolStripMenuItem.Name = "gainToolStripMenuItem";
            this.gainToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.gainToolStripMenuItem.Text = "Gain";
            // 
            // gain5mmToolStripMenuItem
            // 
            this.gain5mmToolStripMenuItem.Name = "gain5mmToolStripMenuItem";
            this.gain5mmToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gain5mmToolStripMenuItem.Text = "5 mm/mV";
            this.gain5mmToolStripMenuItem.Click += new System.EventHandler(this.gainToolStripMenuItem_Click);
            // 
            // gain10mmToolStripMenuItem
            // 
            this.gain10mmToolStripMenuItem.Name = "gain10mmToolStripMenuItem";
            this.gain10mmToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gain10mmToolStripMenuItem.Text = "10 mm/mV";
            this.gain10mmToolStripMenuItem.Click += new System.EventHandler(this.gainToolStripMenuItem_Click);
            // 
            // gain20mmToolStripMenuItem
            // 
            this.gain20mmToolStripMenuItem.Name = "gain20mmToolStripMenuItem";
            this.gain20mmToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gain20mmToolStripMenuItem.Text = "20 mm/mV";
            this.gain20mmToolStripMenuItem.Click += new System.EventHandler(this.gainToolStripMenuItem_Click);
            // 
            // gain40mmToolStripMenuItem
            // 
            this.gain40mmToolStripMenuItem.Name = "gain40mmToolStripMenuItem";
            this.gain40mmToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gain40mmToolStripMenuItem.Text = "40 mm/mV";
            this.gain40mmToolStripMenuItem.Click += new System.EventHandler(this.gainToolStripMenuItem_Click);
            // 
            // gridTypeToolStripMenuItem
            // 
            this.gridTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridTypeNoneToolStripMenuItem,
            this.gridType1mmToolStripMenuItem,
            this.gridType5mmToolStripMenuItem});
            this.gridTypeToolStripMenuItem.Name = "gridTypeToolStripMenuItem";
            this.gridTypeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.gridTypeToolStripMenuItem.Text = "Grid Type";
            // 
            // gridTypeNoneToolStripMenuItem
            // 
            this.gridTypeNoneToolStripMenuItem.Name = "gridTypeNoneToolStripMenuItem";
            this.gridTypeNoneToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gridTypeNoneToolStripMenuItem.Text = "None";
            this.gridTypeNoneToolStripMenuItem.Click += new System.EventHandler(this.gridTypeToolStripMenuItem_Click);
            // 
            // gridType1mmToolStripMenuItem
            // 
            this.gridType1mmToolStripMenuItem.Name = "gridType1mmToolStripMenuItem";
            this.gridType1mmToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gridType1mmToolStripMenuItem.Text = "1 mm";
            this.gridType1mmToolStripMenuItem.Click += new System.EventHandler(this.gridTypeToolStripMenuItem_Click);
            // 
            // gridType5mmToolStripMenuItem
            // 
            this.gridType5mmToolStripMenuItem.Name = "gridType5mmToolStripMenuItem";
            this.gridType5mmToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gridType5mmToolStripMenuItem.Text = "5 mm";
            this.gridType5mmToolStripMenuItem.Click += new System.EventHandler(this.gridTypeToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorRedBlackToolStripMenuItem,
            this.colorBlueBlackToolStripMenuItem,
            this.colorGreenBlackToolStripMenuItem,
            this.colorGrayGreenToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // colorRedBlackToolStripMenuItem
            // 
            this.colorRedBlackToolStripMenuItem.Checked = true;
            this.colorRedBlackToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorRedBlackToolStripMenuItem.Name = "colorRedBlackToolStripMenuItem";
            this.colorRedBlackToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorRedBlackToolStripMenuItem.Text = "Red / Black";
            this.colorRedBlackToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorBlueBlackToolStripMenuItem
            // 
            this.colorBlueBlackToolStripMenuItem.Name = "colorBlueBlackToolStripMenuItem";
            this.colorBlueBlackToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorBlueBlackToolStripMenuItem.Text = "Blue / Black";
            this.colorBlueBlackToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorGreenBlackToolStripMenuItem
            // 
            this.colorGreenBlackToolStripMenuItem.Name = "colorGreenBlackToolStripMenuItem";
            this.colorGreenBlackToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorGreenBlackToolStripMenuItem.Text = "Green / Black";
            this.colorGreenBlackToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorGrayGreenToolStripMenuItem
            // 
            this.colorGrayGreenToolStripMenuItem.Name = "colorGrayGreenToolStripMenuItem";
            this.colorGrayGreenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.colorGrayGreenToolStripMenuItem.Text = "Gray / Green";
            this.colorGrayGreenToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // caliperToolStripMenuItem
            // 
            this.caliperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caliperOffToolStripMenuItem,
            this.caliperDurationToolStripMenuItem,
            this.caliperDurationAndMVToolStripMenuItem});
            this.caliperToolStripMenuItem.Name = "caliperToolStripMenuItem";
            this.caliperToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.caliperToolStripMenuItem.Text = "Caliper";
            // 
            // caliperOffToolStripMenuItem
            // 
            this.caliperOffToolStripMenuItem.Name = "caliperOffToolStripMenuItem";
            this.caliperOffToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.caliperOffToolStripMenuItem.Text = "Off";
            this.caliperOffToolStripMenuItem.Click += new System.EventHandler(this.caliperToolStripMenuItem_Click);
            // 
            // caliperDurationToolStripMenuItem
            // 
            this.caliperDurationToolStripMenuItem.Name = "caliperDurationToolStripMenuItem";
            this.caliperDurationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.caliperDurationToolStripMenuItem.Text = "Duration";
            this.caliperDurationToolStripMenuItem.Click += new System.EventHandler(this.caliperToolStripMenuItem_Click);
            // 
            // caliperDurationAndMVToolStripMenuItem
            // 
            this.caliperDurationAndMVToolStripMenuItem.Name = "caliperDurationAndMVToolStripMenuItem";
            this.caliperDurationAndMVToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.caliperDurationAndMVToolStripMenuItem.Text = "Duration And μV";
            this.caliperDurationAndMVToolStripMenuItem.Click += new System.EventHandler(this.caliperToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageViewer1
            // 
            this.imageViewer1.BackColor = System.Drawing.Color.White;
            this.imageViewer1.Clipboard = winFormsSystemClipboard1;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.FastScrollingCursor = System.Windows.Forms.Cursors.SizeAll;
            this.imageViewer1.FastScrollingInterval = 10;
            this.imageViewer1.FastScrollingMinDistance = 5F;
            this.imageViewer1.FastScrollingMouseButton = System.Windows.Forms.MouseButtons.Middle;
            this.imageViewer1.FastScrollingScale = 0.5F;
            this.imageViewer1.ImageRenderingSettings = renderingSettings1;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(728, 593);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer1.TabIndex = 2;
            this.imageViewer1.Text = "imageViewer1";
            // 
            // openDicomFileDialog
            // 
            this.openDicomFileDialog.Filter = "DICOM files|*.dcm;*.dic;*.acr|All files|*.*";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecgVisualToolSelectionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ecgVisualToolSelectionLabel
            // 
            this.ecgVisualToolSelectionLabel.Name = "ecgVisualToolSelectionLabel";
            this.ecgVisualToolSelectionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // imagePrintDocument1
            // 
            this.imagePrintDocument1.Center = false;
            this.imagePrintDocument1.DistanceBetweenImages = 0;
            this.imagePrintDocument1.PrintScaleMode = Vintasoft.Imaging.Print.PrintScaleMode.BestFit;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.imagePrintDocument1;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.imagePrintDocument1;
            this.pageSetupDialog1.EnableMetric = true;
            // 
            // imageViewerToolStrip1
            // 
            this.imageViewerToolStrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolStrip1.CanNavigate = false;
            this.imageViewerToolStrip1.CaptureFromCameraButtonEnabled = true;
            this.imageViewerToolStrip1.ImageViewer = this.imageViewer1;
            this.imageViewerToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.imageViewerToolStrip1.Name = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.PageCount = 0;
            this.imageViewerToolStrip1.PrintButtonEnabled = true;
            this.imageViewerToolStrip1.ScanButtonEnabled = true;
            this.imageViewerToolStrip1.Size = new System.Drawing.Size(952, 25);
            this.imageViewerToolStrip1.TabIndex = 3;
            this.imageViewerToolStrip1.Text = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.UseImageViewerImages = true;
            this.imageViewerToolStrip1.OpenFile += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.imageViewerToolStrip1.SaveFile += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.imageViewerToolStrip1.Print += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // fileMetadataTextBox
            // 
            this.fileMetadataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileMetadataTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileMetadataTextBox.Location = new System.Drawing.Point(0, 0);
            this.fileMetadataTextBox.Multiline = true;
            this.fileMetadataTextBox.Name = "fileMetadataTextBox";
            this.fileMetadataTextBox.ReadOnly = true;
            this.fileMetadataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileMetadataTextBox.Size = new System.Drawing.Size(220, 593);
            this.fileMetadataTextBox.TabIndex = 5;
            this.fileMetadataTextBox.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fileMetadataTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(952, 593);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 664);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imageViewerToolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECG Viewer Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem gainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gain5mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gain10mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gain20mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gain40mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridTypeNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridType1mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridType5mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorRedBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBlueBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorGreenBlackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorGrayGreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caliperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caliperOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caliperDurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caliperDurationAndMVToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDicomFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ecgVisualToolSelectionLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Vintasoft.Imaging.Print.ImagePrintDocument imagePrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox fileMetadataTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}