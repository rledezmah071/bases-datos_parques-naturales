namespace ProyectoFinal
{
    partial class InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.label1 = new System.Windows.Forms.Label();
            this.textoUsuario = new System.Windows.Forms.TextBox();
            this.textoContraseña = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestión de Parques Naturales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textoUsuario
            // 
            this.textoUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.textoUsuario.Location = new System.Drawing.Point(223, 165);
            this.textoUsuario.Name = "textoUsuario";
            this.textoUsuario.Size = new System.Drawing.Size(140, 20);
            this.textoUsuario.TabIndex = 1;
            this.textoUsuario.TextChanged += new System.EventHandler(this.textoUsuario_TextChanged);
            this.textoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textoUsuario_KeyDown);
            // 
            // textoContraseña
            // 
            this.textoContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.textoContraseña.Location = new System.Drawing.Point(223, 236);
            this.textoContraseña.Name = "textoContraseña";
            this.textoContraseña.PasswordChar = '*';
            this.textoContraseña.Size = new System.Drawing.Size(140, 20);
            this.textoContraseña.TabIndex = 2;
            this.textoContraseña.UseSystemPasswordChar = true;
            this.textoContraseña.TextChanged += new System.EventHandler(this.textoContraseña_TextChanged);
            this.textoContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoContraseña_KeyPress);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.Gray;
            this.buttonIngresar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIngresar.Location = new System.Drawing.Point(558, 314);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(108, 46);
            this.buttonIngresar.TabIndex = 3;
            this.buttonIngresar.Text = "Entrar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Gray;
            this.buttonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(692, 314);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(108, 46);
            this.buttonSalir.TabIndex = 67;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Candara", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(12, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "ABD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textoContraseña);
            this.Controls.Add(this.textoUsuario);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "InicioSesion";
            this.Text = "Sistema de Gestión de Parques  Naturales";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoUsuario;
        private System.Windows.Forms.TextBox textoContraseña;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label4;
    }
}

