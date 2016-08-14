namespace ProyectoFinal
{
    partial class TablaOrganismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaOrganismo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboBoxOrganismo = new System.Windows.Forms.ComboBox();
            this.orglabel = new System.Windows.Forms.Label();
            this.buttonEliminaOrganismo = new System.Windows.Forms.Button();
            this.buttonActualizarOrganismo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonGuardaOrganismo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiaOrganismo = new System.Windows.Forms.Button();
            this.buttonOrganismoVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Organismo";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(633, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ComboBoxOrganismo
            // 
            this.ComboBoxOrganismo.AccessibleDescription = "";
            this.ComboBoxOrganismo.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxOrganismo.DisplayMember = "Guardar ";
            this.ComboBoxOrganismo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOrganismo.FormattingEnabled = true;
            this.ComboBoxOrganismo.Location = new System.Drawing.Point(67, 209);
            this.ComboBoxOrganismo.Name = "ComboBoxOrganismo";
            this.ComboBoxOrganismo.Size = new System.Drawing.Size(177, 26);
            this.ComboBoxOrganismo.TabIndex = 19;
            this.ComboBoxOrganismo.Tag = "";
            // 
            // orglabel
            // 
            this.orglabel.AutoSize = true;
            this.orglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orglabel.Location = new System.Drawing.Point(112, 171);
            this.orglabel.Name = "orglabel";
            this.orglabel.Size = new System.Drawing.Size(93, 20);
            this.orglabel.TabIndex = 20;
            this.orglabel.Text = "Existentes";
            this.orglabel.Click += new System.EventHandler(this.invConsultar_Click);
            // 
            // buttonEliminaOrganismo
            // 
            this.buttonEliminaOrganismo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEliminaOrganismo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminaOrganismo.BackgroundImage")));
            this.buttonEliminaOrganismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminaOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEliminaOrganismo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminaOrganismo.Location = new System.Drawing.Point(106, 380);
            this.buttonEliminaOrganismo.Name = "buttonEliminaOrganismo";
            this.buttonEliminaOrganismo.Size = new System.Drawing.Size(67, 60);
            this.buttonEliminaOrganismo.TabIndex = 22;
            this.buttonEliminaOrganismo.UseVisualStyleBackColor = false;
            this.buttonEliminaOrganismo.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonActualizarOrganismo
            // 
            this.buttonActualizarOrganismo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonActualizarOrganismo.BackgroundImage")));
            this.buttonActualizarOrganismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActualizarOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonActualizarOrganismo.Location = new System.Drawing.Point(285, 380);
            this.buttonActualizarOrganismo.Name = "buttonActualizarOrganismo";
            this.buttonActualizarOrganismo.Size = new System.Drawing.Size(67, 60);
            this.buttonActualizarOrganismo.TabIndex = 23;
            this.buttonActualizarOrganismo.UseVisualStyleBackColor = true;
            this.buttonActualizarOrganismo.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(633, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(633, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 20);
            this.textBox3.TabIndex = 25;
            // 
            // buttonGuardaOrganismo
            // 
            this.buttonGuardaOrganismo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardaOrganismo.BackgroundImage")));
            this.buttonGuardaOrganismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardaOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonGuardaOrganismo.Location = new System.Drawing.Point(475, 380);
            this.buttonGuardaOrganismo.Name = "buttonGuardaOrganismo";
            this.buttonGuardaOrganismo.Size = new System.Drawing.Size(67, 60);
            this.buttonGuardaOrganismo.TabIndex = 27;
            this.buttonGuardaOrganismo.UseVisualStyleBackColor = true;
            this.buttonGuardaOrganismo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(477, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(510, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(523, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nombre";
            // 
            // buttonLimpiaOrganismo
            // 
            this.buttonLimpiaOrganismo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLimpiaOrganismo.BackgroundImage")));
            this.buttonLimpiaOrganismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLimpiaOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonLimpiaOrganismo.Location = new System.Drawing.Point(660, 380);
            this.buttonLimpiaOrganismo.Name = "buttonLimpiaOrganismo";
            this.buttonLimpiaOrganismo.Size = new System.Drawing.Size(67, 60);
            this.buttonLimpiaOrganismo.TabIndex = 33;
            this.buttonLimpiaOrganismo.UseVisualStyleBackColor = true;
            this.buttonLimpiaOrganismo.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonOrganismoVolver
            // 
            this.buttonOrganismoVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOrganismoVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOrganismoVolver.BackgroundImage")));
            this.buttonOrganismoVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOrganismoVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrganismoVolver.Location = new System.Drawing.Point(2, 0);
            this.buttonOrganismoVolver.Name = "buttonOrganismoVolver";
            this.buttonOrganismoVolver.Size = new System.Drawing.Size(67, 60);
            this.buttonOrganismoVolver.TabIndex = 34;
            this.buttonOrganismoVolver.UseVisualStyleBackColor = false;
            this.buttonOrganismoVolver.Click += new System.EventHandler(this.buttonOrganismoVolver_Click);
            // 
            // TablaOrganismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.buttonOrganismoVolver);
            this.Controls.Add(this.buttonLimpiaOrganismo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGuardaOrganismo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonActualizarOrganismo);
            this.Controls.Add(this.buttonEliminaOrganismo);
            this.Controls.Add(this.orglabel);
            this.Controls.Add(this.ComboBoxOrganismo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TablaOrganismo";
            this.Text = "Organismo";
            this.Load += new System.EventHandler(this.Organismo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ComboBoxOrganismo;
        private System.Windows.Forms.Label orglabel;
        private System.Windows.Forms.Button buttonEliminaOrganismo;
        private System.Windows.Forms.Button buttonActualizarOrganismo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonGuardaOrganismo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiaOrganismo;
        private System.Windows.Forms.Button buttonOrganismoVolver;
    }
}