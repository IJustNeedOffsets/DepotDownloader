using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace SecretVisuals
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "1724464234984465664.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "6750433627134799326.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "6394046928958434128.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "2080946197622002696.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "3708961971662745218.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "7136833683108324090.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "3345865646373433534.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "3907128157511382322.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "5290046189344876825.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "466904989965013797.bat";
            process.StartInfo.Arguments = "arg1";
            process.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Process.Start("explorer.exe", @"\Desktop");
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MessageBox.Show("You selected: " + dialog.FileName);
            }
            _ = Process.Start("explorer.exe", dialog.FileName);
            System.IO.Directory.GetCurrentDirectory();
            string rootPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            _ = Process.Start("explorer.exe", rootPath);
            MessageBox.Show("Open depots/349041 and than open the folder in there. Delete the orginal game files and paste the downloaded files in there.");

        }
    }
}
