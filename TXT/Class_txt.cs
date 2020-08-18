using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SuperJet_3._1
{
    class read_write_txt
    {
        string filename = Application.StartupPath + "//test.txt";
        public read_write_txt(string t_box1, string t_box2)
        {
            

            if (File.Exists(filename) != true) //если файла нет - создаем и записываем
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write)))
                {
                    sw.WriteLine("УНН - " + t_box1 + " / Табельный номер - " + t_box2);  //Записываем данные УНН и табельный номер
                }       
            }
            else //если файл есть, то откываем его читаем и записываем
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(filename, FileMode.Open, FileAccess.Write)))
                {
                 (sw.BaseStream).Seek(0, SeekOrigin.End);         //дописываем в файл
                 sw.WriteLine("УНН - " + t_box1 + " / Табельный номер - " + t_box2);
                }
                  
            }
        }
        
    }
}
