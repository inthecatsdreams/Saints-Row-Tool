using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XboxCore.Xbox.Connection;
using XRPCLib;
using XDevkit;

namespace Saints_Row_Tool
{
    public partial class Form1 : Form
    {
        XRPC console = new XRPC();
        IXboxConsole xboxConsole;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Waiting";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xboxConsole.Connect(out xboxConsole);
            label1.Text = "Connected to " + xboxConsole.XboxIP();
            if(backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                xboxConsole.WriteBool(0x835F4C3E, true);
            }
            else
            {
                xboxConsole.WriteBool(0x835F4C3E, false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                xboxConsole.WriteFloat(0xC25C7630, 1000000);

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                xboxConsole.WriteBool(0x835F427D, true);
            }
            else
            {
                xboxConsole.WriteBool(0x835F427D, false);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (checkBox3.Checked)
                {
                    xboxConsole.WriteFloat(0xC25C7498, 1000);
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                xboxConsole.WriteFloat(0x827F0BB0, 999999);
        }
    }
}
