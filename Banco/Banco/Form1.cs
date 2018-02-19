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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            Directory.CreateDirectory(appPath +@"\DATA_BANCO");
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form3 f3 = new Form3();
            f3.ShowDialog();

            this.Close();
            

        }
    }
}
