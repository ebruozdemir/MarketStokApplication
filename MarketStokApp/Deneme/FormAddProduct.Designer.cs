namespace Deneme
{
    partial class FormAddProduct
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonCurrentAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SalePritext = new System.Windows.Forms.TextBox();
            this.Amounttext = new System.Windows.Forms.TextBox();
            this.PurcPritext = new System.Windows.Forms.TextBox();
            this.BarcodeNotext = new System.Windows.Forms.TextBox();
            this.Categorytext = new System.Windows.Forms.TextBox();
            this.ProdNameText = new System.Windows.Forms.TextBox();
            this.Brandtext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonNewAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxSalePri = new System.Windows.Forms.TextBox();
            this.textBoxPurcPri = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.textBarcodeNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAmount);
            this.groupBox2.Controls.Add(this.buttonCurrentAdd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.SalePritext);
            this.groupBox2.Controls.Add(this.Amounttext);
            this.groupBox2.Controls.Add(this.PurcPritext);
            this.groupBox2.Controls.Add(this.BarcodeNotext);
            this.groupBox2.Controls.Add(this.Categorytext);
            this.groupBox2.Controls.Add(this.ProdNameText);
            this.groupBox2.Controls.Add(this.Brandtext);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(716, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 512);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Product";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(27, 402);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(0, 25);
            this.labelAmount.TabIndex = 14;
            // 
            // buttonCurrentAdd
            // 
            this.buttonCurrentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCurrentAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonCurrentAdd.Location = new System.Drawing.Point(386, 400);
            this.buttonCurrentAdd.Name = "buttonCurrentAdd";
            this.buttonCurrentAdd.Size = new System.Drawing.Size(101, 33);
            this.buttonCurrentAdd.TabIndex = 3;
            this.buttonCurrentAdd.Text = "Add";
            this.buttonCurrentAdd.UseVisualStyleBackColor = true;
            this.buttonCurrentAdd.Click += new System.EventHandler(this.buttonCurrentAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(27, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sale Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lavender;
            this.label9.Location = new System.Drawing.Point(27, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Purchase Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(27, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Lavender;
            this.label11.Location = new System.Drawing.Point(27, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Product Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Lavender;
            this.label12.Location = new System.Drawing.Point(27, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Brand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Lavender;
            this.label13.Location = new System.Drawing.Point(27, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "Category";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Lavender;
            this.label14.Location = new System.Drawing.Point(27, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "Barcode Number";
            // 
            // SalePritext
            // 
            this.SalePritext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalePritext.ForeColor = System.Drawing.Color.RosyBrown;
            this.SalePritext.Location = new System.Drawing.Point(286, 318);
            this.SalePritext.Name = "SalePritext";
            this.SalePritext.Size = new System.Drawing.Size(201, 28);
            this.SalePritext.TabIndex = 8;
            // 
            // Amounttext
            // 
            this.Amounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Amounttext.ForeColor = System.Drawing.Color.RosyBrown;
            this.Amounttext.Location = new System.Drawing.Point(286, 224);
            this.Amounttext.Name = "Amounttext";
            this.Amounttext.Size = new System.Drawing.Size(201, 28);
            this.Amounttext.TabIndex = 6;
            // 
            // PurcPritext
            // 
            this.PurcPritext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PurcPritext.ForeColor = System.Drawing.Color.RosyBrown;
            this.PurcPritext.Location = new System.Drawing.Point(286, 271);
            this.PurcPritext.Name = "PurcPritext";
            this.PurcPritext.Size = new System.Drawing.Size(201, 28);
            this.PurcPritext.TabIndex = 7;
            // 
            // BarcodeNotext
            // 
            this.BarcodeNotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BarcodeNotext.ForeColor = System.Drawing.Color.RosyBrown;
            this.BarcodeNotext.Location = new System.Drawing.Point(286, 36);
            this.BarcodeNotext.Name = "BarcodeNotext";
            this.BarcodeNotext.Size = new System.Drawing.Size(201, 28);
            this.BarcodeNotext.TabIndex = 2;
            this.BarcodeNotext.TextChanged += new System.EventHandler(this.BarcodeNotext_TextChanged);
            // 
            // Categorytext
            // 
            this.Categorytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Categorytext.ForeColor = System.Drawing.Color.RosyBrown;
            this.Categorytext.Location = new System.Drawing.Point(286, 83);
            this.Categorytext.Name = "Categorytext";
            this.Categorytext.Size = new System.Drawing.Size(201, 28);
            this.Categorytext.TabIndex = 3;
            // 
            // ProdNameText
            // 
            this.ProdNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProdNameText.ForeColor = System.Drawing.Color.RosyBrown;
            this.ProdNameText.Location = new System.Drawing.Point(286, 177);
            this.ProdNameText.Name = "ProdNameText";
            this.ProdNameText.Size = new System.Drawing.Size(201, 28);
            this.ProdNameText.TabIndex = 5;
            // 
            // Brandtext
            // 
            this.Brandtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Brandtext.ForeColor = System.Drawing.Color.RosyBrown;
            this.Brandtext.Location = new System.Drawing.Point(286, 130);
            this.Brandtext.Name = "Brandtext";
            this.Brandtext.Size = new System.Drawing.Size(201, 28);
            this.Brandtext.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonNewAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBrand);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.textBoxSalePri);
            this.groupBox1.Controls.Add(this.textBoxPurcPri);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.textBoxProdName);
            this.groupBox1.Controls.Add(this.textBarcodeNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(131, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 512);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lavender;
            this.label7.Location = new System.Drawing.Point(43, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sale Price";
            // 
            // buttonNewAdd
            // 
            this.buttonNewAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNewAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonNewAdd.Location = new System.Drawing.Point(378, 393);
            this.buttonNewAdd.Name = "buttonNewAdd";
            this.buttonNewAdd.Size = new System.Drawing.Size(115, 34);
            this.buttonNewAdd.TabIndex = 2;
            this.buttonNewAdd.Text = "Add";
            this.buttonNewAdd.UseVisualStyleBackColor = true;
            this.buttonNewAdd.Click += new System.EventHandler(this.buttonNewAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(43, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(43, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(43, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(43, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barcode Number";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBrand.ForeColor = System.Drawing.Color.RosyBrown;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(247, 137);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(246, 30);
            this.comboBoxBrand.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.RosyBrown;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(247, 91);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(246, 30);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // textBoxSalePri
            // 
            this.textBoxSalePri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSalePri.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxSalePri.Location = new System.Drawing.Point(247, 318);
            this.textBoxSalePri.Name = "textBoxSalePri";
            this.textBoxSalePri.Size = new System.Drawing.Size(246, 28);
            this.textBoxSalePri.TabIndex = 4;
            // 
            // textBoxPurcPri
            // 
            this.textBoxPurcPri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPurcPri.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxPurcPri.Location = new System.Drawing.Point(247, 273);
            this.textBoxPurcPri.Name = "textBoxPurcPri";
            this.textBoxPurcPri.Size = new System.Drawing.Size(246, 28);
            this.textBoxPurcPri.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAmount.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxAmount.Location = new System.Drawing.Point(247, 228);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(246, 28);
            this.textBoxAmount.TabIndex = 2;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxProdName.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBoxProdName.Location = new System.Drawing.Point(247, 183);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(246, 28);
            this.textBoxProdName.TabIndex = 1;
            // 
            // textBarcodeNo
            // 
            this.textBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBarcodeNo.ForeColor = System.Drawing.Color.RosyBrown;
            this.textBarcodeNo.Location = new System.Drawing.Point(247, 46);
            this.textBarcodeNo.Name = "textBarcodeNo";
            this.textBarcodeNo.Size = new System.Drawing.Size(246, 28);
            this.textBarcodeNo.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label15.Location = new System.Drawing.Point(1189, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 35);
            this.label15.TabIndex = 14;
            this.label15.Text = "Back";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1279, 729);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonCurrentAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SalePritext;
        private System.Windows.Forms.TextBox Amounttext;
        private System.Windows.Forms.TextBox PurcPritext;
        private System.Windows.Forms.TextBox BarcodeNotext;
        private System.Windows.Forms.TextBox Categorytext;
        private System.Windows.Forms.TextBox ProdNameText;
        private System.Windows.Forms.TextBox Brandtext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNewAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxSalePri;
        private System.Windows.Forms.TextBox textBoxPurcPri;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxProdName;
        private System.Windows.Forms.TextBox textBarcodeNo;
        private System.Windows.Forms.Label label15;
    }
}