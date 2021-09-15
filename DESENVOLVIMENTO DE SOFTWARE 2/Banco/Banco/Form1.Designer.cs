namespace Banco
{
    partial class Form1
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
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.Label();
            this.numeroConta = new System.Windows.Forms.Label();
            this.saldoConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.sacar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(181, 103);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 0;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(181, 138);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 1;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(181, 66);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 2;
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSize = true;
            this.nomeCliente.Location = new System.Drawing.Point(108, 66);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(39, 13);
            this.nomeCliente.TabIndex = 3;
            this.nomeCliente.Text = "Cliente";
            this.nomeCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // numeroConta
            // 
            this.numeroConta.AutoSize = true;
            this.numeroConta.Location = new System.Drawing.Point(89, 106);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(74, 13);
            this.numeroConta.TabIndex = 4;
            this.numeroConta.Text = "Número conta";
            // 
            // saldoConta
            // 
            this.saldoConta.AutoSize = true;
            this.saldoConta.Location = new System.Drawing.Point(108, 141);
            this.saldoConta.Name = "saldoConta";
            this.saldoConta.Size = new System.Drawing.Size(34, 13);
            this.saldoConta.TabIndex = 5;
            this.saldoConta.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Depositar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(181, 177);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 8;
            // 
            // sacar
            // 
            this.sacar.Location = new System.Drawing.Point(284, 262);
            this.sacar.Name = "sacar";
            this.sacar.Size = new System.Drawing.Size(75, 23);
            this.sacar.TabIndex = 9;
            this.sacar.Text = "Sacar";
            this.sacar.UseVisualStyleBackColor = true;
            this.sacar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sacar);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saldoConta);
            this.Controls.Add(this.numeroConta);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Name = "Form1";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label nomeCliente;
        private System.Windows.Forms.Label numeroConta;
        private System.Windows.Forms.Label saldoConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button sacar;
        private System.Windows.Forms.Button button2;
    }
}

