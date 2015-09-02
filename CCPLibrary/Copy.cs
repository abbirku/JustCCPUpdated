using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CCPLibrary
{
    public class Copy
    {
        private List<string> fileList;
        private byte[] buffer;
        private string destinationPath;
        private string sourcePath;
        private string fileName;
        private string error;
        private string destinationFile;
        private string sourceFile;
        private int ppbv;
        private int tpbv;
        private long totalFileSize;
        private long currentBlockSize;
        private long presentlyCopied;
        

        public Copy() {
            fileList = new List<string>();
            buffer = new byte[1024*1024*1];
            error = "";
            totalFileSize = 0;
        }

        public void setFileList(List<string> fileList) {
            this.fileList = fileList;
        }

        public List<string> getFileList() {
            return fileList;
        }

        public void setDestinationPath(string destinationPath) {
            this.destinationPath = destinationPath;
        }

        public string getDestinationPath() {
            return this.destinationPath;
        }

        public void setError() {
            error = "";
        }

        public string getError() {
            return error;
        }

        public void setPresentProgressbarValue() {
            ppbv = 0;
        }

        public int getPresentProgressbarValue() {
            return ppbv;
        }

        public void setTotalProgressbarValue() {
            tpbv = 0;
        }

        public int getTotalProgressbarValue() {
            return tpbv;
        }

        public string getVAR() {
            return destinationPath;
        }


        //This method calculate total filesize
        public long totalFileSizeMethod() {
            string file;
            long total = 0;
            try {
                for (int i = 0; i<fileList.Count;i++ )
                {
                    file = fileList[i];
                    FileStream read = new FileStream(file,FileMode.Open,FileAccess.Read);
                    total += read.Length;
                }
                totalFileSize = total;
            }catch(Exception exe){
                error = exe.Message.ToString();
            }
            return totalFileSize;
        }

        //this method extract file name from source path
        public string extractFileName(string sourcePath)
        {
            string test = "";
            try {
                //making an array from its path
                char[] arr = new char[sourcePath.Length];

                //this converts the string to character array
                StringReader sr = new StringReader(sourcePath);
                sr.Read(arr,0,sourcePath.Length);

                //this loop extract the specific file name from the filelist
                for (int i = 0; i<arr.Length;i++ )
                {
                    if(arr[i].Equals('\\')){
                        test = "";
                    }else{
                        test += arr[i].ToString();
                    }
                }
            }catch(Exception exp){
                error = exp.Message.ToString();
            }
            return test;
        }

        //this method extract the file path from source path
        public string extractSourcePath(string sourceFile,string fileName) {
            string source = "";
            try {
                //making an array from its path
                char[] arr2 = new char[sourceFile.Length-(fileName.Length+1)];

                //this converts the string to character array
                StringReader sr2 = new StringReader(sourceFile);
                sr2.Read(arr2, 0, sourceFile.Length - (fileName.Length + 1));

                //making the reseltent array
                source = new string(arr2);
                this.sourcePath = source;
            }catch(Exception exp){
                error = exp.Message.ToString();
            }
            return source;
        }

        //one file copy method
        public void copyIt(string fn,string sf) {
            //local variable
            long fileLength = 0;
            currentBlockSize = 0;
            long totalByte = 0;
            double percentage = 0;

            //if the directory exists then copy
            try { 
                if(Directory.Exists(destinationPath)&&Directory.Exists(sourcePath)){
                    //copy machanism
                    destinationFile = Path.Combine(destinationPath,fn);

                    //opening the file in stream
                    FileStream source = new FileStream(sf, FileMode.Open, FileAccess.Read);
                    fileLength = source.Length;
                    FileStream destination = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write);

                    while((currentBlockSize = source.Read(buffer,0,buffer.Length))>0){
                        totalByte += currentBlockSize;
                        percentage = (double)totalByte * 100 / fileLength;
                        destination.Write(buffer,0,buffer.Length);
                        ppbv = (int)percentage;

                        presentlyCopied += currentBlockSize;
                        percentage = (double)presentlyCopied * 100 / totalFileSize;
                        tpbv = (int)percentage;
                    }
                }
            }catch(Exception exe){
                error = exe.Message.ToString();
            }
        }

        //This method copy all the files
        public void mainCopy() {
            totalFileSizeMethod();
            string sourcePath = "";

            try {
                for (int i = 0; i < fileList.Count; i++)
                {
                    sourcePath = fileList[i];
                    extractFileName(sourcePath);
                    //extractSourcePath(sourcePath);
                    //copyIt();
                }
            }catch(Exception exp){
                error = exp.Message.ToString();
            }
        }

    }
}
