﻿namespace ProyectoListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.columnNombreCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstadoCivil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Género:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado civil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(186, 65);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 5;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Divorciado",
            "Unión libre"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(334, 64);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoCivil.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(36, 65);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(124, 20);
            this.txtNombreCompleto.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(486, 64);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar a la lista";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombreCompleto,
            this.columnGenero,
            this.columnEstadoCivil,
            this.columnEdad});
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(36, 184);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(550, 113);
            this.listViewEstudiantes.TabIndex = 11;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // columnNombreCompleto
            // 
            this.columnNombreCompleto.Text = "Nombre completo";
            // 
            // columnGenero
            // 
            this.columnGenero.Text = "Género";
            // 
            // columnEstadoCivil
            // 
            this.columnEstadoCivil.Text = "Estado civil";
            // 
            // columnEdad
            // 
            this.columnEdad.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 316);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Datos de los estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.ColumnHeader columnNombreCompleto;
        private System.Windows.Forms.ColumnHeader columnGenero;
        private System.Windows.Forms.ColumnHeader columnEstadoCivil;
        private System.Windows.Forms.ColumnHeader columnEdad;
    }
}

