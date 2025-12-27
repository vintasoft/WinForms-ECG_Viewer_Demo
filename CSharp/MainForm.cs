using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Decoders;
using Vintasoft.Imaging.Dicom.UI.VisualTools;
using Vintasoft.Imaging.Metadata;

namespace EcgViewerDemo
{
    /// <summary>
    /// Main form of ECG viewer demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Template of the application title.
        /// </summary>
        string _titlePrefix = "VintaSoft ECG Viewer Demo v" + ImagingGlobalSettings.ProductVersion + " - {0}";

        /// <summary>
        /// The print manager.
        /// </summary>
        ImageViewerPrintManager _printManager;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.Text = string.Format(_titlePrefix, "(Untitled)");

            // set the initial directory in open DICOM file dialog
            DemosTools.SetTestFilesFolder(openDicomFileDialog);

            imageViewer1.ImageRenderingSettings = new EcgRenderingSettings();
            imageViewer1.ImageRenderingSettings.Changed += ImageRenderingSettings_Changed;
            imageViewer1.FocusedIndexChanged += ImageViewer1_FocusedIndexChanged;

            // create visual tool
            EcgVisualTool visualTool = new EcgVisualTool();
            visualTool.SelectionChanged += VisualTool_SelectionChanged;
            visualTool.Enabled = false;
            imageViewer1.VisualTool = visualTool;

            // create print manager
            _printManager = new ImageViewerPrintManager(imageViewer1, imagePrintDocument1, printDialog1);
            imagePrintDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);

            UpdateUI();
        }

        #endregion



        #region Properties

        bool _isFileOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether the file is opening.
        /// </summary>
        private bool IsFileOpening
        {
            get
            {
                return _isFileOpening;
            }
            set
            {
                _isFileOpening = value;

                InvokeUpdateUI();
            }
        }

        /// <summary>
        /// Gets the <see cref="EcgRenderingSettings"/>.
        /// </summary>
        private EcgRenderingSettings EcgRenderingSettings
        {
            get
            {
                return (EcgRenderingSettings)imageViewer1.ImageRenderingSettings;
            }
        }

        #endregion



        #region Methods

        #region PRIVATE

        #region UI state

        /// <summary>
        /// Updates the user interface safely.
        /// </summary>
        private void InvokeUpdateUI()
        {
            if (InvokeRequired)
                Invoke(new UpdateUIDelegate(UpdateUI));
            else
                UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            bool isOpening = IsFileOpening;
            bool isOpened = imageViewer1.Image != null;

            openToolStripMenuItem.Enabled = !isOpening;
            saveToolStripMenuItem.Enabled = !isOpening && isOpened;
            printToolStripMenuItem.Enabled = !isOpening && isOpened;
            closeToolStripMenuItem.Enabled = !isOpening && isOpened;
            imageViewerToolStrip1.SaveButtonEnabled = saveToolStripMenuItem.Enabled;
            imageViewerToolStrip1.PrintButtonEnabled = printToolStripMenuItem.Enabled;
            imageViewerToolStrip1.IsNavigateEnabled = !isOpening && isOpened;


            gainToolStripMenuItem.Enabled = !isOpening && isOpened;
            foreach (ToolStripMenuItem item in gainToolStripMenuItem.DropDownItems)
                item.Checked = false;
            switch (EcgRenderingSettings.MillimetersPerMillivolt)
            {
                case 5:
                    gain5mmToolStripMenuItem.Checked = true;
                    break;

                case 10:
                    gain10mmToolStripMenuItem.Checked = true;
                    break;

                case 20:
                    gain20mmToolStripMenuItem.Checked = true;
                    break;

                case 40:
                    gain40mmToolStripMenuItem.Checked = true;
                    break;
            }


            gridTypeToolStripMenuItem.Enabled = !isOpening && isOpened;
            foreach (ToolStripMenuItem item in gridTypeToolStripMenuItem.DropDownItems)
                item.Checked = false;
            if (EcgRenderingSettings.MajorGridThickness == 0 && EcgRenderingSettings.MinorGridThickness == 0)
            {
                gridTypeNoneToolStripMenuItem.Checked = true;
            }
            else if (EcgRenderingSettings.MajorGridThickness == 1)
            {
                if (EcgRenderingSettings.MinorGridThickness == 0)
                    gridType5mmToolStripMenuItem.Checked = true;
                else
                    gridType1mmToolStripMenuItem.Checked = true;
            }


            colorToolStripMenuItem.Enabled = !isOpening && isOpened;


            caliperToolStripMenuItem.Enabled = !isOpening && isOpened;
            foreach (ToolStripMenuItem item in caliperToolStripMenuItem.DropDownItems)
                item.Checked = false;
            EcgVisualTool visualTool = (EcgVisualTool)imageViewer1.VisualTool;
            if (visualTool.Enabled)
            {
                if (visualTool.InterationMode == EcgInterationMode.Duration)
                    caliperDurationToolStripMenuItem.Checked = true;
                else
                    caliperDurationAndMVToolStripMenuItem.Checked = true;
            }
            else
            {
                caliperOffToolStripMenuItem.Checked = true;
            }
        }

        #endregion


        #region 'File' menu

        /// <summary>
        /// Handles the Click event of openToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if file can be opened
            if (openDicomFileDialog.ShowDialog() == DialogResult.OK)
            {
                IsFileOpening = true;
                try
                {
                    // open file
                    VintasoftImage image = new VintasoftImage(openDicomFileDialog.FileName);

                    // if opened file is ECG file
                    if (image.Metadata.MetadataTree.FindChildNode<EcgMetadata>() != null)
                    {
                        // remove images from image viewer
                        imageViewer1.Images.ClearAndDisposeItems();
                        // add image to image viewer
                        imageViewer1.Images.Add(image);

                        // update header of form
                        this.Text = string.Format(_titlePrefix, Path.GetFileName(openDicomFileDialog.FileName));
                    }
                    else
                    {
                        // remove image
                        image.Dispose();
                        throw new InvalidOperationException(string.Format(
                            "The file '{0}' can't be opened because file does not contain the electrocardiogram data.",
                            openDicomFileDialog.FileName));
                    }
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
                finally
                {
                    IsFileOpening = false;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of saveToolStripMenuItem object.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodecsFileFilters.SetSaveFileDialogFilter(saveFileDialog, false, false);
            // if file is selected in "Save file" dialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string saveFilename = Path.GetFullPath(saveFileDialog.FileName);

                    // save an electrocardiogram image to an image file
                    imageViewer1.Images.SaveAsync(saveFilename);
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of closeToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove images from image viewer
            imageViewer1.Images.ClearAndDisposeItems();
            UpdateUI();
        }

        /// <summary>
        /// Handles the Click event of pageSettingsToolStripMenuItem object.
        /// </summary>
        private void pageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show the print page settings
            pageSetupDialog1.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of printToolStripMenuItem object.
        /// </summary>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // print image
            _printManager.Print();
        }

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of gainToolStripMenuItem object.
        /// </summary>
        private void gainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcgRenderingSettings.BeginInit();
            if (sender == gain5mmToolStripMenuItem)
                EcgRenderingSettings.MillimetersPerMillivolt = 5;
            else if (sender == gain10mmToolStripMenuItem)
                EcgRenderingSettings.MillimetersPerMillivolt = 10;
            else if (sender == gain20mmToolStripMenuItem)
                EcgRenderingSettings.MillimetersPerMillivolt = 20;
            else if (sender == gain40mmToolStripMenuItem)
                EcgRenderingSettings.MillimetersPerMillivolt = 40;
            EcgRenderingSettings.EndInit();
        }

        /// <summary>
        /// Handles the Click event of gridTypeToolStripMenuItem object.
        /// </summary>
        private void gridTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcgRenderingSettings.BeginInit();
            if (sender == gridTypeNoneToolStripMenuItem)
            {
                EcgRenderingSettings.MinorGridThickness = 0;
                EcgRenderingSettings.MajorGridThickness = 0;
            }
            else if (sender == gridType1mmToolStripMenuItem)
            {
                EcgRenderingSettings.MinorGridThickness = 0.5f;
                EcgRenderingSettings.MajorGridThickness = 1;
            }
            else if (sender == gridType5mmToolStripMenuItem)
            {
                EcgRenderingSettings.MinorGridThickness = 0;
                EcgRenderingSettings.MajorGridThickness = 1;
            }
            EcgRenderingSettings.EndInit();
        }

        /// <summary>
        /// Handles the Click event of colorToolStripMenuItem object.
        /// </summary>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorRedBlackToolStripMenuItem.Checked = false;
            colorBlueBlackToolStripMenuItem.Checked = false;
            colorGreenBlackToolStripMenuItem.Checked = false;
            colorGrayGreenToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;

            EcgRenderingSettings.BeginInit();
            EcgVisualTool visualTool = (EcgVisualTool)imageViewer1.VisualTool;
            if (sender == colorRedBlackToolStripMenuItem)
            {
                imageViewer1.BackColor = Color.White;
                EcgRenderingSettings.BackgroundColor = Color.White;
                EcgRenderingSettings.MajorGridColor = Color.FromArgb(255, 187, 187);
                EcgRenderingSettings.MinorGridColor = Color.FromArgb(255, 229, 229);
                EcgRenderingSettings.SignalColor = Color.Black;
                EcgRenderingSettings.LegendFontColor = Color.Black;
                visualTool.SelectionPen = Pens.Black;
            }
            else if (sender == colorBlueBlackToolStripMenuItem)
            {
                imageViewer1.BackColor = Color.White;
                EcgRenderingSettings.BackgroundColor = Color.White;
                EcgRenderingSettings.MajorGridColor = Color.FromArgb(187, 187, 255);
                EcgRenderingSettings.MinorGridColor = Color.FromArgb(229, 229, 255);
                EcgRenderingSettings.SignalColor = Color.Black;
                EcgRenderingSettings.LegendFontColor = Color.Black;
                visualTool.SelectionPen = Pens.Black;
            }
            else if (sender == colorGreenBlackToolStripMenuItem)
            {
                imageViewer1.BackColor = Color.White;
                EcgRenderingSettings.BackgroundColor = Color.White;
                EcgRenderingSettings.MajorGridColor = Color.FromArgb(28, 255, 28);
                EcgRenderingSettings.MinorGridColor = Color.FromArgb(204, 255, 204);
                EcgRenderingSettings.SignalColor = Color.Black;
                EcgRenderingSettings.LegendFontColor = Color.Black;
                visualTool.SelectionPen = Pens.Black;
            }
            else if (sender == colorGrayGreenToolStripMenuItem)
            {
                imageViewer1.BackColor = Color.Black;
                EcgRenderingSettings.BackgroundColor = Color.Black;
                EcgRenderingSettings.MajorGridColor = Color.Gray;
                EcgRenderingSettings.MinorGridColor = Color.FromArgb(96, 96, 96);
                EcgRenderingSettings.SignalColor = Color.Lime;
                EcgRenderingSettings.LegendFontColor = Color.Lime;
                visualTool.SelectionPen = Pens.Lime;
            }
            EcgRenderingSettings.EndInit();
        }

        /// <summary>
        /// Handles the Click event of caliperToolStripMenuItem object.
        /// </summary>
        private void caliperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcgVisualTool visualTool = (EcgVisualTool)imageViewer1.VisualTool;

            if (sender == caliperOffToolStripMenuItem)
            {
                visualTool.Enabled = false;
            }
            else if (sender == caliperDurationToolStripMenuItem)
            {
                visualTool.Enabled = true;
                visualTool.InterationMode = EcgInterationMode.Duration;
            }
            else if (sender == caliperDurationAndMVToolStripMenuItem)
            {
                visualTool.Enabled = true;
                visualTool.InterationMode = EcgInterationMode.DurationAndVoltage;
            }
            InvokeUpdateUI();
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        #region Visual Tools

        /// <summary>
        /// Handles the SelectionChanged event of VisualTool object.
        /// </summary>
        private void VisualTool_SelectionChanged(object sender, PropertyChangedEventArgs<Vintasoft.Primitives.VintasoftRect> e)
        {
            if (e.NewValue.Width != 0 || e.NewValue.Height != 0)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendFormat("{0:F0} ms", e.NewValue.Width * 1000);

                if (e.NewValue.Height != 0)
                    stringBuilder.AppendFormat(", {0:F0} μV", e.NewValue.Height * 1000);

                ecgVisualToolSelectionLabel.Text = stringBuilder.ToString();
            }
            else
            {
                ecgVisualToolSelectionLabel.Text = string.Empty;
            }
        }

        #endregion


        /// <summary>
        /// Handles the Changed event of ImageRenderingSettings object.
        /// </summary>
        private void ImageRenderingSettings_Changed(object sender, EventArgs e)
        {
            InvokeUpdateUI();
        }

        /// <summary>
        /// Handles the FocusedIndexChanged event of ImageViewer1 object.
        /// </summary>
        private void ImageViewer1_FocusedIndexChanged(object sender, Vintasoft.Imaging.UI.FocusedIndexChangedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            if (imageViewer1.Image != null)
            {
                PageMetadata pageMetadata = imageViewer1.Image.Metadata.MetadataTree;

                AppendMetadataNodeValue(builder, pageMetadata, "Study Date", "Study Date");
                AppendMetadataNodeValue(builder, pageMetadata, "Study Time", "Study Time");
                builder.AppendLine();
                AppendMetadataNodeValue(builder, pageMetadata, "Patient Name", "Patient's Name");
                AppendMetadataNodeValue(builder, pageMetadata, "Patient ID", "Patient ID");
                AppendMetadataNodeValue(builder, pageMetadata, "Patient Birth Date", "Patient's Birth Date");
                AppendMetadataNodeValue(builder, pageMetadata, "Patient Age", "Patient's Age");
                AppendMetadataNodeValue(builder, pageMetadata, "Patient Gender", "Patient's Sex");
            }

            fileMetadataTextBox.Text = builder.ToString();
        }

        /// <summary>
        /// Appends the metadata node value to specified string builder.
        /// </summary>
        /// <param name="builder">The string builder.</param>
        /// <param name="pageMetadata">The page metadata.</param>
        /// <param name="nodeDescription">The metadata node description.</param>
        /// <param name="nodeName">The metadata node name.</param>
        private void AppendMetadataNodeValue(
            StringBuilder builder,
            PageMetadata pageMetadata,
            string nodeDescription,
            string nodeName)
        {
            // find the metadata node
            MetadataNode node = pageMetadata.FindChildNode<MetadataNode>(nodeName);

            // if metadata node has value
            if (node != null && node.Value != null)
            {
                // add description
                builder.Append(nodeDescription);
                builder.Append(":");
                if (nodeDescription.Length < 24)
                    builder.Append(new string(' ', 24 - nodeDescription.Length));

                // if metadata node contains date time
                if (node.Value is DateTime)
                    builder.Append(((DateTime)node.Value).ToShortDateString());
                else
                    builder.Append(node.Value.ToString());

                builder.AppendLine();
            }
        }

        #endregion

        #endregion



        #region Delegates

        /// <summary>
        /// Represents the <see cref="UpdateUI"/> method.
        /// </summary>
        delegate void UpdateUIDelegate();

        #endregion

    }
}
