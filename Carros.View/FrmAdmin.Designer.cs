namespace Carros.View
{
    partial class FrmAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTabelas = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnDesconect = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnConcess = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnTabelas);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.btnDesconect);
            this.panel1.Controls.Add(this.btnFunc);
            this.panel1.Controls.Add(this.btnCarros);
            this.panel1.Controls.Add(this.btnConcess);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnTabelas
            // 
            this.btnTabelas.BackColor = System.Drawing.Color.DarkGray;
            this.btnTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabelas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabelas.Location = new System.Drawing.Point(241, 0);
            this.btnTabelas.Name = "btnTabelas";
            this.btnTabelas.Size = new System.Drawing.Size(115, 42);
            this.btnTabelas.TabIndex = 5;
            this.btnTabelas.Text = "Tabelas";
            this.btnTabelas.UseVisualStyleBackColor = false;
            this.btnTabelas.Click += new System.EventHandler(this.btnTabelas_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(477, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(148, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.BackColor = System.Drawing.Color.DarkGray;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(124, 42);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.DarkGray;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVendas.Location = new System.Drawing.Point(125, 0);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(115, 42);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(362, 1);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 41);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesconect
            // 
            this.btnDesconect.BackColor = System.Drawing.Color.DarkGray;
            this.btnDesconect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconect.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDesconect.Location = new System.Drawing.Point(626, 0);
            this.btnDesconect.Name = "btnDesconect";
            this.btnDesconect.Size = new System.Drawing.Size(157, 42);
            this.btnDesconect.TabIndex = 0;
            this.btnDesconect.Text = "Desconectar";
            this.btnDesconect.UseVisualStyleBackColor = false;
            this.btnDesconect.Click += new System.EventHandler(this.btnDesconect_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.DarkGray;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFunc.Location = new System.Drawing.Point(241, 0);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(115, 42);
            this.btnFunc.TabIndex = 0;
            this.btnFunc.Text = "Funcionários";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.BackColor = System.Drawing.Color.DarkGray;
            this.btnCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarros.Location = new System.Drawing.Point(125, 0);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(115, 42);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = false;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnConcess
            // 
            this.btnConcess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConcess.BackColor = System.Drawing.Color.DarkGray;
            this.btnConcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConcess.Location = new System.Drawing.Point(0, 0);
            this.btnConcess.Name = "btnConcess";
            this.btnConcess.Size = new System.Drawing.Size(124, 42);
            this.btnConcess.TabIndex = 0;
            this.btnConcess.Text = "Concessionária";
            this.btnConcess.UseVisualStyleBackColor = false;
            this.btnConcess.Click += new System.EventHandler(this.btnConcess_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 370);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "FrmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblUsuario;
        private Button btnDesconect;
        private Button btnFunc;
        private Button btnCarros;
        private Button btnConcess;
        private Button btnVendas;
        private Button btnCliente;
        private Button btnLogin;
        private Button btnTabelas;
    }
}