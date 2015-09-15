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
using System.Threading;

namespace JustCCP_part_1_view
{
    public partial class JustCCP : Form
    {
        string fileName = "";
        string sourceFile = "";
        string destinationPath = "";/**/
        string cutDestinationPath = "";/**/
        string destinationFile = "";
        List<string> filelist;/**/
        List<string> cutFileList;/**/
        byte[] buffer;
        Copy copy;
        ManualResetEvent mrse;/**/
        ManualResetEvent cutMRSE;/**/
        Thread csbt;
        Thread copyThread;/**/
        Thread cutThread;/**/
        int lastval = 0;
        bool skip = false;/**/
        bool cutSkip = false;/**/
        bool quit = false;
        List<string> skipList;/**/
        List<string> cutSkipList;/**/


        public JustCCP()
        {
            InitializeComponent();
            filelist = new List<string>();
            buffer = new byte[1024*1024*2];
            copy = new Copy();
            mrse = new ManualResetEvent(true);
            cutMRSE = new ManualResetEvent(true);
            csbt = new Thread(sourceButtonMethod);
            skipList = new List<string>();
            cutFileList = new List<string>();
            cutSkipList = new List<string>();
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

        //copy source button
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

        //sourece button method
        public void sourceButtonMethod() {
            
        }

        //copy's designation button
        private void destinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                destinationPath = fbd.SelectedPath;
                copy.setDestinationPath(destinationPath);
            }   
        }

        /*Present file progress bar thread control value*/
        delegate void SetValue(int val);

        private void SetPresentProgressBarValue(int val)
        {
            if (this.presentprogressBar.InvokeRequired)
            {
                SetValue s = new SetValue(SetPresentProgressBarValue);
                this.Invoke(s, new object[] { val });
            }
            else 
            {
                this.presentprogressBar.Value = val;
            }
        }

        /*Total file progress bar thread control value*/
        delegate void SetValue2(int val);

        private void SetTotalProgressBarValue(int val) 
        {
            if (this.totalProgressBar.InvokeRequired)
            {
                SetValue2 s = new SetValue2(SetTotalProgressBarValue);
                this.Invoke(s, new object[] { val });
            }
            else
            {
                this.totalProgressBar.Value = val;
            }
        }

        private void copyMethod()
        {
            try
            {
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
                SetTotalProgressBarValue(0);

                for (int i = 0; i < filelist.Count; i++)
                {
                    sourceFile = filelist[i];
                    fileName = copy.extractFileName(sourceFile);
                    extractedSourcePath = copy.extractSourcePath(sourceFile, fileName);
                    SetPresentProgressBarValue(0);

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
                           
                            mrse.WaitOne();
                            Thread.Sleep(50);
                            totalByte += currentBlockSize;
                            percentage = (double)totalByte * 100 / fileLength;
                            destination.Write(buffer, 0, buffer.Length);
                            //presentprogressBar.Value = (int)percentage;
                            SetPresentProgressBarValue((int)percentage);

                            presentlyCopied += currentBlockSize;
                            percentage = (double)presentlyCopied * 100 / totalFileSize;
                            //totalProgressBar.Value = (int)percentage;
                            SetTotalProgressBarValue((int)percentage);
                            lastval = (int)percentage;
                            if(skip){
                                skipList.Add(destinationFile);
                                skip = false;
                                break;
                            }
                            if(quit){
                                break;
                            }
                        }
                        

                        SetTotalProgressBarValue(lastval);
                        totalByte = 0;
                        currentBlockSize = 0;
                        percentage = 0;

                        SetPresentProgressBarValue(0);
                        source.Close();//source stream close
                        destination.Close();//as well as destination stream close
                    }
                    if(quit){
                        break;
                    }
                    
                }

                for (int i = 0; i<skipList.Count;i++ )
                {
                    File.Delete(skipList[i]);
                }

                skipList.Clear();
                SetTotalProgressBarValue(0);

                if(lastval<100){
                    SetTotalProgressBarValue(100);

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
                //copyThread.Join();
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (copyThread == null)
            {
                copyThread = new Thread(copyMethod);
                copyThread.Start();
                
            }
            else 
            {
                //I think I don't need that but still for safty 
                if (copyThread.IsAlive)
                {
                    copyThread.Abort();
                    copyThread.Join();
                    MessageBox.Show("ended");
                    copyThread = new Thread(copyMethod);
                    copyThread.Start();
                    
                }
                else
                {
                    copyThread = new Thread(copyMethod);
                    copyThread.Start();
                    
                }
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
            try {
                quit = true;
                this.Close();
                //this.Dispose();
            }catch(Exception exp){
                //MessageBox.Show(exp.Message.ToString());
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            skip = true;
        }

        //copy resume button
        private void pauseButton_Click(object sender, EventArgs e)
        {
            if(pauseButton.Text == "Pause"){
               pauseButton.Text = "Resume"; 
               pauseButton.Width = 93;
               pauseButton.ImageIndex = 8;
               mrse.Reset();
            }else if(pauseButton.Text == "Resume"){
                pauseButton.Text = "Pause";
                pauseButton.Width = 80;
                pauseButton.ImageIndex = 0;
                mrse.Set();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //cut pause button
        private void buttonPause_Click(object sender, EventArgs e)
        {
           if (cutPauseButton.Text == "Pause")
            {
                cutPauseButton.Text = "Resume";
                cutPauseButton.Width = 93;
                cutPauseButton.ImageIndex = 8;
                cutMRSE.Reset();//
            }
            else if (cutPauseButton.Text == "Resume")
            {
                cutPauseButton.Text = "Pause";
                cutPauseButton.Width = 80;
                cutPauseButton.ImageIndex = 0;
                cutMRSE.Set();//
            }
        }

        //Form load event
        private void JustCCP_Load(object sender, EventArgs e)
        {
            
        }


        /*Present file progress bar thread control value*/
        delegate void SetValue3(int val);

        private void SetCutPresentProgressBarValue(int val)
        {
            if (this.presentprogressBar.InvokeRequired)
            {
                SetValue3 s = new SetValue3(SetCutPresentProgressBarValue);
                this.Invoke(s, new object[] { val });
            }
            else
            {
                this.cutPresentProgressBar.Value = val;
            }
        }

        /*Total file progress bar thread control value*/
        delegate void SetValue4(int val);

        private void SetCutTotalProgressBarValue(int val)
        {
            if (this.totalProgressBar.InvokeRequired)
            {
                SetValue4 s = new SetValue4(SetCutTotalProgressBarValue);
                this.Invoke(s, new object[] { val });
            }
            else
            {
                this.cutTotalProgressBar.Value = val;
            }
        }


        //This method calculate total filesize
        public long totalFileSizeMethod()
        {
            string file;
            long total = 0;
            try
            {
                for (int i = 0; i < cutFileList.Count; i++)
                {
                    file = cutFileList[i];
                    FileStream read = new FileStream(file, FileMode.Open, FileAccess.Read);
                    total += read.Length;
                    read.Close();
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
            }
            return total;
        }

        /*This is our cut method*/
        private void cutMethod()
        {
            try
            {
                string sourceFile = "";
                string fileName = "";
                string extractedSourcePath = "";
                long fileLength = 0;
                long currentBlockSize = 0;
                long totalByte = 0;
                double percentage = 0;
                long totalFileSize = 0;
                long presentlyCopied = 0;

                totalFileSize = totalFileSizeMethod();//
                SetCutTotalProgressBarValue(0);//

                for (int i = 0; i < cutFileList.Count; i++)
                {
                    sourceFile = cutFileList[i];//
                    fileName = copy.extractFileName(sourceFile);
                    extractedSourcePath = copy.extractSourcePath(sourceFile, fileName);
                    SetCutPresentProgressBarValue(0);//
                    //MessageBox.Show("Source File = "+sourceFile);
                    //MessageBox.Show("filename = " + fileName);
                    //MessageBox.Show("extracted source path = " + extractedSourcePath);


                    if (Directory.Exists(cutDestinationPath) && Directory.Exists(extractedSourcePath))
                    {
                        //copy machanism
                        destinationFile = Path.Combine(cutDestinationPath, fileName);//
                        //MessageBox.Show("destination file = " + destinationFile);

                        //opening the file in stream
                        FileStream source = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                        fileLength = source.Length;
                        FileStream destination = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write);

                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {

                            cutMRSE.WaitOne();//
                            Thread.Sleep(50);
                            totalByte += currentBlockSize;
                            percentage = (double)totalByte * 100 / fileLength;
                            destination.Write(buffer, 0, buffer.Length);
                            //presentprogressBar.Value = (int)percentage;
                            SetCutPresentProgressBarValue((int)percentage);//

                            presentlyCopied += currentBlockSize;
                            percentage = (double)presentlyCopied * 100 / totalFileSize;
                            //totalProgressBar.Value = (int)percentage;
                            SetCutTotalProgressBarValue((int)percentage);//
                            lastval = (int)percentage;
                            if (cutSkip)
                            {
                                cutSkipList.Add(destinationFile);//
                                cutSkip = false;//
                                break;
                            }
                            if (quit)
                            {
                                break;
                            }
                        }


                        

                        SetCutTotalProgressBarValue(0);//
                        totalByte = 0;
                        currentBlockSize = 0;
                        percentage = 0;

                        SetCutPresentProgressBarValue(0);//
                        source.Close();//source stream close
                        destination.Close();//as well as destination stream close

                        //cut section
                        File.Delete(cutFileList[i]);
                    }
                    if (quit)
                    {
                        break;
                    }

                }
                SetCutTotalProgressBarValue(0);//

                for (int i = 0; i < cutSkipList.Count; i++)//
                {
                    File.Delete(cutSkipList[i]);//
                }

                //cut section
                for (int i = 0; i<cutFileList.Count;i++ )
                {
                    
                }

                cutSkipList.Clear();//

                if (lastval < 100)
                {
                    SetCutTotalProgressBarValue(100);//
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }


        //cut button
        private void cutButton_Click(object sender, EventArgs e)
        {
            if (cutThread == null)
            {
                cutThread = new Thread(cutMethod);
                cutThread.Start();
            }
            else
            {
                //I think I don't need that but still for safty 
                if (cutThread.IsAlive)
                {
                    cutThread.Abort();
                    cutThread.Join();
                    MessageBox.Show("ended");
                    cutThread = new Thread(copyMethod);
                    cutThread.Start();
                }
                else
                {
                    cutThread = new Thread(copyMethod);
                    cutThread.Start();
                }
            }
        }

        //cut skip button
        private void cutSkipButton_Click(object sender, EventArgs e)
        {
            cutSkip = true;
        }

        //cut quit button
        private void cutQuitButton_Click(object sender, EventArgs e)
        {
            try
            {
                quit = true;
                this.Close();
                //this.Dispose();
            }
            catch (Exception exp)
            {
                //MessageBox.Show(exp.Message.ToString());
            }
        }

        //cut source button
        private void cutSourceButton_Click(object sender, EventArgs e)
        {
            //clearing the previous source file list
            cutFileList.Clear();
            copy.setFileList(cutFileList);

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileName = openFile.FileNames;
                for (int i = 0; i < fileName.Length; i++)
                {
                    cutFileList.Add(fileName[i]);
                }
                //copy.setFileList(cutFileList);
            }
        }

        //cut destination button
        private void cutDestinationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cutDestinationPath = fbd.SelectedPath;
                //copy.setDestinationPath(destinationPath);
            }   
        }

        private void cutQuitButton_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void JustCCP_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.Control && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("key pressed");
            }*/
        }

        private void JustCCP_Load_1(object sender, EventArgs e)
        {

        }

        private void JustCCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
