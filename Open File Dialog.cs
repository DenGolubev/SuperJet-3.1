using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Diagnostics;

namespace SuperJet_3._1
{
    class Open_File_Dialog
    {
        OpenFileDialog OpFaDi = new OpenFileDialog() 
        {
            FileName = "Select a text file",
            Filter = "Text files (*.txt)|*.txt",
            Title = "Open text file"
        };
        public Open_File_Dialog()
        {
            if (OpFaDi.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = OpFaDi.FileName;
                    using (Stream str = OpFaDi.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }


    }
}
