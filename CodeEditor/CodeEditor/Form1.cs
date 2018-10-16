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


namespace CodeEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichTextbox.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "My open file dialogue";
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                txtRichTextbox.Clear();
                using (StreamReader sr = new StreamReader(openfile.FileName))
                {
                    txtRichTextbox.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file as...";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtOutput = new StreamWriter(saveFile.FileName);
                txtOutput.Write(txtRichTextbox.Text);
                txtOutput.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichTextbox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichTextbox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            txtRichTextbox.Paste();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtRichTextbox.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            txtRichTextbox.Redo();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            txtRichTextbox.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUndo.PerformClick();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRedo.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectAllToolStripMenuItem.PerformClick();
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
           
        }
    }
}
