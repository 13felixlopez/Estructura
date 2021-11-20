
namespace Ordenamiento_Interno_Felix_Lopez
{
    partial class Intercalacion_de_Archivos
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.F2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dgvF2 = new System.Windows.Forms.DataGridView();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvF1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAsignarValor = new System.Windows.Forms.Button();
            this.gbDato = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvF1)).BeginInit();
            this.gbMostrar.SuspendLayout();
            this.gbDato.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(176, 491);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 35);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNuevoRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(16, 491);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(151, 35);
            this.btnNuevoRegistro.TabIndex = 17;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = false;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click_1);
            // 
            // F2
            // 
            this.F2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F2.HeaderText = "Archivo F2";
            this.F2.Name = "F2";
            this.F2.ReadOnly = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnOrdenar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrdenar.Location = new System.Drawing.Point(102, 21);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(143, 37);
            this.btnOrdenar.TabIndex = 7;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // dgvF2
            // 
            this.dgvF2.AllowUserToAddRows = false;
            this.dgvF2.AllowUserToDeleteRows = false;
            this.dgvF2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dgvF2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvF2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F2});
            this.dgvF2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dgvF2.Location = new System.Drawing.Point(170, 62);
            this.dgvF2.Name = "dgvF2";
            this.dgvF2.ReadOnly = true;
            this.dgvF2.Size = new System.Drawing.Size(150, 172);
            this.dgvF2.TabIndex = 5;
            // 
            // c
            // 
            this.c.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c.HeaderText = "Archivo F1";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            // 
            // dgvF1
            // 
            this.dgvF1.AllowUserToAddRows = false;
            this.dgvF1.AllowUserToDeleteRows = false;
            this.dgvF1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dgvF1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvF1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c});
            this.dgvF1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dgvF1.Location = new System.Drawing.Point(6, 62);
            this.dgvF1.Name = "dgvF1";
            this.dgvF1.ReadOnly = true;
            this.dgvF1.Size = new System.Drawing.Size(155, 172);
            this.dgvF1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(281, 491);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbMostrar
            // 
            this.gbMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbMostrar.Controls.Add(this.dgvF1);
            this.gbMostrar.Controls.Add(this.btnOrdenar);
            this.gbMostrar.Controls.Add(this.dgvF2);
            this.gbMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbMostrar.Location = new System.Drawing.Point(6, 241);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(350, 244);
            this.gbMostrar.TabIndex = 16;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Mostrar";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(74, 36);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(116, 26);
            this.txtDato.TabIndex = 3;
            // 
            // btnAsignarValor
            // 
            this.btnAsignarValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAsignarValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsignarValor.Location = new System.Drawing.Point(194, 32);
            this.btnAsignarValor.Name = "btnAsignarValor";
            this.btnAsignarValor.Size = new System.Drawing.Size(120, 30);
            this.btnAsignarValor.TabIndex = 7;
            this.btnAsignarValor.Text = "Aceptar";
            this.btnAsignarValor.UseVisualStyleBackColor = false;
            this.btnAsignarValor.Click += new System.EventHandler(this.btnAsignarValor_Click);
            // 
            // gbDato
            // 
            this.gbDato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbDato.Controls.Add(this.txtDato);
            this.gbDato.Controls.Add(this.btnAsignarValor);
            this.gbDato.Controls.Add(this.label1);
            this.gbDato.Enabled = false;
            this.gbDato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDato.Location = new System.Drawing.Point(16, 145);
            this.gbDato.Name = "gbDato";
            this.gbDato.Size = new System.Drawing.Size(330, 90);
            this.gbDato.TabIndex = 15;
            this.gbDato.TabStop = false;
            this.gbDato.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.btnCrearArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCrearArchivo.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCrearArchivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearArchivo.Location = new System.Drawing.Point(69, 6);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(204, 37);
            this.btnCrearArchivo.TabIndex = 13;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = false;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCantidad.Location = new System.Drawing.Point(193, 28);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(121, 30);
            this.btnCantidad.TabIndex = 2;
            this.btnCantidad.Text = "Aceptar";
            this.btnCantidad.UseVisualStyleBackColor = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(53, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 26);
            this.txtCantidad.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbDatos.Controls.Add(this.btnCantidad);
            this.gbDatos.Controls.Add(this.txtCantidad);
            this.gbDatos.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDatos.Location = new System.Drawing.Point(16, 49);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(330, 90);
            this.gbDatos.TabIndex = 14;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Cantidad Elementos:";
            // 
            // Intercalacion_de_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(362, 532);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbMostrar);
            this.Controls.Add(this.gbDato);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.gbDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intercalacion_de_Archivos";
            this.Text = "Intercalacion_de_Archivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvF1)).EndInit();
            this.gbMostrar.ResumeLayout(false);
            this.gbDato.ResumeLayout(false);
            this.gbDato.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn F2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dgvF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridView dgvF1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAsignarValor;
        private System.Windows.Forms.GroupBox gbDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox gbDatos;
    }
}