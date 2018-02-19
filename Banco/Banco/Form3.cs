using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Banco
{
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Usuario\source\repos\Banco\Banco\Login\" + txtEntrarConta.Text + ".txt";
            if (File.Exists(fileName))
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Usuario\source\repos\Banco\Banco\Login\" + txtEntrarConta.Text + ".txt");

                String password = lines[4];

                var Numerodaconta = txtEntrarConta.Text;

                if (password == txtEntrarSenha.Text)
                {

                    logger Log = new logger();
                    var data = DateTime.Now;
                    Log.Info = (" A conta " + Numerodaconta + " Logou " + "[" + Convert.ToString(data) + "]");
                    Log.Main();

                    this.Hide();
                    Form4 f4 = new Form4(Numerodaconta);
                    f4.ShowDialog();
                    this.Close();



                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Senha Incorreta");
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Essa Conta não existe");
            }
        }
    }
}
    

