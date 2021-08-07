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

namespace TheCorridorSaveEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string file = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "/TheCorridor/Saved/SaveGames/LevelSaveSlot.sav";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0x00; i <= 0x25; i++)
            {
                if ((i + 1) == 5)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [Reverse Psychology]");
                }else if ((i + 1) == 6)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [The Corner]");
                }else if ((i + 1) == 7)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [Why’d You Do It?]");
                }else if ((i + 1) == 10)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [Doctor Who?]");
                }else if ((i + 1) == 12)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [Well Done On Not Shooting That Guy]");
                }else if ((i + 1) == 28)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [Good Listener]");
                }else if ((i + 1) == 36)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [The Fox’s Lament]");
                }
                else if ((i + 1) == 38)
                {
                    listBox1.Items.Add("Level " + (i + 1) + " [One Last Thing]");
                }
                else
                {
                    listBox1.Items.Add("Level " + (i + 1));
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(file));
            bw.BaseStream.Position = 0x3c4;
            bw.Write(listBox1.SelectedIndex);
            bw.Close();
        }
    }
}
