namespace ExtensionMethods___Exceptions___Unit_Test.Vistas
{
    partial class FormEjercicio3
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
            this.btn_verexcepcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_verexcepcion
            // 
            this.btn_verexcepcion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verexcepcion.Location = new System.Drawing.Point(39, 33);
            this.btn_verexcepcion.Name = "btn_verexcepcion";
            this.btn_verexcepcion.Size = new System.Drawing.Size(145, 71);
            this.btn_verexcepcion.TabIndex = 0;
            this.btn_verexcepcion.Text = "Ver excepcion";
            this.btn_verexcepcion.UseVisualStyleBackColor = true;
            this.btn_verexcepcion.Click += new System.EventHandler(this.btn_verexcepcion_Click);
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 140);
            this.Controls.Add(this.btn_verexcepcion);
            this.Name = "FormEjercicio3";
            this.Text = "FormEjercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_verexcepcion;
    }
}