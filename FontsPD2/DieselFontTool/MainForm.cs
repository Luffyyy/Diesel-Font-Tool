using DieselEngineFormats.Font;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DieselFontTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DieselFont currentFont;
        string fontName;

        private void LoadFont_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "BM Font(*.fnt)|*.fnt|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Parse;
                fontName = ofd.FileName.Replace(".fnt", "");
                using (var xmlRead = XmlReader.Create(ofd.FileName, settings))
                    currentFont = new DieselFont(xmlRead);

                SaveFont.Enabled = true;
            }
        }

        private void SaveFont_Click(object sender, EventArgs e)
        {
            if (currentFont != null)
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "Disel Font(*.font)|*.font|All files(*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                    using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        currentFont.WriteDieselData(new BinaryWriter(fs), largeModeCheckBox.Checked);
                        string textureName = fontName+"_0.dds";
                        if (File.Exists(textureName))
                            File.Move(textureName, sfd.FileName.Replace(".font", "")+".texture");
                    }
            }
        }
    }
}
