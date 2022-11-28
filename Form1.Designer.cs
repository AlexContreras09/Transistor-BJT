namespace Transistor_BJT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.VccTx = new System.Windows.Forms.TextBox();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Configuración = new System.Windows.Forms.Label();
            this.VccLb = new System.Windows.Forms.Label();
            this.VceLb = new System.Windows.Forms.Label();
            this.IcLb = new System.Windows.Forms.Label();
            this.IcmaxLb = new System.Windows.Forms.Label();
            this.BetaLb = new System.Windows.Forms.Label();
            this.PotenciaLb = new System.Windows.Forms.Label();
            this.VceTx = new System.Windows.Forms.TextBox();
            this.IcTx = new System.Windows.Forms.TextBox();
            this.IcmaxTx = new System.Windows.Forms.TextBox();
            this.BetaTx = new System.Windows.Forms.TextBox();
            this.PotenciaTx = new System.Windows.Forms.TextBox();
            this.Rb1 = new System.Windows.Forms.Label();
            this.Rc1 = new System.Windows.Forms.Label();
            this.Ib1 = new System.Windows.Forms.Label();
            this.Rb1Tx = new System.Windows.Forms.TextBox();
            this.Rc1Tx = new System.Windows.Forms.TextBox();
            this.Ib1Tx = new System.Windows.Forms.TextBox();
            this.Rb2 = new System.Windows.Forms.Label();
            this.Rc2 = new System.Windows.Forms.Label();
            this.Re1Lb = new System.Windows.Forms.Label();
            this.Ib2 = new System.Windows.Forms.Label();
            this.Rb2Tx = new System.Windows.Forms.TextBox();
            this.Rc2Tx = new System.Windows.Forms.TextBox();
            this.Re1Tx = new System.Windows.Forms.TextBox();
            this.Ib2Tx = new System.Windows.Forms.TextBox();
            this.Rb3 = new System.Windows.Forms.Label();
            this.Rc3 = new System.Windows.Forms.Label();
            this.Ib3 = new System.Windows.Forms.Label();
            this.Re2Lb = new System.Windows.Forms.Label();
            this.Rb3Tx = new System.Windows.Forms.TextBox();
            this.Rc3Tx = new System.Windows.Forms.TextBox();
            this.Re2Tx = new System.Windows.Forms.TextBox();
            this.Ib3Tx = new System.Windows.Forms.TextBox();
            this.Rc4 = new System.Windows.Forms.Label();
            this.Re4 = new System.Windows.Forms.Label();
            this.R1Lb = new System.Windows.Forms.Label();
            this.R2Lb = new System.Windows.Forms.Label();
            this.RThLb = new System.Windows.Forms.Label();
            this.VThLb = new System.Windows.Forms.Label();
            this.Ib4 = new System.Windows.Forms.Label();
            this.Re4Tx = new System.Windows.Forms.TextBox();
            this.R2Tx = new System.Windows.Forms.TextBox();
            this.Rc4Tx = new System.Windows.Forms.TextBox();
            this.R1Tx = new System.Windows.Forms.TextBox();
            this.VThTx = new System.Windows.Forms.TextBox();
            this.RThTx = new System.Windows.Forms.TextBox();
            this.Ib4Tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RdTx = new System.Windows.Forms.TextBox();
            this.Rd = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Divisor = new System.Windows.Forms.Button();
            this.Calcular_Rd = new System.Windows.Forms.Button();
            this.IBc1 = new System.Windows.Forms.TextBox();
            this.IBc2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.IBc3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VccTx
            // 
            this.VccTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VccTx.Location = new System.Drawing.Point(285, 75);
            this.VccTx.Name = "VccTx";
            this.VccTx.Size = new System.Drawing.Size(150, 35);
            this.VccTx.TabIndex = 0;
            this.VccTx.Text = "0";
            this.VccTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Iniciar
            // 
            this.Iniciar.Font = new System.Drawing.Font("Arial", 11F);
            this.Iniciar.Location = new System.Drawing.Point(30, 84);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(156, 73);
            this.Iniciar.TabIndex = 1;
            this.Iniciar.Text = "Calcular";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Configuración
            // 
            this.Configuración.AutoSize = true;
            this.Configuración.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Configuración.Font = new System.Drawing.Font("Arial", 12F);
            this.Configuración.Location = new System.Drawing.Point(460, 9);
            this.Configuración.Name = "Configuración";
            this.Configuración.Size = new System.Drawing.Size(315, 29);
            this.Configuración.TabIndex = 2;
            this.Configuración.Text = "Configuración del Transistor";
            // 
            // VccLb
            // 
            this.VccLb.AutoSize = true;
            this.VccLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VccLb.Font = new System.Drawing.Font("Arial", 12F);
            this.VccLb.Location = new System.Drawing.Point(214, 75);
            this.VccLb.Name = "VccLb";
            this.VccLb.Size = new System.Drawing.Size(53, 29);
            this.VccLb.TabIndex = 6;
            this.VccLb.Text = "Vcc";
            // 
            // VceLb
            // 
            this.VceLb.AutoSize = true;
            this.VceLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VceLb.Font = new System.Drawing.Font("Arial", 12F);
            this.VceLb.Location = new System.Drawing.Point(214, 128);
            this.VceLb.Name = "VceLb";
            this.VceLb.Size = new System.Drawing.Size(54, 29);
            this.VceLb.TabIndex = 7;
            this.VceLb.Text = "Vce";
            // 
            // IcLb
            // 
            this.IcLb.AutoSize = true;
            this.IcLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IcLb.Font = new System.Drawing.Font("Arial", 12F);
            this.IcLb.Location = new System.Drawing.Point(524, 128);
            this.IcLb.Name = "IcLb";
            this.IcLb.Size = new System.Drawing.Size(32, 29);
            this.IcLb.TabIndex = 8;
            this.IcLb.Text = "Ic";
            // 
            // IcmaxLb
            // 
            this.IcmaxLb.AutoSize = true;
            this.IcmaxLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IcmaxLb.Font = new System.Drawing.Font("Arial", 12F);
            this.IcmaxLb.Location = new System.Drawing.Point(497, 75);
            this.IcmaxLb.Name = "IcmaxLb";
            this.IcmaxLb.Size = new System.Drawing.Size(90, 29);
            this.IcmaxLb.TabIndex = 9;
            this.IcmaxLb.Text = "Ic máx.";
            // 
            // BetaLb
            // 
            this.BetaLb.AutoSize = true;
            this.BetaLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BetaLb.Font = new System.Drawing.Font("Arial", 12F);
            this.BetaLb.Location = new System.Drawing.Point(854, 75);
            this.BetaLb.Name = "BetaLb";
            this.BetaLb.Size = new System.Drawing.Size(63, 29);
            this.BetaLb.TabIndex = 10;
            this.BetaLb.Text = "Beta";
            // 
            // PotenciaLb
            // 
            this.PotenciaLb.AutoSize = true;
            this.PotenciaLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PotenciaLb.Font = new System.Drawing.Font("Arial", 12F);
            this.PotenciaLb.Location = new System.Drawing.Point(833, 128);
            this.PotenciaLb.Name = "PotenciaLb";
            this.PotenciaLb.Size = new System.Drawing.Size(107, 29);
            this.PotenciaLb.TabIndex = 11;
            this.PotenciaLb.Text = "Potencia";
            // 
            // VceTx
            // 
            this.VceTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VceTx.Location = new System.Drawing.Point(285, 125);
            this.VceTx.Name = "VceTx";
            this.VceTx.Size = new System.Drawing.Size(150, 35);
            this.VceTx.TabIndex = 12;
            this.VceTx.Text = "0";
            this.VceTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IcTx
            // 
            this.IcTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcTx.Location = new System.Drawing.Point(598, 122);
            this.IcTx.Name = "IcTx";
            this.IcTx.Size = new System.Drawing.Size(150, 35);
            this.IcTx.TabIndex = 13;
            this.IcTx.Text = "0";
            this.IcTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IcmaxTx
            // 
            this.IcmaxTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcmaxTx.Location = new System.Drawing.Point(598, 75);
            this.IcmaxTx.Name = "IcmaxTx";
            this.IcmaxTx.Size = new System.Drawing.Size(150, 35);
            this.IcmaxTx.TabIndex = 14;
            this.IcmaxTx.Text = "0";
            this.IcmaxTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BetaTx
            // 
            this.BetaTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetaTx.Location = new System.Drawing.Point(955, 75);
            this.BetaTx.Name = "BetaTx";
            this.BetaTx.Size = new System.Drawing.Size(168, 35);
            this.BetaTx.TabIndex = 15;
            this.BetaTx.Text = "0";
            this.BetaTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PotenciaTx
            // 
            this.PotenciaTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotenciaTx.Location = new System.Drawing.Point(955, 128);
            this.PotenciaTx.Name = "PotenciaTx";
            this.PotenciaTx.Size = new System.Drawing.Size(168, 35);
            this.PotenciaTx.TabIndex = 16;
            this.PotenciaTx.Text = "0";
            this.PotenciaTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rb1
            // 
            this.Rb1.AutoSize = true;
            this.Rb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rb1.Font = new System.Drawing.Font("Arial", 12F);
            this.Rb1.Location = new System.Drawing.Point(105, 340);
            this.Rb1.Name = "Rb1";
            this.Rb1.Size = new System.Drawing.Size(45, 29);
            this.Rb1.TabIndex = 17;
            this.Rb1.Text = "Rb";
            // 
            // Rc1
            // 
            this.Rc1.AutoSize = true;
            this.Rc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rc1.Font = new System.Drawing.Font("Arial", 12F);
            this.Rc1.Location = new System.Drawing.Point(105, 430);
            this.Rc1.Name = "Rc1";
            this.Rc1.Size = new System.Drawing.Size(43, 29);
            this.Rc1.TabIndex = 18;
            this.Rc1.Text = "Rc";
            this.Rc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ib1
            // 
            this.Ib1.AutoSize = true;
            this.Ib1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ib1.Font = new System.Drawing.Font("Arial", 12F);
            this.Ib1.Location = new System.Drawing.Point(109, 600);
            this.Ib1.Name = "Ib1";
            this.Ib1.Size = new System.Drawing.Size(34, 29);
            this.Ib1.TabIndex = 19;
            this.Ib1.Text = "Ib";
            // 
            // Rb1Tx
            // 
            this.Rb1Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb1Tx.Location = new System.Drawing.Point(52, 380);
            this.Rb1Tx.Name = "Rb1Tx";
            this.Rb1Tx.Size = new System.Drawing.Size(150, 35);
            this.Rb1Tx.TabIndex = 20;
            this.Rb1Tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rc1Tx
            // 
            this.Rc1Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rc1Tx.Location = new System.Drawing.Point(52, 470);
            this.Rc1Tx.Name = "Rc1Tx";
            this.Rc1Tx.Size = new System.Drawing.Size(150, 35);
            this.Rc1Tx.TabIndex = 21;
            this.Rc1Tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ib1Tx
            // 
            this.Ib1Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib1Tx.Location = new System.Drawing.Point(52, 640);
            this.Ib1Tx.Name = "Ib1Tx";
            this.Ib1Tx.Size = new System.Drawing.Size(150, 35);
            this.Ib1Tx.TabIndex = 22;
            this.Ib1Tx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rb2
            // 
            this.Rb2.AutoSize = true;
            this.Rb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rb2.Font = new System.Drawing.Font("Arial", 12F);
            this.Rb2.Location = new System.Drawing.Point(338, 340);
            this.Rb2.Name = "Rb2";
            this.Rb2.Size = new System.Drawing.Size(45, 29);
            this.Rb2.TabIndex = 23;
            this.Rb2.Text = "Rb";
            // 
            // Rc2
            // 
            this.Rc2.AutoSize = true;
            this.Rc2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rc2.Font = new System.Drawing.Font("Arial", 12F);
            this.Rc2.Location = new System.Drawing.Point(338, 430);
            this.Rc2.Name = "Rc2";
            this.Rc2.Size = new System.Drawing.Size(43, 29);
            this.Rc2.TabIndex = 24;
            this.Rc2.Text = "Rc";
            // 
            // Re1Lb
            // 
            this.Re1Lb.AutoSize = true;
            this.Re1Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Re1Lb.Font = new System.Drawing.Font("Arial", 12F);
            this.Re1Lb.Location = new System.Drawing.Point(338, 515);
            this.Re1Lb.Name = "Re1Lb";
            this.Re1Lb.Size = new System.Drawing.Size(44, 29);
            this.Re1Lb.TabIndex = 25;
            this.Re1Lb.Text = "Re";
            // 
            // Ib2
            // 
            this.Ib2.AutoSize = true;
            this.Ib2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ib2.Font = new System.Drawing.Font("Arial", 12F);
            this.Ib2.Location = new System.Drawing.Point(343, 600);
            this.Ib2.Name = "Ib2";
            this.Ib2.Size = new System.Drawing.Size(34, 29);
            this.Ib2.TabIndex = 26;
            this.Ib2.Text = "Ib";
            // 
            // Rb2Tx
            // 
            this.Rb2Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb2Tx.Location = new System.Drawing.Point(285, 380);
            this.Rb2Tx.Name = "Rb2Tx";
            this.Rb2Tx.Size = new System.Drawing.Size(150, 35);
            this.Rb2Tx.TabIndex = 27;
            // 
            // Rc2Tx
            // 
            this.Rc2Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rc2Tx.Location = new System.Drawing.Point(294, 470);
            this.Rc2Tx.Name = "Rc2Tx";
            this.Rc2Tx.Size = new System.Drawing.Size(150, 35);
            this.Rc2Tx.TabIndex = 28;
            this.Rc2Tx.Text = "Escribe";
            // 
            // Re1Tx
            // 
            this.Re1Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re1Tx.Location = new System.Drawing.Point(294, 550);
            this.Re1Tx.Name = "Re1Tx";
            this.Re1Tx.Size = new System.Drawing.Size(150, 35);
            this.Re1Tx.TabIndex = 29;
            this.Re1Tx.Text = "Escribe";
            // 
            // Ib2Tx
            // 
            this.Ib2Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib2Tx.Location = new System.Drawing.Point(294, 640);
            this.Ib2Tx.Name = "Ib2Tx";
            this.Ib2Tx.Size = new System.Drawing.Size(150, 35);
            this.Ib2Tx.TabIndex = 30;
            // 
            // Rb3
            // 
            this.Rb3.AutoSize = true;
            this.Rb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rb3.Font = new System.Drawing.Font("Arial", 12F);
            this.Rb3.Location = new System.Drawing.Point(620, 340);
            this.Rb3.Name = "Rb3";
            this.Rb3.Size = new System.Drawing.Size(45, 29);
            this.Rb3.TabIndex = 31;
            this.Rb3.Text = "Rb";
            // 
            // Rc3
            // 
            this.Rc3.AutoSize = true;
            this.Rc3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rc3.Font = new System.Drawing.Font("Arial", 12F);
            this.Rc3.Location = new System.Drawing.Point(620, 430);
            this.Rc3.Name = "Rc3";
            this.Rc3.Size = new System.Drawing.Size(43, 29);
            this.Rc3.TabIndex = 32;
            this.Rc3.Text = "Rc";
            // 
            // Ib3
            // 
            this.Ib3.AutoSize = true;
            this.Ib3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ib3.Font = new System.Drawing.Font("Arial", 12F);
            this.Ib3.Location = new System.Drawing.Point(620, 600);
            this.Ib3.Name = "Ib3";
            this.Ib3.Size = new System.Drawing.Size(34, 29);
            this.Ib3.TabIndex = 33;
            this.Ib3.Text = "Ib";
            // 
            // Re2Lb
            // 
            this.Re2Lb.AutoSize = true;
            this.Re2Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Re2Lb.Font = new System.Drawing.Font("Arial", 12F);
            this.Re2Lb.Location = new System.Drawing.Point(620, 515);
            this.Re2Lb.Name = "Re2Lb";
            this.Re2Lb.Size = new System.Drawing.Size(44, 29);
            this.Re2Lb.TabIndex = 34;
            this.Re2Lb.Text = "Re";
            // 
            // Rb3Tx
            // 
            this.Rb3Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb3Tx.Location = new System.Drawing.Point(566, 380);
            this.Rb3Tx.Name = "Rb3Tx";
            this.Rb3Tx.Size = new System.Drawing.Size(150, 35);
            this.Rb3Tx.TabIndex = 35;
            // 
            // Rc3Tx
            // 
            this.Rc3Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rc3Tx.Location = new System.Drawing.Point(566, 470);
            this.Rc3Tx.Name = "Rc3Tx";
            this.Rc3Tx.Size = new System.Drawing.Size(150, 35);
            this.Rc3Tx.TabIndex = 36;
            this.Rc3Tx.Text = "Escribe";
            // 
            // Re2Tx
            // 
            this.Re2Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re2Tx.Location = new System.Drawing.Point(566, 550);
            this.Re2Tx.Name = "Re2Tx";
            this.Re2Tx.Size = new System.Drawing.Size(150, 35);
            this.Re2Tx.TabIndex = 37;
            this.Re2Tx.Text = "Escribe";
            // 
            // Ib3Tx
            // 
            this.Ib3Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib3Tx.Location = new System.Drawing.Point(566, 640);
            this.Ib3Tx.Name = "Ib3Tx";
            this.Ib3Tx.Size = new System.Drawing.Size(150, 35);
            this.Ib3Tx.TabIndex = 38;
            // 
            // Rc4
            // 
            this.Rc4.AutoSize = true;
            this.Rc4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rc4.Font = new System.Drawing.Font("Arial", 12F);
            this.Rc4.Location = new System.Drawing.Point(835, 340);
            this.Rc4.Name = "Rc4";
            this.Rc4.Size = new System.Drawing.Size(43, 29);
            this.Rc4.TabIndex = 39;
            this.Rc4.Text = "Rc";
            // 
            // Re4
            // 
            this.Re4.AutoSize = true;
            this.Re4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Re4.Font = new System.Drawing.Font("Arial", 12F);
            this.Re4.Location = new System.Drawing.Point(1008, 340);
            this.Re4.Name = "Re4";
            this.Re4.Size = new System.Drawing.Size(44, 29);
            this.Re4.TabIndex = 40;
            this.Re4.Text = "Re";
            // 
            // R1Lb
            // 
            this.R1Lb.AutoSize = true;
            this.R1Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.R1Lb.Font = new System.Drawing.Font("Arial", 12F);
            this.R1Lb.Location = new System.Drawing.Point(835, 430);
            this.R1Lb.Name = "R1Lb";
            this.R1Lb.Size = new System.Drawing.Size(44, 29);
            this.R1Lb.TabIndex = 41;
            this.R1Lb.Text = "R1";
            // 
            // R2Lb
            // 
            this.R2Lb.AutoSize = true;
            this.R2Lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.R2Lb.Font = new System.Drawing.Font("Arial", 12F);
            this.R2Lb.Location = new System.Drawing.Point(1008, 430);
            this.R2Lb.Name = "R2Lb";
            this.R2Lb.Size = new System.Drawing.Size(44, 29);
            this.R2Lb.TabIndex = 42;
            this.R2Lb.Text = "R2";
            // 
            // RThLb
            // 
            this.RThLb.AutoSize = true;
            this.RThLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RThLb.Font = new System.Drawing.Font("Arial", 12F);
            this.RThLb.Location = new System.Drawing.Point(828, 515);
            this.RThLb.Name = "RThLb";
            this.RThLb.Size = new System.Drawing.Size(59, 29);
            this.RThLb.TabIndex = 43;
            this.RThLb.Text = "RTh";
            // 
            // VThLb
            // 
            this.VThLb.AutoSize = true;
            this.VThLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VThLb.Font = new System.Drawing.Font("Arial", 12F);
            this.VThLb.Location = new System.Drawing.Point(1006, 515);
            this.VThLb.Name = "VThLb";
            this.VThLb.Size = new System.Drawing.Size(57, 29);
            this.VThLb.TabIndex = 44;
            this.VThLb.Text = "VTh";
            // 
            // Ib4
            // 
            this.Ib4.AutoSize = true;
            this.Ib4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ib4.Font = new System.Drawing.Font("Arial", 12F);
            this.Ib4.Location = new System.Drawing.Point(930, 600);
            this.Ib4.Name = "Ib4";
            this.Ib4.Size = new System.Drawing.Size(34, 29);
            this.Ib4.TabIndex = 45;
            this.Ib4.Text = "Ib";
            // 
            // Re4Tx
            // 
            this.Re4Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Re4Tx.Location = new System.Drawing.Point(958, 380);
            this.Re4Tx.Name = "Re4Tx";
            this.Re4Tx.Size = new System.Drawing.Size(150, 35);
            this.Re4Tx.TabIndex = 46;
            this.Re4Tx.Text = "Escribe";
            // 
            // R2Tx
            // 
            this.R2Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R2Tx.Location = new System.Drawing.Point(958, 470);
            this.R2Tx.Name = "R2Tx";
            this.R2Tx.Size = new System.Drawing.Size(150, 35);
            this.R2Tx.TabIndex = 47;
            this.R2Tx.Text = "Escribe";
            // 
            // Rc4Tx
            // 
            this.Rc4Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rc4Tx.Location = new System.Drawing.Point(781, 380);
            this.Rc4Tx.Name = "Rc4Tx";
            this.Rc4Tx.Size = new System.Drawing.Size(150, 35);
            this.Rc4Tx.TabIndex = 48;
            this.Rc4Tx.Text = "Escribe";
            // 
            // R1Tx
            // 
            this.R1Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1Tx.Location = new System.Drawing.Point(781, 470);
            this.R1Tx.Name = "R1Tx";
            this.R1Tx.Size = new System.Drawing.Size(150, 35);
            this.R1Tx.TabIndex = 49;
            this.R1Tx.Text = "Escribe";
            // 
            // VThTx
            // 
            this.VThTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VThTx.Location = new System.Drawing.Point(958, 550);
            this.VThTx.Name = "VThTx";
            this.VThTx.Size = new System.Drawing.Size(150, 35);
            this.VThTx.TabIndex = 50;
            // 
            // RThTx
            // 
            this.RThTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RThTx.Location = new System.Drawing.Point(781, 550);
            this.RThTx.Name = "RThTx";
            this.RThTx.Size = new System.Drawing.Size(150, 35);
            this.RThTx.TabIndex = 51;
            // 
            // Ib4Tx
            // 
            this.Ib4Tx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ib4Tx.Location = new System.Drawing.Point(870, 640);
            this.Ib4Tx.Name = "Ib4Tx";
            this.Ib4Tx.Size = new System.Drawing.Size(150, 35);
            this.Ib4Tx.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(446, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(446, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(1160, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ohm\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(1160, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ohm\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(1094, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(765, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(765, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(1138, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 29);
            this.label8.TabIndex = 60;
            this.label8.Text = "W";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(1160, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Ohm\'s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(100, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 29);
            this.label10.TabIndex = 62;
            this.label10.Text = "Fija";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(539, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 29);
            this.label11.TabIndex = 63;
            this.label11.Text = "Retroalimentación";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 12F);
            this.label12.Location = new System.Drawing.Point(277, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 29);
            this.label12.TabIndex = 63;
            this.label12.Text = "Estabilizadores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.Location = new System.Drawing.Point(842, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 29);
            this.label13.TabIndex = 64;
            this.label13.Text = "Divisor de voltaje";
            // 
            // RdTx
            // 
            this.RdTx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdTx.Location = new System.Drawing.Point(285, 184);
            this.RdTx.Name = "RdTx";
            this.RdTx.Size = new System.Drawing.Size(150, 35);
            this.RdTx.TabIndex = 65;
            this.RdTx.Text = "0";
            this.RdTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rd
            // 
            this.Rd.AutoSize = true;
            this.Rd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Rd.Font = new System.Drawing.Font("Arial", 12F);
            this.Rd.Location = new System.Drawing.Point(217, 187);
            this.Rd.Name = "Rd";
            this.Rd.Size = new System.Drawing.Size(45, 29);
            this.Rd.TabIndex = 66;
            this.Rd.Text = "Rd";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 12F);
            this.label14.Location = new System.Drawing.Point(446, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 29);
            this.label14.TabIndex = 67;
            this.label14.Text = "Ohm\'s";
            // 
            // Divisor
            // 
            this.Divisor.Font = new System.Drawing.Font("Arial", 11F);
            this.Divisor.Location = new System.Drawing.Point(1079, 275);
            this.Divisor.Name = "Divisor";
            this.Divisor.Size = new System.Drawing.Size(156, 40);
            this.Divisor.TabIndex = 68;
            this.Divisor.Text = "Calcular Dv";
            this.Divisor.UseVisualStyleBackColor = true;
            this.Divisor.Click += new System.EventHandler(this.Divisor_Click);
            // 
            // Calcular_Rd
            // 
            this.Calcular_Rd.Font = new System.Drawing.Font("Arial", 11F);
            this.Calcular_Rd.Location = new System.Drawing.Point(30, 180);
            this.Calcular_Rd.Name = "Calcular_Rd";
            this.Calcular_Rd.Size = new System.Drawing.Size(156, 40);
            this.Calcular_Rd.TabIndex = 69;
            this.Calcular_Rd.Text = "Calcular Rd";
            this.Calcular_Rd.UseVisualStyleBackColor = true;
            this.Calcular_Rd.Click += new System.EventHandler(this.Calcular_Rd_Click);
            // 
            // IBc1
            // 
            this.IBc1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBc1.Location = new System.Drawing.Point(294, 720);
            this.IBc1.Name = "IBc1";
            this.IBc1.Size = new System.Drawing.Size(150, 35);
            this.IBc1.TabIndex = 71;
            // 
            // IBc2
            // 
            this.IBc2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBc2.Location = new System.Drawing.Point(566, 720);
            this.IBc2.Name = "IBc2";
            this.IBc2.Size = new System.Drawing.Size(150, 35);
            this.IBc2.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.Location = new System.Drawing.Point(12, 720);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(231, 29);
            this.label15.TabIndex = 70;
            this.label15.Text = "Comprobación de Ib";
            // 
            // IBc3
            // 
            this.IBc3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBc3.Location = new System.Drawing.Point(870, 720);
            this.IBc3.Name = "IBc3";
            this.IBc3.Size = new System.Drawing.Size(150, 35);
            this.IBc3.TabIndex = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1278, 794);
            this.Controls.Add(this.IBc3);
            this.Controls.Add(this.IBc2);
            this.Controls.Add(this.IBc1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Calcular_Rd);
            this.Controls.Add(this.Divisor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Rd);
            this.Controls.Add(this.RdTx);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ib4Tx);
            this.Controls.Add(this.RThTx);
            this.Controls.Add(this.VThTx);
            this.Controls.Add(this.R1Tx);
            this.Controls.Add(this.Rc4Tx);
            this.Controls.Add(this.R2Tx);
            this.Controls.Add(this.Re4Tx);
            this.Controls.Add(this.Ib4);
            this.Controls.Add(this.VThLb);
            this.Controls.Add(this.RThLb);
            this.Controls.Add(this.R2Lb);
            this.Controls.Add(this.R1Lb);
            this.Controls.Add(this.Re4);
            this.Controls.Add(this.Rc4);
            this.Controls.Add(this.Ib3Tx);
            this.Controls.Add(this.Re2Tx);
            this.Controls.Add(this.Rc3Tx);
            this.Controls.Add(this.Rb3Tx);
            this.Controls.Add(this.Re2Lb);
            this.Controls.Add(this.Ib3);
            this.Controls.Add(this.Rc3);
            this.Controls.Add(this.Rb3);
            this.Controls.Add(this.Ib2Tx);
            this.Controls.Add(this.Re1Tx);
            this.Controls.Add(this.Rc2Tx);
            this.Controls.Add(this.Rb2Tx);
            this.Controls.Add(this.Ib2);
            this.Controls.Add(this.Re1Lb);
            this.Controls.Add(this.Rc2);
            this.Controls.Add(this.Rb2);
            this.Controls.Add(this.Ib1Tx);
            this.Controls.Add(this.Rc1Tx);
            this.Controls.Add(this.Rb1Tx);
            this.Controls.Add(this.Ib1);
            this.Controls.Add(this.Rc1);
            this.Controls.Add(this.Rb1);
            this.Controls.Add(this.PotenciaTx);
            this.Controls.Add(this.BetaTx);
            this.Controls.Add(this.IcmaxTx);
            this.Controls.Add(this.IcTx);
            this.Controls.Add(this.VceTx);
            this.Controls.Add(this.PotenciaLb);
            this.Controls.Add(this.BetaLb);
            this.Controls.Add(this.IcmaxLb);
            this.Controls.Add(this.IcLb);
            this.Controls.Add(this.VceLb);
            this.Controls.Add(this.VccLb);
            this.Controls.Add(this.Configuración);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.VccTx);
            this.Name = "Form1";
            this.Text = "Transistor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VccTx;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Label Configuración;
        private System.Windows.Forms.Label VccLb;
        private System.Windows.Forms.Label VceLb;
        private System.Windows.Forms.Label IcLb;
        private System.Windows.Forms.Label IcmaxLb;
        private System.Windows.Forms.Label BetaLb;
        private System.Windows.Forms.Label PotenciaLb;
        private System.Windows.Forms.TextBox VceTx;
        private System.Windows.Forms.TextBox IcTx;
        private System.Windows.Forms.TextBox IcmaxTx;
        private System.Windows.Forms.TextBox BetaTx;
        private System.Windows.Forms.TextBox PotenciaTx;
        private System.Windows.Forms.Label Rb1;
        private System.Windows.Forms.Label Rc1;
        private System.Windows.Forms.Label Ib1;
        private System.Windows.Forms.TextBox Rb1Tx;
        private System.Windows.Forms.TextBox Rc1Tx;
        private System.Windows.Forms.TextBox Ib1Tx;
        private System.Windows.Forms.Label Rb2;
        private System.Windows.Forms.Label Rc2;
        private System.Windows.Forms.Label Re1Lb;
        private System.Windows.Forms.Label Ib2;
        private System.Windows.Forms.TextBox Rb2Tx;
        private System.Windows.Forms.TextBox Rc2Tx;
        private System.Windows.Forms.TextBox Re1Tx;
        private System.Windows.Forms.TextBox Ib2Tx;
        private System.Windows.Forms.Label Rb3;
        private System.Windows.Forms.Label Rc3;
        private System.Windows.Forms.Label Ib3;
        private System.Windows.Forms.Label Re2Lb;
        private System.Windows.Forms.TextBox Rb3Tx;
        private System.Windows.Forms.TextBox Rc3Tx;
        private System.Windows.Forms.TextBox Re2Tx;
        private System.Windows.Forms.TextBox Ib3Tx;
        private System.Windows.Forms.Label Rc4;
        private System.Windows.Forms.Label Re4;
        private System.Windows.Forms.Label R1Lb;
        private System.Windows.Forms.Label R2Lb;
        private System.Windows.Forms.Label RThLb;
        private System.Windows.Forms.Label VThLb;
        private System.Windows.Forms.Label Ib4;
        private System.Windows.Forms.TextBox Re4Tx;
        private System.Windows.Forms.TextBox R2Tx;
        private System.Windows.Forms.TextBox Rc4Tx;
        private System.Windows.Forms.TextBox R1Tx;
        private System.Windows.Forms.TextBox VThTx;
        private System.Windows.Forms.TextBox RThTx;
        private System.Windows.Forms.TextBox Ib4Tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox RdTx;
        private System.Windows.Forms.Label Rd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Divisor;
        private System.Windows.Forms.Button Calcular_Rd;
        private System.Windows.Forms.TextBox IBc1;
        private System.Windows.Forms.TextBox IBc2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox IBc3;
    }
}

