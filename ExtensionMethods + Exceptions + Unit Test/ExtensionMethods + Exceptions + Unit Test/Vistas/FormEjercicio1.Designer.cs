namespace ExtensionMethods___Exceptions___Unit_Test.Vistas
{
    partial class FormEjercicio1
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.nupd_valorunico = new System.Windows.Forms.NumericUpDown();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_valorunico)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(51, 89);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(138, 65);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // nupd_valorunico
            // 
            this.nupd_valorunico.Location = new System.Drawing.Point(16, 47);
            this.nupd_valorunico.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nupd_valorunico.Name = "nupd_valorunico";
            this.nupd_valorunico.Size = new System.Drawing.Size(161, 20);
            this.nupd_valorunico.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(177, 19);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Ingrese un valor para dividir";
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 179);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.nupd_valorunico);
            this.Controls.Add(this.btn_calcular);
            this.Name = "FormEjercicio1";
            this.Text = "FormEjercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_valorunico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.NumericUpDown nupd_valorunico;
        private System.Windows.Forms.Label lbl_titulo;
    }
}