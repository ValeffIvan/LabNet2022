﻿namespace ExtensionMethods___Exceptions___Unit_Test.Vistas
{
    partial class FormEjercicio2
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
            this.nupd_numero1 = new System.Windows.Forms.NumericUpDown();
            this.nupd_numero2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_numero1 = new System.Windows.Forms.Label();
            this.lbl_numero2 = new System.Windows.Forms.Label();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_numero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_numero2)).BeginInit();
            this.SuspendLayout();
            // 
            // nupd_numero1
            // 
            this.nupd_numero1.Location = new System.Drawing.Point(54, 85);
            this.nupd_numero1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nupd_numero1.Name = "nupd_numero1";
            this.nupd_numero1.Size = new System.Drawing.Size(120, 20);
            this.nupd_numero1.TabIndex = 0;
            // 
            // nupd_numero2
            // 
            this.nupd_numero2.Location = new System.Drawing.Point(54, 136);
            this.nupd_numero2.Name = "nupd_numero2";
            this.nupd_numero2.Size = new System.Drawing.Size(120, 20);
            this.nupd_numero2.TabIndex = 1;
            // 
            // lbl_numero1
            // 
            this.lbl_numero1.AutoSize = true;
            this.lbl_numero1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero1.Location = new System.Drawing.Point(50, 63);
            this.lbl_numero1.Name = "lbl_numero1";
            this.lbl_numero1.Size = new System.Drawing.Size(71, 19);
            this.lbl_numero1.TabIndex = 2;
            this.lbl_numero1.Text = "Numero 1";
            // 
            // lbl_numero2
            // 
            this.lbl_numero2.AutoSize = true;
            this.lbl_numero2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero2.Location = new System.Drawing.Point(50, 114);
            this.lbl_numero2.Name = "lbl_numero2";
            this.lbl_numero2.Size = new System.Drawing.Size(71, 19);
            this.lbl_numero2.TabIndex = 3;
            this.lbl_numero2.Text = "Numero 2";
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_dividir.Location = new System.Drawing.Point(35, 183);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(157, 55);
            this.btn_dividir.TabIndex = 4;
            this.btn_dividir.Text = "Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(22, 28);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(182, 19);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Seleccione numero a dividir: ";
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 266);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.lbl_numero2);
            this.Controls.Add(this.lbl_numero1);
            this.Controls.Add(this.nupd_numero2);
            this.Controls.Add(this.nupd_numero1);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEjercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_numero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_numero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupd_numero1;
        private System.Windows.Forms.NumericUpDown nupd_numero2;
        private System.Windows.Forms.Label lbl_numero1;
        private System.Windows.Forms.Label lbl_numero2;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Label lbl_titulo;
    }
}