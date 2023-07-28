using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plotBrembs
{
    internal class writeFile
    {
        private readonly object _lockObj = new object();
        StreamWriter writeStream = null;

        public writeFile()
        {
            try
            {
                writeStream = new StreamWriter("log.csv");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"File not open: {ex.Message}");
            }
        }

        public async Task writeValue(string valueAppend)
        {
            lock (_lockObj)
            {
                try
                {
                    writeStream.WriteLine(valueAppend);  // Changed to synchronous call inside lock
                    writeStream.Flush();  // Ensure that the data is written immediately
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Value not written: {ex.Message}");
                }
            }
        }

        public void closeFile()
        {
            writeStream.Close();
        }
    }
}

