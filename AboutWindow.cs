﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using SaberColorfulStartmenu.Properties;

namespace SaberColorfulStartmenu
{
    public partial class AboutWindow : Form
    {
        private static bool functionEnabled = false;
        public AboutWindow()
        {
            InitializeComponent();
            linkLabel5.Enabled = !functionEnabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            textBox1.Text = Resources.About;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "http://hv0905.github.io/saber_startmenu_diyer/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "http://hv0905.github.io/saber_startmenu_diyer/help.html");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "https://github.com/hv0905/SaberColorfulStartmenu/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "http://hv0905.github.io/donate.html");

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This release have not any preview functions.\n Enjoy~","BETA Notice");
        }
    }
}
