﻿namespace ProdoctSalesManagementSystem
{
    partial class GoodsAdd_Form
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
            this.components = new System.ComponentModel.Container();
            this.pSMSDataSet = new ProdoctSalesManagementSystem.PSMSDataSet();
            this.pSMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gidbox = new System.Windows.Forms.TextBox();
            this.Gareabox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.Gnamebox = new System.Windows.Forms.TextBox();
            this.Gicidbox = new System.Windows.Forms.TextBox();
            this.Inventorybox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pSMSDataSet
            // 
            this.pSMSDataSet.DataSetName = "PSMSDataSet";
            this.pSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pSMSDataSetBindingSource
            // 
            this.pSMSDataSetBindingSource.DataSource = this.pSMSDataSet;
            this.pSMSDataSetBindingSource.Position = 0;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(11, 12);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(87, 31);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Garea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gicid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "Inventory";
            // 
            // Gidbox
            // 
            this.Gidbox.Location = new System.Drawing.Point(202, 18);
            this.Gidbox.Name = "Gidbox";
            this.Gidbox.Size = new System.Drawing.Size(100, 21);
            this.Gidbox.TabIndex = 8;
            // 
            // Gareabox
            // 
            this.Gareabox.Location = new System.Drawing.Point(60, 88);
            this.Gareabox.Name = "Gareabox";
            this.Gareabox.Size = new System.Drawing.Size(100, 21);
            this.Gareabox.TabIndex = 9;
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(60, 120);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.Size = new System.Drawing.Size(100, 21);
            this.Pricebox.TabIndex = 10;
            // 
            // Gnamebox
            // 
            this.Gnamebox.Location = new System.Drawing.Point(60, 55);
            this.Gnamebox.Name = "Gnamebox";
            this.Gnamebox.Size = new System.Drawing.Size(100, 21);
            this.Gnamebox.TabIndex = 11;
            // 
            // Gicidbox
            // 
            this.Gicidbox.Location = new System.Drawing.Point(266, 88);
            this.Gicidbox.Name = "Gicidbox";
            this.Gicidbox.Size = new System.Drawing.Size(100, 21);
            this.Gicidbox.TabIndex = 12;
            // 
            // Inventorybox
            // 
            this.Inventorybox.Location = new System.Drawing.Point(266, 120);
            this.Inventorybox.Name = "Inventorybox";
            this.Inventorybox.Size = new System.Drawing.Size(100, 21);
            this.Inventorybox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Category";
            // 
            // CategoryBox
            // 
            this.CategoryBox.Location = new System.Drawing.Point(266, 55);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(100, 21);
            this.CategoryBox.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 179);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Inventorybox);
            this.Controls.Add(this.Gicidbox);
            this.Controls.Add(this.Gnamebox);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.Gareabox);
            this.Controls.Add(this.Gidbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Button);
            this.Name = "Form2";
            this.Text = "Goods Add";
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PSMSDataSet pSMSDataSet;
        private System.Windows.Forms.BindingSource pSMSDataSetBindingSource;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Gidbox;
        private System.Windows.Forms.TextBox Gareabox;
        private System.Windows.Forms.TextBox Pricebox;
        private System.Windows.Forms.TextBox Gnamebox;
        private System.Windows.Forms.TextBox Gicidbox;
        private System.Windows.Forms.TextBox Inventorybox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CategoryBox;
    }
}