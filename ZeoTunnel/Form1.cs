using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ZeoTunnel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void cADToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicObj;
            graphicObj = Form1.ActiveForm.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 1);
            Rectangle Rex;
            Rex = new Rectangle(5,30, 1150, 600);
            graphicObj.DrawRectangle(myPen, Rex);
        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tunnel T1 = new Tunnel(90, .001, 'C', 5, 5);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ins2_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFileDialog.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Ins2.Text = "Done";
            saveFileDialog.FileName = openFileDialog.FileName;
        }

        private void steriographToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
