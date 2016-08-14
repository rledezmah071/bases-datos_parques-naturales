namespace ProyectoFinal
{
    partial class MenuGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGestor));
            this.label1 = new System.Windows.Forms.Label();
            this.admComboBoxConsultar = new System.Windows.Forms.ComboBox();
            this.GestVisit = new System.Windows.Forms.Label();
            this.gestExcursiones = new System.Windows.Forms.Label();
            this.buttonMenuAdmVolver = new System.Windows.Forms.Button();
            this.GestAlojamiento = new System.Windows.Forms.Label();
            this.buttonConsultaExcursion = new System.Windows.Forms.Button();
            this.buttonConsultaAlojamiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(338, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú Principal";
            // 
            // admComboBoxConsultar
            // 
            this.admComboBoxConsultar.AccessibleDescription = "";
            this.admComboBoxConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.admComboBoxConsultar.DisplayMember = "Guardar ";
            this.admComboBoxConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admComboBoxConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admComboBoxConsultar.FormattingEnabled = true;
            this.admComboBoxConsultar.Items.AddRange(new object[] {
            "Consultar",
            "Insertar",
            "Actualizar",
            "Eliminar"});
            this.admComboBoxConsultar.Location = new System.Drawing.Point(90, 228);
            this.admComboBoxConsultar.Name = "admComboBoxConsultar";
            this.admComboBoxConsultar.Size = new System.Drawing.Size(177, 26);
            this.admComboBoxConsultar.TabIndex = 10;
            this.admComboBoxConsultar.Tag = "";
            // 
            // GestVisit
            // 
            this.GestVisit.AutoSize = true;
            this.GestVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.GestVisit.Location = new System.Drawing.Point(125, 189);
            this.GestVisit.Name = "GestVisit";
            this.GestVisit.Size = new System.Drawing.Size(117, 26);
            this.GestVisit.TabIndex = 11;
            this.GestVisit.Text = "Visitantes";
            this.GestVisit.Click += new System.EventHandler(this.admConsultar_Click);
            // 
            // gestExcursiones
            // 
            this.gestExcursiones.AutoSize = true;
            this.gestExcursiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.gestExcursiones.Location = new System.Drawing.Point(658, 103);
            this.gestExcursiones.Name = "gestExcursiones";
            this.gestExcursiones.Size = new System.Drawing.Size(142, 26);
            this.gestExcursiones.TabIndex = 14;
            this.gestExcursiones.Text = "Excursiones";
            // 
            // buttonMenuAdmVolver
            // 
            this.buttonMenuAdmVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuAdmVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuAdmVolver.BackgroundImage")));
            this.buttonMenuAdmVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuAdmVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuAdmVolver.Location = new System.Drawing.Point(12, 9);
            this.buttonMenuAdmVolver.Name = "buttonMenuAdmVolver";
            this.buttonMenuAdmVolver.Size = new System.Drawing.Size(67, 60);
            this.buttonMenuAdmVolver.TabIndex = 15;
            this.buttonMenuAdmVolver.UseVisualStyleBackColor = false;
            this.buttonMenuAdmVolver.Click += new System.EventHandler(this.buttonMenuAdmVolver_Click);
            // 
            // GestAlojamiento
            // 
            this.GestAlojamiento.AutoSize = true;
            this.GestAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.GestAlojamiento.Location = new System.Drawing.Point(662, 303);
            this.GestAlojamiento.Name = "GestAlojamiento";
            this.GestAlojamiento.Size = new System.Drawing.Size(138, 26);
            this.GestAlojamiento.TabIndex = 16;
            this.GestAlojamiento.Text = "Alojamiento";
            // 
            // buttonConsultaExcursion
            // 
            this.buttonConsultaExcursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonConsultaExcursion.Location = new System.Drawing.Point(652, 141);
            this.buttonConsultaExcursion.Name = "buttonConsultaExcursion";
            this.buttonConsultaExcursion.Size = new System.Drawing.Size(148, 27);
            this.buttonConsultaExcursion.TabIndex = 17;
            this.buttonConsultaExcursion.Text = "Consultar";
            this.buttonConsultaExcursion.UseVisualStyleBackColor = true;
            // 
            // buttonConsultaAlojamiento
            // 
            this.buttonConsultaAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonConsultaAlojamiento.Location = new System.Drawing.Point(652, 342);
            this.buttonConsultaAlojamiento.Name = "buttonConsultaAlojamiento";
            this.buttonConsultaAlojamiento.Size = new System.Drawing.Size(148, 28);
            this.buttonConsultaAlojamiento.TabIndex = 18;
            this.buttonConsultaAlojamiento.Text = "Consultar";
            this.buttonConsultaAlojamiento.UseVisualStyleBackColor = true;
            // 
            // MenuGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.buttonConsultaAlojamiento);
            this.Controls.Add(this.buttonConsultaExcursion);
            this.Controls.Add(this.GestAlojamiento);
            this.Controls.Add(this.buttonMenuAdmVolver);
            this.Controls.Add(this.gestExcursiones);
            this.Controls.Add(this.GestVisit);
            this.Controls.Add(this.admComboBoxConsultar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuGestor";
            this.Text = "MenuGestor";
            this.Load += new System.EventHandler(this.MenuGestor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox admComboBoxConsultar;
        private System.Windows.Forms.Label GestVisit;
        private System.Windows.Forms.Label gestExcursiones;
        private System.Windows.Forms.Button buttonMenuAdmVolver;
        private System.Windows.Forms.Label GestAlojamiento;
        private System.Windows.Forms.Button buttonConsultaExcursion;
        private System.Windows.Forms.Button buttonConsultaAlojamiento;
    }
}