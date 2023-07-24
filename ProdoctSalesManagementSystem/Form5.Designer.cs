namespace ProdoctSalesManagementSystem
{
    partial class User_Add_Form
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
            this.User_add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UidBox = new System.Windows.Forms.TextBox();
            this.UnameBox = new System.Windows.Forms.TextBox();
            this.UcallBox = new System.Windows.Forms.TextBox();
            this.UaddrBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // User_add_button
            // 
            this.User_add_button.Location = new System.Drawing.Point(12, 12);
            this.User_add_button.Name = "User_add_button";
            this.User_add_button.Size = new System.Drawing.Size(92, 37);
            this.User_add_button.TabIndex = 1;
            this.User_add_button.Text = "Add";
            this.User_add_button.UseVisualStyleBackColor = true;
            this.User_add_button.Click += new System.EventHandler(this.User_add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ucall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Uaddr";
            // 
            // UidBox
            // 
            this.UidBox.Location = new System.Drawing.Point(12, 80);
            this.UidBox.Name = "UidBox";
            this.UidBox.Size = new System.Drawing.Size(100, 21);
            this.UidBox.TabIndex = 6;
            // 
            // UnameBox
            // 
            this.UnameBox.Location = new System.Drawing.Point(132, 80);
            this.UnameBox.Name = "UnameBox";
            this.UnameBox.Size = new System.Drawing.Size(100, 21);
            this.UnameBox.TabIndex = 7;
            // 
            // UcallBox
            // 
            this.UcallBox.Location = new System.Drawing.Point(258, 80);
            this.UcallBox.Name = "UcallBox";
            this.UcallBox.Size = new System.Drawing.Size(100, 21);
            this.UcallBox.TabIndex = 8;
            // 
            // UaddrBox
            // 
            this.UaddrBox.Location = new System.Drawing.Point(379, 80);
            this.UaddrBox.Name = "UaddrBox";
            this.UaddrBox.Size = new System.Drawing.Size(100, 21);
            this.UaddrBox.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 118);
            this.Controls.Add(this.UaddrBox);
            this.Controls.Add(this.UcallBox);
            this.Controls.Add(this.UnameBox);
            this.Controls.Add(this.UidBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User_add_button);
            this.Name = "Form5";
            this.Text = "User Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button User_add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UidBox;
        private System.Windows.Forms.TextBox UnameBox;
        private System.Windows.Forms.TextBox UcallBox;
        private System.Windows.Forms.TextBox UaddrBox;
    }
}