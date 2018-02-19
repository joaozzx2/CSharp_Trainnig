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

    public partial class Form4 : Form
    {


        public Form4(string Numerodaconta)
        {

            InitializeComponent();
            lblNumero.Text = Numerodaconta;


        }

        private void Form4_Load(object sender, EventArgs e)
        {

            var Numero_Conta = lblNumero.Text;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Usuario\source\repos\Banco\Banco\Login\" + Numero_Conta + ".txt");



            String Numero = lines[1];
            String Titular = lines[2];
            String Agencia = lines[3];
            String password = lines[4];
            String saldo = lines[5];

            lblOla.Text = "Bem Vindo Senhor(a), " + Titular;
            lblNumeroconta.Text = ("Numero da conta: " + Numero);
            lblSaldo.Text = "Saldo: R$" + saldo;



        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            var Numero_Conta = lblNumero.Text;
            Conta Conta1 = new Conta();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Usuario\source\repos\Banco\Banco\Login\" + Numero_Conta + ".txt");



            String Numero = lines[1];
            String Titular = lines[2];
            String Agencia = lines[3];
            String password = lines[4];
            String saldo = lines[5];

            Conta1.Deposito(Convert.ToDouble(numericUpDownDeposito.Value), Numero);

            btnReload.PerformClick();

        }

        private void BtnSacar_Click(object sender, EventArgs e)
        {
            var Numero_Conta = lblNumero.Text;
            Conta Conta1 = new Conta();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Usuario\source\repos\Banco\Banco\Login\" + Numero_Conta + ".txt");



            String Numero = lines[1];
            String Titular = lines[2];
            String Agencia = lines[3];
            String password = lines[4];
            String saldo = lines[5];

            

            Conta1.Saque(Convert.ToDouble(numericUpDownSaque.Value), Numero);

            btnReload.PerformClick();




        }

        private void btnReload_Click(object sender, EventArgs e)
        {


            var Numero_Conta = lblNumero.Text;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Usuario\source\repos\Banco\Banco\Login\" + Numero_Conta + ".txt");

            

            String Numero = lines[1];
            String Titular = lines[2];
            String Agencia = lines[3];
            String password = lines[4];
            String saldo = lines[5];

            lblOla.Text = "Bem Vindo Senhor(a), " + Titular;
            lblNumeroconta.Text = ("Numero da conta: " + Numero);
            lblSaldo.Text = "Saldo: R$" + saldo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta Conta1 = new Conta();
            var Numero_Conta = lblNumero.Text;
            Conta1.Transferencia(Convert.ToDouble(numericUpDownTrans.Value), Numero_Conta, txtContatrans.Text);

            var bar = 0;
            while (bar < 100)
            {
                bar += 5;
                progressBar1.Value = bar;
            }
            System.Windows.Forms.MessageBox.Show("Transferencia feita com sucesso!!");
            bar = 0;
            progressBar1.Value = bar;

            btnReload.PerformClick();
        }
    }
}
    
