namespace ProdoctSalesManagementSystem
{
    partial class Goods_Manage_Form
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
            this.Gid = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.GidBox = new System.Windows.Forms.TextBox();
            this.GoodsOn = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_On_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search_Off_Button = new System.Windows.Forms.Button();
            this.Storeage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gcountbox = new System.Windows.Forms.TextBox();
            this.Sellingbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewForSale_Button = new System.Windows.Forms.Button();
            this.NewSalebox = new System.Windows.Forms.TextBox();
            this.OffSale_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OffSalebox = new System.Windows.Forms.TextBox();
            this.GoodsOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Gid
            // 
            this.Gid.AutoSize = true;
            this.Gid.Location = new System.Drawing.Point(236, 35);
            this.Gid.Name = "Gid";
            this.Gid.Size = new System.Drawing.Size(23, 12);
            this.Gid.TabIndex = 0;
            this.Gid.Text = "Gid";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(86, 22);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(89, 38);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // GidBox
            // 
            this.GidBox.Location = new System.Drawing.Point(279, 32);
            this.GidBox.Name = "GidBox";
            this.GidBox.Size = new System.Drawing.Size(100, 21);
            this.GidBox.TabIndex = 2;
            // 
            // GoodsOn
            // 
            this.GoodsOn.Controls.Add(this.dataGridView1);
            this.GoodsOn.Controls.Add(this.Search_On_Button);
            this.GoodsOn.Location = new System.Drawing.Point(44, 133);
            this.GoodsOn.Name = "GoodsOn";
            this.GoodsOn.Size = new System.Drawing.Size(337, 305);
            this.GoodsOn.TabIndex = 5;
            this.GoodsOn.TabStop = false;
            this.GoodsOn.Text = "Goods On Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(321, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // Search_On_Button
            // 
            this.Search_On_Button.Location = new System.Drawing.Point(10, 20);
            this.Search_On_Button.Name = "Search_On_Button";
            this.Search_On_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_On_Button.TabIndex = 0;
            this.Search_On_Button.Text = "Search";
            this.Search_On_Button.UseVisualStyleBackColor = true;
            this.Search_On_Button.Click += new System.EventHandler(this.Search_On_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.Search_Off_Button);
            this.groupBox2.Location = new System.Drawing.Point(413, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 305);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Goods Off Record";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(354, 249);
            this.dataGridView2.TabIndex = 1;
            // 
            // Search_Off_Button
            // 
            this.Search_Off_Button.Location = new System.Drawing.Point(15, 20);
            this.Search_Off_Button.Name = "Search_Off_Button";
            this.Search_Off_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Off_Button.TabIndex = 0;
            this.Search_Off_Button.Text = "Search";
            this.Search_Off_Button.UseVisualStyleBackColor = true;
            this.Search_Off_Button.Click += new System.EventHandler(this.Search_Off_Button_Click);
            // 
            // Storeage
            // 
            this.Storeage.AutoSize = true;
            this.Storeage.Location = new System.Drawing.Point(52, 97);
            this.Storeage.Name = "Storeage";
            this.Storeage.Size = new System.Drawing.Size(53, 12);
            this.Storeage.TabIndex = 7;
            this.Storeage.Text = "Storeage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selling";
            // 
            // Gcountbox
            // 
            this.Gcountbox.Location = new System.Drawing.Point(111, 94);
            this.Gcountbox.Name = "Gcountbox";
            this.Gcountbox.Size = new System.Drawing.Size(100, 21);
            this.Gcountbox.TabIndex = 9;
            // 
            // Sellingbox
            // 
            this.Sellingbox.Location = new System.Drawing.Point(279, 94);
            this.Sellingbox.Name = "Sellingbox";
            this.Sellingbox.Size = new System.Drawing.Size(100, 21);
            this.Sellingbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Count";
            // 
            // NewForSale_Button
            // 
            this.NewForSale_Button.Location = new System.Drawing.Point(453, 30);
            this.NewForSale_Button.Name = "NewForSale_Button";
            this.NewForSale_Button.Size = new System.Drawing.Size(108, 23);
            this.NewForSale_Button.TabIndex = 12;
            this.NewForSale_Button.Text = "New For Sale";
            this.NewForSale_Button.UseVisualStyleBackColor = true;
            this.NewForSale_Button.Click += new System.EventHandler(this.NewForSale_Button_Click);
            // 
            // NewSalebox
            // 
            this.NewSalebox.Location = new System.Drawing.Point(620, 32);
            this.NewSalebox.Name = "NewSalebox";
            this.NewSalebox.Size = new System.Drawing.Size(100, 21);
            this.NewSalebox.TabIndex = 13;
            // 
            // OffSale_Button
            // 
            this.OffSale_Button.Location = new System.Drawing.Point(453, 85);
            this.OffSale_Button.Name = "OffSale_Button";
            this.OffSale_Button.Size = new System.Drawing.Size(108, 23);
            this.OffSale_Button.TabIndex = 14;
            this.OffSale_Button.Text = "Off The Shelves";
            this.OffSale_Button.UseVisualStyleBackColor = true;
            this.OffSale_Button.Click += new System.EventHandler(this.OffSale_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Count";
            // 
            // OffSalebox
            // 
            this.OffSalebox.Location = new System.Drawing.Point(620, 85);
            this.OffSalebox.Name = "OffSalebox";
            this.OffSalebox.Size = new System.Drawing.Size(100, 21);
            this.OffSalebox.TabIndex = 16;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OffSalebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OffSale_Button);
            this.Controls.Add(this.NewSalebox);
            this.Controls.Add(this.NewForSale_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sellingbox);
            this.Controls.Add(this.Gcountbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Storeage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GoodsOn);
            this.Controls.Add(this.GidBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Gid);
            this.Name = "Form7";
            this.Text = "GoodsManage";
            this.GoodsOn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gid;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox GidBox;
        private System.Windows.Forms.GroupBox GoodsOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Storeage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Gcountbox;
        private System.Windows.Forms.TextBox Sellingbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search_On_Button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Search_Off_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewForSale_Button;
        private System.Windows.Forms.TextBox NewSalebox;
        private System.Windows.Forms.Button OffSale_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OffSalebox;
    }
}