using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LAB4
{
    public class luufile
    {
        public static bool FileLuu(List<String> ds, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach(String s in ds)
                {
                    string line = s;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
