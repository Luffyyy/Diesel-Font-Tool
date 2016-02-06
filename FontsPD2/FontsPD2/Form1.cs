using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
 
namespace FontsPD2
{
    public partial class FontsPD2 : Form
    {
        public FontsPD2()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        int characters;
        int part2 = 92; //Always 92Bits.
        int part3; 
        int part4;
        int part5;
        byte[] TexWidth;
        byte[] TexHeight;
        List<byte> part1array;
        List<byte> part2array;
        List<byte> part3array;
        List<byte> part4array;
        byte[] part5array;
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Payday 2 font file(*.font)|*.font*|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) {
                try{
                    LoadFont(ofd.FileName);
                 }
                 catch(Exception ex) { MessageBox.Show("an error occurred while loading the font file.. \r\n" + ex); }    
            }
        }
        void LoadFont(string FileName) {
            Loadbtn.Enabled = true;
            Text = ofd.SafeFileName;
            FileStream fs = File.OpenRead(FileName);
            BinaryReader bin = new BinaryReader(fs);

            bin.BaseStream.Position = 28;
            part3 = bin.ReadInt16();

            bin.BaseStream.Position = 52;
            part4 = bin.ReadInt16();

            bin.BaseStream.Position = 68;
            part5 = bin.ReadInt16();

            bin.BaseStream.Position = 76;
            TexWidth = bin.ReadBytes(4);

            bin.BaseStream.Position = 80;
            TexHeight = bin.ReadBytes(4);

            bin.BaseStream.Position = 0;
            part1array = bin.ReadBytes(part2).ToList();
            characters = part1array[0];

            bin.BaseStream.Position = part2;
            part2array = bin.ReadBytes(part3).ToList();

            bin.BaseStream.Position = part3;
            part3array = bin.ReadBytes(part4).ToList();

            bin.BaseStream.Position = part4;
            part4array = bin.ReadBytes(part5).ToList();

            bin.BaseStream.Position = part5;
            part5array = bin.ReadBytes((int)bin.BaseStream.Length);

            bin.Close();
            fs.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {                
                File.WriteAllText(ofd.FileName, "");
                FileStream fs = File.OpenWrite(ofd.FileName);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.BaseStream.Position = 0;
                bw.Write(part1array.ToArray());
                bw.BaseStream.Position = 76;
                bw.Write(TexWidth.ToArray());
                bw.BaseStream.Position = 80;                       
                bw.Write(TexHeight.ToArray());
                bw.BaseStream.Position = part2;
                bw.Write(part2array.ToArray());         
                bw.BaseStream.Position = part3;                
                bw.Write(part3array.ToArray());
                bw.BaseStream.Position = part4;
                bw.Write(part4array.ToArray());
                bw.BaseStream.Position = part5;
                bw.Write(part5array);
                bw.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Filter = "BM Font file(*.fnt)|*.fnt*|All files (*.*)|*.*";
            part3array.Clear();
            part2array.Clear();
            try
            {
                if (ofd2.ShowDialog() == DialogResult.OK)
                {
                    Savebtn.Enabled = true;
                    int i = 0;
                    XmlReader reader = XmlReader.Create(ofd2.FileName);
                    while (reader.Read()) {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "common") {
                            TexWidth = BitConverter.GetBytes(int.Parse(reader.GetAttribute("scaleW")));
                            TexHeight = BitConverter.GetBytes(int.Parse(reader.GetAttribute("scaleH")));
                        }
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "chars")
                        {
                            for (int v = 0; v < part1array.Count; v++)
                            {
                                if (part1array[v] == characters) {
                                    int count = int.Parse(reader.GetAttribute("count"));
                                    part1array[v] = (byte)(count & 0xff);
                                    part1array[v + 1] = (byte)((count >> 8) & 0xff);
                                }
                            }
                            characters = int.Parse(reader.GetAttribute("count"));
                        }
                        if (reader.Name == "char") {
                            part2array.Add(0);
                            part2array.Add(byte.Parse(reader.GetAttribute("width")));
                            part2array.Add(byte.Parse(reader.GetAttribute("height")));
                            part2array.Add(byte.Parse(reader.GetAttribute("xadvance")));
                            part2array.Add((byte)(sbyte)int.Parse(reader.GetAttribute("xoffset")));
                            part2array.Add(byte.Parse(reader.GetAttribute("yoffset")));
                            int x = int.Parse(reader.GetAttribute("x"));
                            int y = int.Parse(reader.GetAttribute("y"));
                            part2array.Add((byte)(x & 0xff));
                            part2array.Add((byte)((x >> 8) & 0xff));

                            part2array.Add((byte)(y & 0xff));
                            part2array.Add((byte)((y >> 8) & 0xff));
                            int character = int.Parse(reader.GetAttribute("id"));

                            part3array.Add((byte)(character & 0xff));
                            part3array.Add((byte)((character >> 8) & 0xff));
                            part3array.Add(0);
                            part3array.Add(0);
                            part3array.Add((byte)(i & 0xff));
                            part3array.Add((byte)((i >> 8) & 0xff));
                            part3array.Add(0);
                            part3array.Add(0);

                            i++;
                        }
                    }
                    part3 = part2 + part2array.Count;
                    part4 = part3 + part3array.Count;
                    part5 = part4 + part4array.Count;
                    part1array[28] = (byte)(part3 & 0xff);
                    part1array[29] = (byte)((part3 >> 8) & 0xff);

                    part1array[52] = (byte)(part4 & 0xff);
                    part1array[53] = (byte)((part4 >> 8) & 0xff);

                    part1array[68] = (byte)(part5 & 0xff);
                    part1array[69] = (byte)((part5 >> 8) & 0xff);
                    reader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("an error occurred while loading the fnt file.. \r\n" + ex ); }

        }

        private void FontsPD2_Load(object sender, EventArgs e)
        {

        }
    }
}
