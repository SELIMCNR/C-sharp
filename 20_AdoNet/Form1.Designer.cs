namespace _20_AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.stockamounttbx = new System.Windows.Forms.TextBox();
            this.lblStockAmounadd = new System.Windows.Forms.Label();
            this.unitepricetbx = new System.Windows.Forms.TextBox();
            this.lblUnitpriceadd = new System.Windows.Forms.Label();
            this.nametbx = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Txt_StockUpdate = new System.Windows.Forms.TextBox();
            this.LblStcokAmountUpdate = new System.Windows.Forms.Label();
            this.Txt_UnitUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.Txt_NameUpdate = new System.Windows.Forms.TextBox();
            this.LblNameupdate = new System.Windows.Forms.Label();
            this.Btn_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(63, 88);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(571, 214);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            this.dgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.stockamounttbx);
            this.groupBox1.Controls.Add(this.lblStockAmounadd);
            this.groupBox1.Controls.Add(this.unitepricetbx);
            this.groupBox1.Controls.Add(this.lblUnitpriceadd);
            this.groupBox1.Controls.Add(this.nametbx);
            this.groupBox1.Controls.Add(this.lblAddName);
            this.groupBox1.Location = new System.Drawing.Point(63, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a prdocut";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // stockamounttbx
            // 
            this.stockamounttbx.Location = new System.Drawing.Point(103, 62);
            this.stockamounttbx.Name = "stockamounttbx";
            this.stockamounttbx.Size = new System.Drawing.Size(100, 20);
            this.stockamounttbx.TabIndex = 1;
            // 
            // lblStockAmounadd
            // 
            this.lblStockAmounadd.AutoSize = true;
            this.lblStockAmounadd.Location = new System.Drawing.Point(29, 70);
            this.lblStockAmounadd.Name = "lblStockAmounadd";
            this.lblStockAmounadd.Size = new System.Drawing.Size(71, 13);
            this.lblStockAmounadd.TabIndex = 0;
            this.lblStockAmounadd.Text = "StockAmount";
            // 
            // unitepricetbx
            // 
            this.unitepricetbx.Location = new System.Drawing.Point(103, 36);
            this.unitepricetbx.Name = "unitepricetbx";
            this.unitepricetbx.Size = new System.Drawing.Size(100, 20);
            this.unitepricetbx.TabIndex = 1;
            // 
            // lblUnitpriceadd
            // 
            this.lblUnitpriceadd.AutoSize = true;
            this.lblUnitpriceadd.Location = new System.Drawing.Point(29, 44);
            this.lblUnitpriceadd.Name = "lblUnitpriceadd";
            this.lblUnitpriceadd.Size = new System.Drawing.Size(50, 13);
            this.lblUnitpriceadd.TabIndex = 0;
            this.lblUnitpriceadd.Text = "UnitPrice";
            // 
            // nametbx
            // 
            this.nametbx.Location = new System.Drawing.Point(103, 10);
            this.nametbx.Name = "nametbx";
            this.nametbx.Size = new System.Drawing.Size(100, 20);
            this.nametbx.TabIndex = 1;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(29, 18);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(35, 13);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Update);
            this.groupBox2.Controls.Add(this.Txt_StockUpdate);
            this.groupBox2.Controls.Add(this.LblStcokAmountUpdate);
            this.groupBox2.Controls.Add(this.Txt_UnitUpdate);
            this.groupBox2.Controls.Add(this.lblUnitPriceUpdate);
            this.groupBox2.Controls.Add(this.Txt_NameUpdate);
            this.groupBox2.Controls.Add(this.LblNameupdate);
            this.groupBox2.Location = new System.Drawing.Point(343, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update a prdocut";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(103, 89);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(100, 23);
            this.Btn_Update.TabIndex = 2;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Txt_StockUpdate
            // 
            this.Txt_StockUpdate.Location = new System.Drawing.Point(103, 62);
            this.Txt_StockUpdate.Name = "Txt_StockUpdate";
            this.Txt_StockUpdate.Size = new System.Drawing.Size(100, 20);
            this.Txt_StockUpdate.TabIndex = 1;
            // 
            // LblStcokAmountUpdate
            // 
            this.LblStcokAmountUpdate.AutoSize = true;
            this.LblStcokAmountUpdate.Location = new System.Drawing.Point(29, 70);
            this.LblStcokAmountUpdate.Name = "LblStcokAmountUpdate";
            this.LblStcokAmountUpdate.Size = new System.Drawing.Size(71, 13);
            this.LblStcokAmountUpdate.TabIndex = 0;
            this.LblStcokAmountUpdate.Text = "StockAmount";
            // 
            // Txt_UnitUpdate
            // 
            this.Txt_UnitUpdate.Location = new System.Drawing.Point(103, 36);
            this.Txt_UnitUpdate.Name = "Txt_UnitUpdate";
            this.Txt_UnitUpdate.Size = new System.Drawing.Size(100, 20);
            this.Txt_UnitUpdate.TabIndex = 1;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(29, 44);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(50, 13);
            this.lblUnitPriceUpdate.TabIndex = 0;
            this.lblUnitPriceUpdate.Text = "UnitPrice";
            // 
            // Txt_NameUpdate
            // 
            this.Txt_NameUpdate.Location = new System.Drawing.Point(103, 10);
            this.Txt_NameUpdate.Name = "Txt_NameUpdate";
            this.Txt_NameUpdate.Size = new System.Drawing.Size(100, 20);
            this.Txt_NameUpdate.TabIndex = 1;
            // 
            // LblNameupdate
            // 
            this.LblNameupdate.AutoSize = true;
            this.LblNameupdate.Location = new System.Drawing.Point(29, 18);
            this.LblNameupdate.Name = "LblNameupdate";
            this.LblNameupdate.Size = new System.Drawing.Size(35, 13);
            this.LblNameupdate.TabIndex = 0;
            this.LblNameupdate.Text = "Name";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(63, 41);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove.TabIndex = 2;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox stockamounttbx;
        private System.Windows.Forms.Label lblStockAmounadd;
        private System.Windows.Forms.TextBox unitepricetbx;
        private System.Windows.Forms.Label lblUnitpriceadd;
        private System.Windows.Forms.TextBox nametbx;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox Txt_StockUpdate;
        private System.Windows.Forms.Label LblStcokAmountUpdate;
        private System.Windows.Forms.TextBox Txt_UnitUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox Txt_NameUpdate;
        private System.Windows.Forms.Label LblNameupdate;
        private System.Windows.Forms.Button Btn_Remove;
    }
}

