using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab9_4DynamicHTML
{
    class FileWriter
    {
        private string fileNameWithPath;
        private string inputTextData;

        public FileWriter(string fileNameWithPath, string inputTextData)
        {
            this.fileNameWithPath = fileNameWithPath;
            this.inputTextData = inputTextData;
        }

        public void WriteThisFile()
        {
            string fileName = fileNameWithPath;
            string data = inputTextData;
            File.AppendAllText(fileName, data);
        }
    }
}
