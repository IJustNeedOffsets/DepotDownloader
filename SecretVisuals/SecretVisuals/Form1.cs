using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace SecretVisuals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try to launch the downgraded game first before downloading language. Just close the command promt to not download it");
            System.Diagnostics.Process.Start("https://github.com/IJustNeedOffsets/Nsuns4howModding");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "lang4.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newFrm = new Form2();
            newFrm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 newFrm = new Form2();
            newFrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
