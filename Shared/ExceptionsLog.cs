using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Shared
{
    public class ExceptionsLog
    {
        public void SaveExceptionLogs(Exception ex)
        {
            using (StreamWriter file = File.CreateText($"{AppDomain.CurrentDomain.BaseDirectory}\\itemsLog.txt"))
            {
                file.WriteLine(ex.InnerException);
            }
        }
    }
}
