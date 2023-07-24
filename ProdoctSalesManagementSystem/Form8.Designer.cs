namespace ProdoctSalesManagementSystem
{
    partial class Trade_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UidBox = new System.Windows.Forms.TextBox();
            this.GidBox = new System.Windows.Forms.TextBox();
            this.SmountBox = new System.Windows.Forms.TextBox();
            this.Buy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数量";
            // 
            // UidBox
            // 
            this.UidBox.Location = new System.Drawing.Point(30, 40);
            this.UidBox.Name = "UidBox";
            this.UidBox.Size = new System.Drawing.Size(100, 21);
            this.UidBox.TabIndex = 3;
            // 
            // GidBox
            // 
            this.GidBox.Location = new System.Drawing.Point(173, 40);
            this.GidBox.Name = "GidBox";
            this.GidBox.Size = new System.Drawing.Size(100, 21);
            this.GidBox.TabIndex = 4;
            // 
            // SmountBox
            // 
            this.SmountBox.Location = new System.Drawing.Point(327, 40);
            this.SmountBox.Name = "SmountBox";
            this.SmountBox.Size = new System.Drawing.Size(100, 21);
            this.SmountBox.TabIndex = 5;
            // 
            // Buy_button
            // 
            this.Buy_button.Location = new System.Drawing.Point(163, 80);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(120, 23);
            this.Buy_button.TabIndex = 6;
            this.Buy_button.Text = "Buy";
            this.Buy_button.UseVisualStyleBackColor = true;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 115);
            this.Controls.Add(this.Buy_button);
            this.Controls.Add(this.SmountBox);
            this.Controls.Add(this.GidBox);
            this.Controls.Add(this.UidBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Trade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UidBox;
        private System.Windows.Forms.TextBox GidBox;
        private System.Windows.Forms.TextBox SmountBox;
        private System.Windows.Forms.Button Buy_button;
    }
}