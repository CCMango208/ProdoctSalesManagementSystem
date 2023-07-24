namespace ProdoctSalesManagementSystem
{
    partial class Goods_Info_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.GidBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gnamebox = new System.Windows.Forms.TextBox();
            this.Pricebox = new System.Windows.Forms.TextBox();
            this.Gareabox = new System.Windows.Forms.TextBox();
            this.Categroybox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.countBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // GidBox
            // 
            this.GidBox.Location = new System.Drawing.Point(301, 36);
            this.GidBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GidBox.Name = "GidBox";
            this.GidBox.Size = new System.Drawing.Size(135, 25);
            this.GidBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Garea";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Categroy";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 364);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 169);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Gnamebox
            // 
            this.Gnamebox.Location = new System.Drawing.Point(117, 112);
            this.Gnamebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gnamebox.Name = "Gnamebox";
            this.Gnamebox.ReadOnly = true;
            this.Gnamebox.Size = new System.Drawing.Size(132, 25);
            this.Gnamebox.TabIndex = 10;
            // 
            // Pricebox
            // 
            this.Pricebox.Location = new System.Drawing.Point(337, 112);
            this.Pricebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pricebox.Name = "Pricebox";
            this.Pricebox.ReadOnly = true;
            this.Pricebox.Size = new System.Drawing.Size(132, 25);
            this.Pricebox.TabIndex = 11;
            // 
            // Gareabox
            // 
            this.Gareabox.Location = new System.Drawing.Point(337, 191);
            this.Gareabox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gareabox.Name = "Gareabox";
            this.Gareabox.ReadOnly = true;
            this.Gareabox.Size = new System.Drawing.Size(132, 25);
            this.Gareabox.TabIndex = 14;
            // 
            // Categroybox
            // 
            this.Categroybox.Location = new System.Drawing.Point(117, 192);
            this.Categroybox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Categroybox.Name = "Categroybox";
            this.Categroybox.ReadOnly = true;
            this.Categroybox.Size = new System.Drawing.Size(132, 25);
            this.Categroybox.TabIndex = 15;
            this.Categroybox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Picture";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 309);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "Goods in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Goodsin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "count";
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(279, 311);
            this.countBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(132, 25);
            this.countBox.TabIndex = 19;
            // 
            // Goods_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 562);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Categroybox);
            this.Controls.Add(this.Gareabox);
            this.Controls.Add(this.Pricebox);
            this.Controls.Add(this.Gnamebox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GidBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Goods_Info_Form";
            this.Text = "Goods Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GidBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Gnamebox;
        private System.Windows.Forms.TextBox Pricebox;
        private System.Windows.Forms.TextBox Gareabox;
        private System.Windows.Forms.TextBox Categroybox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countBox;
    }
}