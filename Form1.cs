using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinPlus
{
    public partial class Form1 : Form
    {
        // UI Message
        Guna.UI2.WinForms.Guna2MessageDialog msg = new Guna.UI2.WinForms.Guna2MessageDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2CheckBox1.Checked)
                {
                    Process.Start(@"C:\Program Files\Epic Games\GenshinImpact\Genshin Impact game\GenshinImpact.exe");
                }
                else if (guna2CheckBox2.Checked)
                {
                    Process.Start(@"C:\Program Files\Genshin Impact\Genshin Impact game\GenshinImpact.exe");
                }
            }
            catch
            {
                msg.Caption = "Error:";
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Text = "Error Code: Slec";
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
                msg.Show();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] workers = Process.GetProcessesByName("GenshinImpact");
                foreach (Process worker in workers)
                {
                    worker.Kill();
                    worker.WaitForExit();
                    worker.Dispose();
                };
            }
            catch
            {
                msg.Caption = "Error:";
                msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                msg.Text = "Error Code: Paimon";
                msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
                msg.Show();
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2CheckBox2.Checked = false;
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                guna2CheckBox1.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
