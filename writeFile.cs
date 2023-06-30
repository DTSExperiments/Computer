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
            try
            {
                await writeStream.WriteLineAsync(valueAppend);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Value not written: {ex.Message}");
            }
        }

        public void closeFile()
        {
            writeStream.Close();
        }
    }
}
