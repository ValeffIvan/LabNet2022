namespace Practica.Linq.UI
{
    partial class FormData
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
            this.cb_ejercicios = new System.Windows.Forms.ComboBox();
            this.dgv_ejercicios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ejercicios
            // 
            this.cb_ejercicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ejercicios.FormattingEnabled = true;
            this.cb_ejercicios.Items.AddRange(new object[] {
            "Ejercicio 1",
            "Ejercicio 2",
            "Ejercicio 3",
            "Ejercicio 4",
            "Ejercicio 5",
            "Ejercicio 6",
            "Ejercicio 7",
            "Ejercicio 8",
            "Ejercicio 9",
            "Ejercicio 10",
            "Ejercicio 11",
            "Ejercicio 12",
            "Ejercicio 13"});
            this.cb_ejercicios.Location = new System.Drawing.Point(12, 12);
            this.cb_ejercicios.Name = "cb_ejercicios";
            this.cb_ejercicios.Size = new System.Drawing.Size(162, 21);
            this.cb_ejercicios.TabIndex = 0;
            this.cb_ejercicios.TextUpdate += new System.EventHandler(this.cb_ejercicios_TextUpdate);
            // 
            // dgv_ejercicios
            // 
            this.dgv_ejercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ejercicios.Location = new System.Drawing.Point(0, 61);
            this.dgv_ejercicios.Name = "dgv_ejercicios";
            this.dgv_ejercicios.Size = new System.Drawing.Size(800, 388);
            this.dgv_ejercicios.TabIndex = 1;
            // 
            // FormData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ejercicios);
            this.Controls.Add(this.cb_ejercicios);
            this.Name = "FormData";
            this.Text = "FormData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ejercicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ejercicios;
        private System.Windows.Forms.DataGridView dgv_ejercicios;
    }
}