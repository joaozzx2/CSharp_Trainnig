using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Banco
{
     public class Conta
    {
        public string NumeroConta;
        public string Titular;
        public string Agencia;
        public string Senha;
        public string Saldo;


        string appPath = Path.GetDirectoryName(Application.ExecutablePath);




        public void Transferencia(Double Valor, String Conta, String Conta_to)
        {
            string[] lines = System.IO.File.ReadAllLines(appPath + "/DATA_Banco/" + Conta + ".txt");


            String info = lines[0];
            String Numero_T = lines[1];
            String Titular_T = lines[2];
            String Agencia_T = lines[3];
            String password_T = lines[4];
            String saldo_T = lines[5];

            double sald = Convert.ToDouble(saldo_T);
            

            sald = sald - Valor;


            StreamWriter sw = new StreamWriter(appPath + "/DATA_Banco/" + Conta + ".txt");
            sw.WriteLine(info);
            sw.WriteLine(Numero_T);
            sw.WriteLine(Titular_T);
            sw.WriteLine(Agencia_T);
            sw.WriteLine(password_T);
            sw.WriteLine(sald);
            sw.Close();




            string[] line = System.IO.File.ReadAllLines(appPath + "/DATA_Banco/" + Conta_to + ".txt");
            String info_T2 = line[0];
            String Numero_T2 = line[1];
            String Titular_T2 = line[2];
            String Agencia_T2 = line[3];
            String password_T2 = line[4];
            String saldo_T2 = line[5];

            double sald_T2 = Convert.ToDouble(saldo_T2);
            sald_T2 = sald_T2 + Valor;

            StreamWriter sw2 = new StreamWriter(appPath + "/DATA_Banco/" + Conta_to + ".txt");
            sw2.WriteLine(info);
            sw2.WriteLine(Numero_T2);
            sw2.WriteLine(Titular_T2);
            sw2.WriteLine(Agencia_T2);
            sw2.WriteLine(password_T2);
            sw2.WriteLine(sald_T2);
            sw2.Close();

            logger Log = new logger();
            var data = DateTime.Now;
            Log.Info = (" A conta " + Conta + " transferu " + Valor + " reais " +" para a conta "+ Conta_to + " [" + Convert.ToString(data) + "]");
            Log.Main();








        }

        public void Saque(Double Valor, String Conta)
        {
            string[] lines = System.IO.File.ReadAllLines(appPath + "/DATA_Banco/" + Conta + ".txt");


            String info = lines[0];
            String Numero_S = lines[1];
            String Titular_S = lines[2];
            String Agencia_S = lines[3];
            String password_S = lines[4];
            String saldo_S = lines[5];

            double sald = Convert.ToDouble(saldo_S);

            sald = sald - Valor;

            saldo_S = Convert.ToString(sald);

            StreamWriter sw = new StreamWriter(appPath + "/DATA_Banco/" + Conta + ".txt");
            sw.WriteLine(info);
            sw.WriteLine(Numero_S);
            sw.WriteLine(Titular_S);
            sw.WriteLine(Agencia_S);
            sw.WriteLine(password_S);
            sw.WriteLine(saldo_S);
            sw.Close();

            logger Log = new logger();
            var data = DateTime.Now;
            Log.Info = (" A conta " + Conta + " Sacou " + Valor + " reais " + " [" + Convert.ToString(data) + "]");
            Log.Main();






        }

        public void Deposito(Double Valor, String Conta)
        {
            string[] lines = System.IO.File.ReadAllLines(appPath + "/DATA_Banco/" + Conta + ".txt");


            String info = lines[0];
            String Numero_D = lines[1];
            String Titular_D = lines[2];
            String Agencia_D = lines[3];
            String password_D = lines[4];
            String saldo_D = lines[5];

            double sald = Convert.ToDouble(saldo_D);
            sald = sald + Valor;
            saldo_D = Convert.ToString(sald);

            StreamWriter sw = new StreamWriter(appPath + "/DATA_Banco/" + Conta + ".txt");
            sw.WriteLine(info);
            sw.WriteLine(Numero_D);
            sw.WriteLine(Titular_D);
            sw.WriteLine(Agencia_D);
            sw.WriteLine(password_D);
            sw.WriteLine(saldo_D);
            sw.Close();


            logger Log = new logger();
            var data = DateTime.Now;
            Log.Info = (" A conta " + Numero_D + " Depositou " + Valor + " reais " + " [" + Convert.ToString(data) + "]");
            Log.Main();








        }

        public void Cadastro()
        {
            //var Sald = Convert.ToString(Saldo);

            string fileName = appPath + "/DATA_Banco/" +  NumeroConta + ".txt";
            if (File.Exists(fileName))
            {

                System.Windows.Forms.MessageBox.Show("Ja existe uma conta com esse numero");
            }
            else {
                StreamWriter sw = new StreamWriter(appPath + "/DATA_Banco/" + NumeroConta + ".txt");
                sw.WriteLine("##Conta " + NumeroConta + " ##");
                sw.WriteLine(NumeroConta);
                sw.WriteLine(Titular);
                sw.WriteLine(Agencia);
                sw.WriteLine(Senha);
                sw.WriteLine(Saldo);
                sw.Close();
                System.Windows.Forms.MessageBox.Show("Sua conta foi criada!!");
                logger Log = new logger();
                var data = DateTime.Now;
                Log.Info = (" A conta " + NumeroConta + " Foi criada [ " + Convert.ToString(data)+ " ] ");
                Log.Main();

            }

        




           

            




        }

        
        
    }
}
