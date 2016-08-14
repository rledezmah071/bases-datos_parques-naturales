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
            this.buttonMenuInvVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            // buttonMenuInvVolver
            // 
            this.buttonMenuInvVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuInvVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuInvVolver.BackgroundImage")));
            this.buttonMenuInvVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuInvVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuInvVolver.Location = new System.Drawing.Point(12, 12);
            this.buttonMenuInvVolver.Name = "buttonMenuInvVolver";
            this.buttonMenuInvVolver.Size = new System.Drawing.Size(67, 60);
            this.buttonMenuInvVolver.TabIndex = 17;
            this.buttonMenuInvVolver.UseVisualStyleBackColor = false;
            this.buttonMenuInvVolver.Click += new System.EventHandler(this.buttonMenuInvVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(91, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Consultar";
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
            this.invComboBoxConsultar.SelectedIndexChanged += new System.EventHandler(this.invComboBoxConsultar_SelectedIndexChanged);
            // 
            // MenuInvestigador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invComboBoxConsultar);
            this.Controls.Add(this.buttonMenuInvVolver);
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
        private System.Windows.Forms.Button buttonMenuInvVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox invComboBoxConsultar;
    }
}