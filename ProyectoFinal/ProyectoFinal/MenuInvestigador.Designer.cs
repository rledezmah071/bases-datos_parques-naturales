namespace ProyectoFinal
{
    partial class MenuInvestigador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInvestigador));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenuAdmVolver = new System.Windows.Forms.Button();
            this.invConsultar = new System.Windows.Forms.Label();
            this.invComboBoxConsultar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(216, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // buttonMenuAdmVolver
            // 
            this.buttonMenuAdmVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuAdmVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuAdmVolver.BackgroundImage")));
            this.buttonMenuAdmVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuAdmVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuAdmVolver.Location = new System.Drawing.Point(12, 12);
            this.buttonMenuAdmVolver.Name = "buttonMenuAdmVolver";
            this.buttonMenuAdmVolver.Size = new System.Drawing.Size(67, 60);
            this.buttonMenuAdmVolver.TabIndex = 17;
            this.buttonMenuAdmVolver.UseVisualStyleBackColor = false;
            this.buttonMenuAdmVolver.Click += new System.EventHandler(this.buttonMenuAdmVolver_Click);
            // 
            // invConsultar
            // 
            this.invConsultar.AutoSize = true;
            this.invConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.invConsultar.Location = new System.Drawing.Point(91, 166);
            this.invConsultar.Name = "invConsultar";
            this.invConsultar.Size = new System.Drawing.Size(114, 26);
            this.invConsultar.TabIndex = 19;
            this.invConsultar.Text = "Consultar";
            this.invConsultar.Click += new System.EventHandler(this.admConsultar_Click);
            // 
            // invComboBoxConsultar
            // 
            this.invComboBoxConsultar.AccessibleDescription = "";
            this.invComboBoxConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.invComboBoxConsultar.DisplayMember = "Guardar ";
            this.invComboBoxConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.invComboBoxConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invComboBoxConsultar.FormattingEnabled = true;
            this.invComboBoxConsultar.Items.AddRange(new object[] {
            "Investigador",
            "Proyecto"});
            this.invComboBoxConsultar.Location = new System.Drawing.Point(59, 197);
            this.invComboBoxConsultar.Name = "invComboBoxConsultar";
            this.invComboBoxConsultar.Size = new System.Drawing.Size(177, 26);
            this.invComboBoxConsultar.TabIndex = 18;
            this.invComboBoxConsultar.Tag = "";
            this.invComboBoxConsultar.SelectedIndexChanged += new System.EventHandler(this.admComboBoxConsultar_SelectedIndexChanged);
            // 
            // MenuInvestigador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.invConsultar);
            this.Controls.Add(this.invComboBoxConsultar);
            this.Controls.Add(this.buttonMenuAdmVolver);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuInvestigador";
            this.Text = "MenuInvestigador";
            this.Load += new System.EventHandler(this.MenuInvestigador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenuAdmVolver;
        private System.Windows.Forms.Label invConsultar;
        private System.Windows.Forms.ComboBox invComboBoxConsultar;
    }
}