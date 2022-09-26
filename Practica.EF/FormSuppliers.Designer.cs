namespace Practica.EF.UI
{
    partial class FormSuppliers
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
            this.dgv_Suppliers = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Region = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.txt_ContactTitle = new System.Windows.Forms.TextBox();
            this.txt_Fax = new System.Windows.Forms.TextBox();
            this.txt_ContactName = new System.Windows.Forms.TextBox();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_HomePage = new System.Windows.Forms.TextBox();
            this.npd_SupplierID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npd_SupplierID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Suppliers
            // 
            this.dgv_Suppliers.AllowUserToAddRows = false;
            this.dgv_Suppliers.AllowUserToDeleteRows = false;
            this.dgv_Suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Suppliers.Location = new System.Drawing.Point(0, 0);
            this.dgv_Suppliers.Name = "dgv_Suppliers";
            this.dgv_Suppliers.ReadOnly = true;
            this.dgv_Suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Suppliers.Size = new System.Drawing.Size(800, 227);
            this.dgv_Suppliers.TabIndex = 0;
            this.dgv_Suppliers.Click += new System.EventHandler(this.dgv_Suppliers_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(689, 299);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 51);
            this.btn_Delete.TabIndex = 54;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(579, 337);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 43);
            this.btn_Clear.TabIndex = 53;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(562, 392);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(121, 43);
            this.btn_aceptar.TabIndex = 52;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Fax";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Region";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Contact Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Contact Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Add or modify data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "SupplierID";
            // 
            // txt_Region
            // 
            this.txt_Region.Location = new System.Drawing.Point(284, 299);
            this.txt_Region.Name = "txt_Region";
            this.txt_Region.Size = new System.Drawing.Size(100, 20);
            this.txt_Region.TabIndex = 39;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(284, 404);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(100, 20);
            this.txt_Country.TabIndex = 38;
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Location = new System.Drawing.Point(284, 355);
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(100, 20);
            this.txt_PostalCode.TabIndex = 37;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(153, 404);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(100, 20);
            this.txt_City.TabIndex = 36;
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(153, 355);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(100, 20);
            this.txt_Adress.TabIndex = 35;
            // 
            // txt_ContactTitle
            // 
            this.txt_ContactTitle.Location = new System.Drawing.Point(153, 299);
            this.txt_ContactTitle.Name = "txt_ContactTitle";
            this.txt_ContactTitle.Size = new System.Drawing.Size(100, 20);
            this.txt_ContactTitle.TabIndex = 34;
            // 
            // txt_Fax
            // 
            this.txt_Fax.Location = new System.Drawing.Point(425, 355);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(100, 20);
            this.txt_Fax.TabIndex = 33;
            // 
            // txt_ContactName
            // 
            this.txt_ContactName.Location = new System.Drawing.Point(17, 404);
            this.txt_ContactName.Name = "txt_ContactName";
            this.txt_ContactName.Size = new System.Drawing.Size(100, 20);
            this.txt_ContactName.TabIndex = 32;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(17, 355);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(100, 20);
            this.txt_CompanyName.TabIndex = 31;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(425, 299);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 20);
            this.txt_Phone.TabIndex = 30;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(689, 373);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(99, 62);
            this.btn_Close.TabIndex = 28;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Home Page";
            // 
            // txt_HomePage
            // 
            this.txt_HomePage.Location = new System.Drawing.Point(425, 404);
            this.txt_HomePage.Name = "txt_HomePage";
            this.txt_HomePage.Size = new System.Drawing.Size(100, 20);
            this.txt_HomePage.TabIndex = 55;
            // 
            // npd_SupplierID
            // 
            this.npd_SupplierID.Location = new System.Drawing.Point(17, 299);
            this.npd_SupplierID.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.npd_SupplierID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npd_SupplierID.Name = "npd_SupplierID";
            this.npd_SupplierID.Size = new System.Drawing.Size(100, 20);
            this.npd_SupplierID.TabIndex = 57;
            this.npd_SupplierID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.npd_SupplierID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_HomePage);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Region);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_PostalCode);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.txt_ContactTitle);
            this.Controls.Add(this.txt_Fax);
            this.Controls.Add(this.txt_ContactName);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_Suppliers);
            this.Name = "FormSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npd_SupplierID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Suppliers;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Region;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.TextBox txt_PostalCode;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.TextBox txt_ContactTitle;
        private System.Windows.Forms.TextBox txt_Fax;
        private System.Windows.Forms.TextBox txt_ContactName;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_HomePage;
        private System.Windows.Forms.NumericUpDown npd_SupplierID;
    }
}

