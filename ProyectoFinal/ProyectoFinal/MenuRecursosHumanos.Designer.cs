﻿namespace ProyectoFinal
{
    partial class MenuRecursosHumanos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRecursosHumanos));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMenuRHVolver = new System.Windows.Forms.Button();
            this.rhPersonal = new System.Windows.Forms.Button();
            this.rhTipoPersonal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(326, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // buttonMenuRHVolver
            // 
            this.buttonMenuRHVolver.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMenuRHVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenuAdmVolver.BackgroundImage")));
            this.buttonMenuRHVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuRHVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuRHVolver.Location = new System.Drawing.Point(12, 12);
            this.buttonMenuRHVolver.Name = "buttonMenuAdmVolver";
            this.buttonMenuRHVolver.Size = new System.Drawing.Size(67, 60);
            this.buttonMenuRHVolver.TabIndex = 16;
            this.buttonMenuRHVolver.UseVisualStyleBackColor = false;
            this.buttonMenuRHVolver.Click += new System.EventHandler(this.buttonMenuRHVolver_Click);
            // 
            // rhPersonal
            // 
            this.rhPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rhPersonal.Location = new System.Drawing.Point(92, 240);
            this.rhPersonal.Name = "rhPersonal";
            this.rhPersonal.Size = new System.Drawing.Size(125, 50);
            this.rhPersonal.TabIndex = 22;
            this.rhPersonal.Text = "Personal";
            this.rhPersonal.UseVisualStyleBackColor = true;
            this.rhPersonal.Click += new System.EventHandler(this.rhPersonal_Click);
            // 
            // rhTipoPersonal
            // 
            this.rhTipoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rhTipoPersonal.Location = new System.Drawing.Point(657, 240);
            this.rhTipoPersonal.Name = "rhTipoPersonal";
            this.rhTipoPersonal.Size = new System.Drawing.Size(125, 50);
            this.rhTipoPersonal.TabIndex = 23;
            this.rhTipoPersonal.Text = "Tipo de Personal";
            this.rhTipoPersonal.UseVisualStyleBackColor = true;
            this.rhTipoPersonal.Click += new System.EventHandler(this.rhTipoPersonal_Click);
            // 
            // MenuRecursosHumanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.rhTipoPersonal);
            this.Controls.Add(this.rhPersonal);
            this.Controls.Add(this.buttonMenuRHVolver);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MenuRecursosHumanos";
            this.Text = "MenuRecursosHumanos";
            this.Load += new System.EventHandler(this.MenuRecursosHumanos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMenuRHVolver;
        private System.Windows.Forms.Button rhPersonal;
        private System.Windows.Forms.Button rhTipoPersonal;
    }
}