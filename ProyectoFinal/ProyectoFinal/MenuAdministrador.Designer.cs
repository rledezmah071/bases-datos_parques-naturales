namespace ProyectoFinal
{
    partial class MenuAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenuAdmVolver = new System.Windows.Forms.Button();
            this.buttonOrganismo = new System.Windows.Forms.Button();
            this.buttonComunidadAutonoma = new System.Windows.Forms.Button();
            this.buttonParqueNatural = new System.Windows.Forms.Button();
            this.adm = new System.Windows.Forms.Button();
            this.buttonEspecie = new System.Windows.Forms.Button();
            this.admExcursion = new System.Windows.Forms.Button();
            this.admProyecto = new System.Windows.Forms.Button();
            this.admAlojamiento = new System.Windows.Forms.Button();
            this.admInvestigador = new System.Windows.Forms.Button();
            this.admTipoPersonal = new System.Windows.Forms.Button();
            this.admPersonal = new System.Windows.Forms.Button();
            this.admVisitante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(290, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMenuAdmVolver
            // 
            this.buttonMenuAdmVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuAdmVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuAdmVolver.BackgroundImage")));
            this.buttonMenuAdmVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuAdmVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMenuAdmVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuAdmVolver.Location = new System.Drawing.Point(12, 10);
            this.buttonMenuAdmVolver.Name = "buttonMenuAdmVolver";
            this.buttonMenuAdmVolver.Size = new System.Drawing.Size(75, 60);
            this.buttonMenuAdmVolver.TabIndex = 6;
            this.buttonMenuAdmVolver.UseVisualStyleBackColor = false;
            this.buttonMenuAdmVolver.Click += new System.EventHandler(this.buttonMenuAdmVolver_Click_1);
            // 
            // buttonOrganismo
            // 
            this.buttonOrganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonOrganismo.Location = new System.Drawing.Point(645, 95);
            this.buttonOrganismo.Name = "buttonOrganismo";
            this.buttonOrganismo.Size = new System.Drawing.Size(125, 50);
            this.buttonOrganismo.TabIndex = 16;
            this.buttonOrganismo.Text = "Organismos";
            this.buttonOrganismo.UseVisualStyleBackColor = true;
            this.buttonOrganismo.Click += new System.EventHandler(this.buttonOrganismo_Click);
            // 
            // buttonComunidadAutonoma
            // 
            this.buttonComunidadAutonoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonComunidadAutonoma.Location = new System.Drawing.Point(141, 207);
            this.buttonComunidadAutonoma.Name = "buttonComunidadAutonoma";
            this.buttonComunidadAutonoma.Size = new System.Drawing.Size(125, 50);
            this.buttonComunidadAutonoma.TabIndex = 17;
            this.buttonComunidadAutonoma.Text = "Comunidades Autónomaes";
            this.buttonComunidadAutonoma.UseVisualStyleBackColor = true;
            // 
            // buttonParqueNatural
            // 
            this.buttonParqueNatural.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonParqueNatural.Location = new System.Drawing.Point(645, 151);
            this.buttonParqueNatural.Name = "buttonParqueNatural";
            this.buttonParqueNatural.Size = new System.Drawing.Size(125, 50);
            this.buttonParqueNatural.TabIndex = 18;
            this.buttonParqueNatural.Text = "Parques Naturales";
            this.buttonParqueNatural.UseVisualStyleBackColor = true;
            this.buttonParqueNatural.Click += new System.EventHandler(this.button4_Click);
            // 
            // adm
            // 
            this.adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.adm.Location = new System.Drawing.Point(141, 151);
            this.adm.Name = "adm";
            this.adm.Size = new System.Drawing.Size(125, 50);
            this.adm.TabIndex = 14;
            this.adm.Text = "Áreas";
            this.adm.UseVisualStyleBackColor = true;
            this.adm.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonEspecie
            // 
            this.buttonEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonEspecie.Location = new System.Drawing.Point(141, 263);
            this.buttonEspecie.Name = "buttonEspecie";
            this.buttonEspecie.Size = new System.Drawing.Size(125, 50);
            this.buttonEspecie.TabIndex = 15;
            this.buttonEspecie.Text = "Especies";
            this.buttonEspecie.UseVisualStyleBackColor = true;
            this.buttonEspecie.Click += new System.EventHandler(this.button6_Click);
            // 
            // admExcursion
            // 
            this.admExcursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admExcursion.Location = new System.Drawing.Point(141, 319);
            this.admExcursion.Name = "admExcursion";
            this.admExcursion.Size = new System.Drawing.Size(125, 50);
            this.admExcursion.TabIndex = 19;
            this.admExcursion.Text = "Excursiones";
            this.admExcursion.UseVisualStyleBackColor = true;
            this.admExcursion.Click += new System.EventHandler(this.admExcursion_Click);
            // 
            // admProyecto
            // 
            this.admProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admProyecto.Location = new System.Drawing.Point(645, 263);
            this.admProyecto.Name = "admProyecto";
            this.admProyecto.Size = new System.Drawing.Size(125, 50);
            this.admProyecto.TabIndex = 20;
            this.admProyecto.Text = "Proyectos";
            this.admProyecto.UseVisualStyleBackColor = true;
            // 
            // admAlojamiento
            // 
            this.admAlojamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admAlojamiento.Location = new System.Drawing.Point(141, 95);
            this.admAlojamiento.Name = "admAlojamiento";
            this.admAlojamiento.Size = new System.Drawing.Size(125, 50);
            this.admAlojamiento.TabIndex = 21;
            this.admAlojamiento.Text = "Alojamiento";
            this.admAlojamiento.UseVisualStyleBackColor = true;
            this.admAlojamiento.Click += new System.EventHandler(this.admAlojamiento_Click);
            // 
            // admInvestigador
            // 
            this.admInvestigador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admInvestigador.Location = new System.Drawing.Point(141, 375);
            this.admInvestigador.Name = "admInvestigador";
            this.admInvestigador.Size = new System.Drawing.Size(125, 50);
            this.admInvestigador.TabIndex = 22;
            this.admInvestigador.Text = "Investigadores";
            this.admInvestigador.UseVisualStyleBackColor = true;
            this.admInvestigador.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // admTipoPersonal
            // 
            this.admTipoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admTipoPersonal.Location = new System.Drawing.Point(645, 319);
            this.admTipoPersonal.Name = "admTipoPersonal";
            this.admTipoPersonal.Size = new System.Drawing.Size(125, 50);
            this.admTipoPersonal.TabIndex = 23;
            this.admTipoPersonal.Text = "Tipo de Personal";
            this.admTipoPersonal.UseVisualStyleBackColor = true;
            // 
            // admPersonal
            // 
            this.admPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admPersonal.Location = new System.Drawing.Point(645, 207);
            this.admPersonal.Name = "admPersonal";
            this.admPersonal.Size = new System.Drawing.Size(125, 50);
            this.admPersonal.TabIndex = 24;
            this.admPersonal.Text = "Personal";
            this.admPersonal.UseVisualStyleBackColor = true;
            this.admPersonal.Click += new System.EventHandler(this.button1_Click);
            // 
            // admVisitante
            // 
            this.admVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.admVisitante.Location = new System.Drawing.Point(645, 375);
            this.admVisitante.Name = "admVisitante";
            this.admVisitante.Size = new System.Drawing.Size(125, 50);
            this.admVisitante.TabIndex = 25;
            this.admVisitante.Text = "Visitantes";
            this.admVisitante.UseVisualStyleBackColor = true;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.admVisitante);
            this.Controls.Add(this.admPersonal);
            this.Controls.Add(this.admTipoPersonal);
            this.Controls.Add(this.admInvestigador);
            this.Controls.Add(this.admAlojamiento);
            this.Controls.Add(this.admProyecto);
            this.Controls.Add(this.admExcursion);
            this.Controls.Add(this.buttonParqueNatural);
            this.Controls.Add(this.buttonComunidadAutonoma);
            this.Controls.Add(this.buttonOrganismo);
            this.Controls.Add(this.buttonEspecie);
            this.Controls.Add(this.adm);
            this.Controls.Add(this.buttonMenuAdmVolver);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.MenuAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenuAdmVolver;
        private System.Windows.Forms.Button buttonOrganismo;
        private System.Windows.Forms.Button buttonComunidadAutonoma;
        private System.Windows.Forms.Button buttonParqueNatural;
        private System.Windows.Forms.Button adm;
        private System.Windows.Forms.Button buttonEspecie;
        private System.Windows.Forms.Button admExcursion;
        private System.Windows.Forms.Button admProyecto;
        private System.Windows.Forms.Button admAlojamiento;
        private System.Windows.Forms.Button admInvestigador;
        private System.Windows.Forms.Button admTipoPersonal;
        private System.Windows.Forms.Button admPersonal;
        private System.Windows.Forms.Button admVisitante;
    }
}