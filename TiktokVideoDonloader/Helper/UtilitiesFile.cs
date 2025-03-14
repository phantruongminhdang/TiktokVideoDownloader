using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Helper
{
    public static class UtilitiesFile
    {
        public static void WriteLine(this List<string> theList, string nameFile)
        {
            //string output = string.Join(Environment.NewLine, list.ToArray());
            System.IO.File.WriteAllLines(nameFile, theList);
        }

        public static void WriteLines(string content, string nameFile, string LocationPath = null)
        {
            string pathName = LocationPath + "\\" + nameFile;
            try
            {
                using (System.IO.StreamWriter sw = new StreamWriter(pathName, true))
                {
                    sw.WriteLine(content + Environment.NewLine);
                }
            }
            catch
            {

            }
        }

        public static ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim();
        public static void WriteToFileThreadSafe(string text, string path)
        {
            //set Status to Locked
            _readerWriterLock.EnterReadLock();
            try
            {
                //append text to the file
                using (StreamWriter sw = System.IO.File.AppendText(path))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
            }
            finally
            {
                //release lock 
                _readerWriterLock?.ExitReadLock();
            }
        }
    }
}
