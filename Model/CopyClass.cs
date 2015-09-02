using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    public class CopyClass
    {
        private string sourceFile;
        private string destinationFile;
        private long fileLength;
        private FileStream source;
        private FileStream destination;

        public CopyClass() { 
        
        }

        public void setSourceFile(string sourceFile) {
            this.sourceFile = sourceFile;
        }

        public void setDestinationFile(string destinationFile) {
            this.destinationFile = destinationFile;
        }

        public void copy() {
            source = new FileStream(sourceFile,FileMode.Open,FileAccess.Read);
            destination = new FileStream(destinationFile,FileMode.CreateNew,FileAccess.Write);
            fileLength = source.Length;



        }
    }
}
