namespace ProyectoFinal
{
    partial class TablaProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaProyectos));
            this.label6 = new System.Windows.Forms.Label();
            this.proyFecFinal = new System.Windows.Forms.TextBox();
            this.proyComboBoxCodInvestigador = new System.Windows.Forms.ComboBox();
            this.buttonProyectosVolver = new System.Windows.Forms.Button();
            this.buttonLimpiaProyectos = new System.Windows.Forms.Button();
            this.Presupuesto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardaProyectos = new System.Windows.Forms.Button();
            this.proyFecInicio = new System.Windows.Forms.TextBox();
            this.proyPresupuesto = new System.Windows.Forms.TextBox();
            this.buttonActualizarProyectos = new System.Windows.Forms.Button();
            this.buttonEliminaProyectos = new System.Windows.Forms.Button();
            this.comlabel = new System.Windows.Forms.Label();
            this.ComboBoxProyectos = new System.Windows.Forms.ComboBox();
            this.proyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(413, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Fecha de Finalización";
            // 
            // proyFecFinal
            // 
            this.proyFecFinal.BackColor = System.Drawing.SystemColors.Control;
            this.proyFecFinal.Location = new System.Drawing.Point(629, 259);
            this.proyFecFinal.Name = "proyFecFinal";
            this.proyFecFinal.Size = new System.Drawing.Size(197, 20);
            this.proyFecFinal.TabIndex = 86;
            // 
            // proyComboBoxCodInvestigador
            // 
            this.proyComboBoxCodInvestigador.AccessibleDescription = "";
            this.proyComboBoxCodInvestigador.BackColor = System.Drawing.SystemColors.Control;
            this.proyComboBoxCodInvestigador.DisplayMember = "Guardar ";
            this.proyComboBoxCodInvestigador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proyComboBoxCodInvestigador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proyComboBoxCodInvestigador.FormattingEnabled = true;
            this.proyComboBoxCodInvestigador.Location = new System.Drawing.Point(629, 303);
            this.proyComboBoxCodInvestigador.Name = "proyComboBoxCodInvestigador";
            this.proyComboBoxCodInvestigador.Size = new System.Drawing.Size(197, 26);
            this.proyComboBoxCodInvestigador.TabIndex = 85;
            this.proyComboBoxCodInvestigador.Tag = "";
            // 
            // buttonProyectosVolver
            // 
            this.buttonProyectosVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonProyectosVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProyectosVolver.BackgroundImage")));
            this.buttonProyectosVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProyectosVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProyectosVolver.Location = new System.Drawing.Point(2, -1);
            this.buttonProyectosVolver.Name = "buttonProyectosVolver";
            this.buttonProyectosVolver.Size = new System.Drawing.Size(67, 60);
            this.buttonProyectosVolver.TabIndex = 84;
            this.buttonProyectosVolver.UseVisualStyleBackColor = false;
            this.buttonProyectosVolver.Click += new System.EventHandler(this.buttonProyectosVolver_Click);
            // 
            // buttonLimpiaProyectos
            // 
            this.buttonLimpiaProyectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLimpiaProyectos.BackgroundImage")));
            this.buttonLimpiaProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLimpiaProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonLimpiaProyectos.Location = new System.Drawing.Point(653, 379);
            this.buttonLimpiaProyectos.Name = "buttonLimpiaProyectos";
            this.buttonLimpiaProyectos.Size = new System.Drawing.Size(67, 60);
            this.buttonLimpiaProyectos.TabIndex = 83;
            this.buttonLimpiaProyectos.UseVisualStyleBackColor = true;
            this.buttonLimpiaProyectos.Click += new System.EventHandler(this.buttonLimpiaProyectos_Click);
            // 
            // Presupuesto
            // 
            this.Presupuesto.AutoSize = true;
            this.Presupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Presupuesto.Location = new System.Drawing.Point(480, 157);
            this.Presupuesto.Name = "Presupuesto";
            this.Presupuesto.Size = new System.Drawing.Size(110, 20);
            this.Presupuesto.TabIndex = 82;
            this.Presupuesto.Text = "Presupuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(458, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(409, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Código de Investigador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(473, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Identificación";
            // 
            // buttonGuardaProyectos
            // 
            this.buttonGuardaProyectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGuardaProyectos.BackgroundImage")));
            this.buttonGuardaProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGuardaProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonGuardaProyectos.Location = new System.Drawing.Point(468, 379);
            this.buttonGuardaProyectos.Name = "buttonGuardaProyectos";
            this.buttonGuardaProyectos.Size = new System.Drawing.Size(67, 60);
            this.buttonGuardaProyectos.TabIndex = 78;
            this.buttonGuardaProyectos.UseVisualStyleBackColor = true;
            // 
            // proyFecInicio
            // 
            this.proyFecInicio.BackColor = System.Drawing.SystemColors.Control;
            this.proyFecInicio.Location = new System.Drawing.Point(629, 208);
            this.proyFecInicio.Name = "proyFecInicio";
            this.proyFecInicio.Size = new System.Drawing.Size(197, 20);
            this.proyFecInicio.TabIndex = 77;
            // 
            // proyPresupuesto
            // 
            this.proyPresupuesto.BackColor = System.Drawing.SystemColors.Control;
            this.proyPresupuesto.Location = new System.Drawing.Point(629, 157);
            this.proyPresupuesto.Name = "proyPresupuesto";
            this.proyPresupuesto.Size = new System.Drawing.Size(197, 20);
            this.proyPresupuesto.TabIndex = 76;
            // 
            // buttonActualizarProyectos
            // 
            this.buttonActualizarProyectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonActualizarProyectos.BackgroundImage")));
            this.buttonActualizarProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActualizarProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonActualizarProyectos.Location = new System.Drawing.Point(278, 379);
            this.buttonActualizarProyectos.Name = "buttonActualizarProyectos";
            this.buttonActualizarProyectos.Size = new System.Drawing.Size(67, 60);
            this.buttonActualizarProyectos.TabIndex = 75;
            this.buttonActualizarProyectos.UseVisualStyleBackColor = true;
            // 
            // buttonEliminaProyectos
            // 
            this.buttonEliminaProyectos.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEliminaProyectos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminaProyectos.BackgroundImage")));
            this.buttonEliminaProyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminaProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEliminaProyectos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEliminaProyectos.Location = new System.Drawing.Point(99, 379);
            this.buttonEliminaProyectos.Name = "buttonEliminaProyectos";
            this.buttonEliminaProyectos.Size = new System.Drawing.Size(67, 60);
            this.buttonEliminaProyectos.TabIndex = 74;
            this.buttonEliminaProyectos.UseVisualStyleBackColor = false;
            // 
            // comlabel
            // 
            this.comlabel.AutoSize = true;
            this.comlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.comlabel.Location = new System.Drawing.Point(105, 170);
            this.comlabel.Name = "comlabel";
            this.comlabel.Size = new System.Drawing.Size(93, 20);
            this.comlabel.TabIndex = 73;
            this.comlabel.Text = "Existentes";
            // 
            // ComboBoxProyectos
            // 
            this.ComboBoxProyectos.AccessibleDescription = "";
            this.ComboBoxProyectos.BackColor = System.Drawing.SystemColors.Control;
            this.ComboBoxProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxProyectos.FormattingEnabled = true;
            this.ComboBoxProyectos.Location = new System.Drawing.Point(60, 208);
            this.ComboBoxProyectos.Name = "ComboBoxProyectos";
            this.ComboBoxProyectos.Size = new System.Drawing.Size(177, 26);
            this.ComboBoxProyectos.TabIndex = 72;
            this.ComboBoxProyectos.Tag = "";
            // 
            // proyID
            // 
            this.proyID.BackColor = System.Drawing.SystemColors.Control;
            this.proyID.Location = new System.Drawing.Point(629, 116);
            this.proyID.Name = "proyID";
            this.proyID.Size = new System.Drawing.Size(197, 20);
            this.proyID.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 70;
            this.label1.Text = "Proyectos";
            // 
            // TablaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.proyFecFinal);
            this.Controls.Add(this.proyComboBoxCodInvestigador);
            this.Controls.Add(this.buttonProyectosVolver);
            this.Controls.Add(this.buttonLimpiaProyectos);
            this.Controls.Add(this.Presupuesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGuardaProyectos);
            this.Controls.Add(this.proyFecInicio);
            this.Controls.Add(this.proyPresupuesto);
            this.Controls.Add(this.buttonActualizarProyectos);
            this.Controls.Add(this.buttonEliminaProyectos);
            this.Controls.Add(this.comlabel);
            this.Controls.Add(this.ComboBoxProyectos);
            this.Controls.Add(this.proyID);
            this.Controls.Add(this.label1);
            this.Name = "TablaProyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.TablaProyectos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox proyFecFinal;
        private System.Windows.Forms.ComboBox proyComboBoxCodInvestigador;
        private System.Windows.Forms.Button buttonProyectosVolver;
        private System.Windows.Forms.Button buttonLimpiaProyectos;
        private System.Windows.Forms.Label Presupuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardaProyectos;
        private System.Windows.Forms.TextBox proyFecInicio;
        private System.Windows.Forms.TextBox proyPresupuesto;
        private System.Windows.Forms.Button buttonActualizarProyectos;
        private System.Windows.Forms.Button buttonEliminaProyectos;
        private System.Windows.Forms.Label comlabel;
        private System.Windows.Forms.ComboBox ComboBoxProyectos;
        private System.Windows.Forms.TextBox proyID;
        private System.Windows.Forms.Label label1;
    }
}