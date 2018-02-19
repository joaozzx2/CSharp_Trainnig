using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Banco
{
    public class logger
    {


        public String Info;

        public void Main()
        {

            


            string appPath = Path.GetDirectoryName(Application.ExecutablePath);


            
            //
            //Cria uma nova linha no log.txt
            // 

            
            using (StreamWriter writer =
                new StreamWriter(@"" + appPath + "/DATA_Banco/Log.txt", true))

            {
                writer.WriteLine("---" + Info);
            }
        }
    }
}