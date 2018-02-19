namespace Banco
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblOla = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblNumeroconta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDepositar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSacar = new System.Windows.Forms.Button();
            this.numericUpDownDeposito = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSaque = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtContatrans = new System.Windows.Forms.TextBox();
            this.numericUpDownTrans = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaque)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOla.Location = new System.Drawing.Point(12, 9);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(153, 24);
            this.lblOla.TabIndex = 0;
            this.lblOla.Text = "Bem-vindo Teste";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.lblNumeroconta);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 97);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // lblNumeroconta
            // 
            this.lblNumeroconta.AutoSize = true;
            this.lblNumeroconta.Location = new System.Drawing.Point(6, 52);
            this.lblNumeroconta.Name = "lblNumeroconta";
            this.lblNumeroconta.Size = new System.Drawing.Size(93, 13);
            this.lblNumeroconta.TabIndex = 1;
            this.lblNumeroconta.Text = "Numero da Conta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownDeposito);
            this.groupBox2.Controls.Add(this.BtnDepositar);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposito";
            // 
            // BtnDepositar
            // 
            this.BtnDepositar.Location = new System.Drawing.Point(6, 121);
            this.BtnDepositar.Name = "BtnDepositar";
            this.BtnDepositar.Size = new System.Drawing.Size(188, 23);
            this.BtnDepositar.TabIndex = 0;
            this.BtnDepositar.Text = "Depositar";
            this.BtnDepositar.UseVisualStyleBackColor = true;
            this.BtnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numericUpDownSaque);
            this.groupBox3.Controls.Add(this.BtnSacar);
            this.groupBox3.Location = new System.Drawing.Point(218, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 173);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saque";
            // 
            // BtnSacar
            // 
            this.BtnSacar.Location = new System.Drawing.Point(6, 121);
            this.BtnSacar.Name = "BtnSacar";
            this.BtnSacar.Size = new System.Drawing.Size(188, 23);
            this.BtnSacar.TabIndex = 0;
            this.BtnSacar.Text = "Sacar";
            this.BtnSacar.UseVisualStyleBackColor = true;
            this.BtnSacar.Click += new System.EventHandler(this.BtnSacar_Click);
            // 
            // numericUpDownDeposito
            // 
            this.numericUpDownDeposito.DecimalPlaces = 2;
            this.numericUpDownDeposito.Location = new System.Drawing.Point(4, 75);
            this.numericUpDownDeposito.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownDeposito.Name = "numericUpDownDeposito";
            this.numericUpDownDeposito.Size = new System.Drawing.Size(190, 20);
            this.numericUpDownDeposito.TabIndex = 1;
            // 
            // numericUpDownSaque
            // 
            this.numericUpDownSaque.DecimalPlaces = 2;
            this.numericUpDownSaque.Location = new System.Drawing.Point(6, 75);
            this.numericUpDownSaque.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSaque.Name = "numericUpDownSaque";
            this.numericUpDownSaque.Size = new System.Drawing.Size(188, 20);
            this.numericUpDownSaque.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor a ser Depositado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor a ser Sacado";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Transparent;
            this.lblNumero.Location = new System.Drawing.Point(791, 589);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(6, 2);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "label3";
            // 
            // btnReload
            // 
            this.btnReload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReload.Location = new System.Drawing.Point(163, 52);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(50, 47);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownTrans);
            this.groupBox4.Controls.Add(this.txtContatrans);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lbl);
            this.groupBox4.Location = new System.Drawing.Point(424, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 173);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tranferencia ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(6, 59);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Numero da Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dinheiro a ser Trasferido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trasferir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(71, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(208, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // txtContatrans
            // 
            this.txtContatrans.Location = new System.Drawing.Point(102, 59);
            this.txtContatrans.Name = "txtContatrans";
            this.txtContatrans.Size = new System.Drawing.Size(225, 20);
            this.txtContatrans.TabIndex = 6;
            // 
            // numericUpDownTrans
            // 
            this.numericUpDownTrans.DecimalPlaces = 2;
            this.numericUpDownTrans.Location = new System.Drawing.Point(134, 33);
            this.numericUpDownTrans.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownTrans.Name = "numericUpDownTrans";
            this.numericUpDownTrans.Size = new System.Drawing.Size(188, 20);
            this.numericUpDownTrans.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "desenvolvido por Joao Maia";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(838, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaque)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumeroconta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDepositar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSaque;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtContatrans;
        private System.Windows.Forms.NumericUpDown numericUpDownTrans;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label4;
    }
}