namespace ProdoctSalesManagementSystem
{
    partial class User_Manage_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pSMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSMSDataSet = new ProdoctSalesManagementSystem.PSMSDataSet();
            this.User_Add_button = new System.Windows.Forms.Button();
            this.User_search_button = new System.Windows.Forms.Button();
            this.UidBox = new System.Windows.Forms.TextBox();
            this.TradeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(444, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // pSMSDataSetBindingSource
            // 
            this.pSMSDataSetBindingSource.DataSource = this.pSMSDataSet;
            this.pSMSDataSetBindingSource.Position = 0;
            // 
            // pSMSDataSet
            // 
            this.pSMSDataSet.DataSetName = "PSMSDataSet";
            this.pSMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // User_Add_button
            // 
            this.User_Add_button.Location = new System.Drawing.Point(140, 13);
            this.User_Add_button.Name = "User_Add_button";
            this.User_Add_button.Size = new System.Drawing.Size(139, 42);
            this.User_Add_button.TabIndex = 1;
            this.User_Add_button.Text = "User Add";
            this.User_Add_button.UseVisualStyleBackColor = true;
            this.User_Add_button.Click += new System.EventHandler(this.User_Add_button_Click);
            // 
            // User_search_button
            // 
            this.User_search_button.Location = new System.Drawing.Point(13, 81);
            this.User_search_button.Name = "User_search_button";
            this.User_search_button.Size = new System.Drawing.Size(121, 41);
            this.User_search_button.TabIndex = 2;
            this.User_search_button.Text = "Search";
            this.User_search_button.UseVisualStyleBackColor = true;
            this.User_search_button.Click += new System.EventHandler(this.User_search_button_Click);
            // 
            // UidBox
            // 
            this.UidBox.Location = new System.Drawing.Point(13, 128);
            this.UidBox.Name = "UidBox";
            this.UidBox.Size = new System.Drawing.Size(121, 21);
            this.UidBox.TabIndex = 3;
            // 
            // TradeButton
            // 
            this.TradeButton.Location = new System.Drawing.Point(366, 13);
            this.TradeButton.Name = "TradeButton";
            this.TradeButton.Size = new System.Drawing.Size(123, 42);
            this.TradeButton.TabIndex = 4;
            this.TradeButton.Text = "Trade";
            this.TradeButton.UseVisualStyleBackColor = true;
            this.TradeButton.Click += new System.EventHandler(this.Trade_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.TradeButton);
            this.Controls.Add(this.UidBox);
            this.Controls.Add(this.User_search_button);
            this.Controls.Add(this.User_Add_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pSMSDataSetBindingSource;
        private PSMSDataSet pSMSDataSet;
        private System.Windows.Forms.Button User_Add_button;
        private System.Windows.Forms.Button User_search_button;
        private System.Windows.Forms.TextBox UidBox;
        private System.Windows.Forms.Button TradeButton;
    }
}