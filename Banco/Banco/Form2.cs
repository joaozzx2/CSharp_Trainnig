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

    public partial class Form2 : Form
    {
        Conta Conta1 = new Conta();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Usuario\source\repos\Banco\Banco\Login\data.txt");
            //String username = lines[0];
            //String password = lines[1];

            Conta conta1 = new Conta();
            Conta1.NumeroConta = txtConta.Text;
            Conta1.Titular = txtTitular.Text;
            Conta1.Agencia = txtAgencia.Text;
            Conta1.Senha = txtSenha.Text;
            Conta1.Saldo = "0";
            Conta1.Cadastro();
            this.Close();
            

            



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
