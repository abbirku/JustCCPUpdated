using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using CCPLibrary;

namespace JustCCP_part_1_view
{
    public partial class JustCCP : Form
    {
        string fileName = "";
        string sourceFile = "";
        string destinationPath = "";
        string destinationFile = "";
        List<string> filelist;/**/
        byte[] buffer;/**/
        Copy copy;

        public JustCCP()
        {
            InitializeComponent();
            filelist = new List<string>();
            buffer = new byte[1024*1024*1];
            copy = new Copy();
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void copyPage_Click(object sender, EventArgs e)
        {

        }

        private void sourceButton_Click(object sender, EventArgs e)
        {
            //clearing the previous source file list
            filelist.Clear();
            copy.setFileList(filelist);

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileName = openFile.FileNames;
                for (int i = 0; i < fileName.Length; i++)
                {
                    filelist.Add(fileName[i]);
                }
                copy.setFileList(filelist);
            }
        }

        private void destinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destinationPath = fbd.SelectedPath;
                copy.setDestinationPath(destinationPath);
            }
            
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try {
                string sourceFile = "";
                string fileName = "";
                string extractedSourcePath = "";
                long fileLength = 0;
                long currentBlockSize = 0;
                long totalByte = 0;
                double percentage = 0;
                long totalFileSize = 0;
                long presentlyCopied = 0;

                totalFileSize = copy.totalFileSizeMethod();
                

                for (int i = 0; i < filelist.Count; i++)
                {
                    sourceFile = filelist[i];
                    //MessageBox.Show("Source Path = "+sourceFile);
                    fileName = copy.extractFileName(sourceFile);
                    //MessageBox.Show("File name = "+fileName);
                    extractedSourcePath = copy.extractSourcePath(sourceFile, fileName);
                    //MessageBox.Show("Extracted path from source path "+extractedSourcePath);

                    if (Directory.Exists(destinationPath) && Directory.Exists(extractedSourcePath))
                    {
                        //copy machanism
                        destinationFile = Path.Combine(destinationPath, fileName);

                        //opening the file in stream
                        FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                        fileLength = source.Length;
                        FileStream destination = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write);

                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalByte += currentBlockSize;
                            percentage = (double)totalByte * 100 / fileLength;
                            destination.Write(buffer, 0, buffer.Length);
                            presentprogressBar.Value = (int)percentage;

                            presentlyCopied += currentBlockSize;
                            percentage = (double)presentlyCopied * 100 / totalFileSize;
                            totalProgressBar.Value = (int)percentage;
                        }

                        totalByte = 0;
                        currentBlockSize = 0;
                        percentage = 0;

                        presentprogressBar.Value = 0;
                        destination.Close();
                    }
                }
            }catch(Exception exp){
                MessageBox.Show(exp.Message.ToString());
            }

            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aboutPage_Click(object sender, EventArgs e)
        {

        }

        private void cutPage_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void presentprogressBar_Click(object sender, EventArgs e)
        {

        }

        private void totalProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {

        }

        private void skipButton_Click(object sender, EventArgs e)
        {

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
