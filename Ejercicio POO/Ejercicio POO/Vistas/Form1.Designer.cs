namespace Ejercicio_POO
{
    partial class Form1
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
            this.lb_transportes = new System.Windows.Forms.ListBox();
            this.cb_tipodetransporte = new System.Windows.Forms.ComboBox();
            this.lbl_transportes = new System.Windows.Forms.Label();
            this.nupd_cantidadpasajeros = new System.Windows.Forms.NumericUpDown();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_cantidadpasajeros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_cantidadpasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_transportes
            // 
            this.lb_transportes.FormattingEnabled = true;
            this.lb_transportes.Location = new System.Drawing.Point(12, 12);
            this.lb_transportes.Name = "lb_transportes";
            this.lb_transportes.Size = new System.Drawing.Size(255, 264);
            this.lb_transportes.TabIndex = 0;
            // 
            // cb_tipodetransporte
            // 
            this.cb_tipodetransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipodetransporte.FormattingEnabled = true;
            this.cb_tipodetransporte.Items.AddRange(new object[] {
            "Omnibus",
            "Taxi"});
            this.cb_tipodetransporte.Location = new System.Drawing.Point(277, 59);
            this.cb_tipodetransporte.Name = "cb_tipodetransporte";
            this.cb_tipodetransporte.Size = new System.Drawing.Size(164, 21);
            this.cb_tipodetransporte.TabIndex = 1;
            this.cb_tipodetransporte.TextChanged += new System.EventHandler(this.cb_tipodetransporte_TextChanged);
            // 
            // lbl_transportes
            // 
            this.lbl_transportes.AutoSize = true;
            this.lbl_transportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transportes.Location = new System.Drawing.Point(273, 37);
            this.lbl_transportes.Name = "lbl_transportes";
            this.lbl_transportes.Size = new System.Drawing.Size(120, 19);
            this.lbl_transportes.TabIndex = 2;
            this.lbl_transportes.Text = "Tipo de transporte";
            // 
            // nupd_cantidadpasajeros
            // 
            this.nupd_cantidadpasajeros.Location = new System.Drawing.Point(277, 129);
            this.nupd_cantidadpasajeros.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupd_cantidadpasajeros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupd_cantidadpasajeros.Name = "nupd_cantidadpasajeros";
            this.nupd_cantidadpasajeros.Size = new System.Drawing.Size(120, 20);
            this.nupd_cantidadpasajeros.TabIndex = 3;
            this.nupd_cantidadpasajeros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(301, 193);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(117, 57);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_cantidadpasajeros
            // 
            this.lbl_cantidadpasajeros.AutoSize = true;
            this.lbl_cantidadpasajeros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadpasajeros.Location = new System.Drawing.Point(273, 107);
            this.lbl_cantidadpasajeros.Name = "lbl_cantidadpasajeros";
            this.lbl_cantidadpasajeros.Size = new System.Drawing.Size(145, 19);
            this.lbl_cantidadpasajeros.TabIndex = 5;
            this.lbl_cantidadpasajeros.Text = "Cantidad de pasajeros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 303);
            this.Controls.Add(this.lbl_cantidadpasajeros);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.nupd_cantidadpasajeros);
            this.Controls.Add(this.lbl_transportes);
            this.Controls.Add(this.cb_tipodetransporte);
            this.Controls.Add(this.lb_transportes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_cantidadpasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_transportes;
        private System.Windows.Forms.ComboBox cb_tipodetransporte;
        private System.Windows.Forms.Label lbl_transportes;
        private System.Windows.Forms.NumericUpDown nupd_cantidadpasajeros;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_cantidadpasajeros;
    }
}

