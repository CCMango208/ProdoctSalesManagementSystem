namespace ProdoctSalesManagementSystem
{
    partial class Main_Prodoct
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Prodoct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GoodsManage = new System.Windows.Forms.Button();
            this.UserManage_Button = new System.Windows.Forms.Button();
            this.GoodsInfo_Button = new System.Windows.Forms.Button();
            this.AddGoods_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pSMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSMSDataSet = new ProdoctSalesManagementSystem.PSMSDataSet();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GoodsManage);
            this.groupBox1.Controls.Add(this.UserManage_Button);
            this.groupBox1.Controls.Add(this.GoodsInfo_Button);
            this.groupBox1.Controls.Add(this.AddGoods_Button);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // GoodsManage
            // 
            resources.ApplyResources(this.GoodsManage, "GoodsManage");
            this.GoodsManage.Name = "GoodsManage";
            this.GoodsManage.UseVisualStyleBackColor = true;
            this.GoodsManage.Click += new System.EventHandler(this.GoodsManage_Click);
            // 
            // UserManage_Button
            // 
            resources.ApplyResources(this.UserManage_Button, "UserManage_Button");
            this.UserManage_Button.Name = "UserManage_Button";
            this.UserManage_Button.UseVisualStyleBackColor = true;
            this.UserManage_Button.Click += new System.EventHandler(this.UserManage_Button_Click);
            // 
            // GoodsInfo_Button
            // 
            resources.ApplyResources(this.GoodsInfo_Button, "GoodsInfo_Button");
            this.GoodsInfo_Button.Name = "GoodsInfo_Button";
            this.GoodsInfo_Button.UseVisualStyleBackColor = true;
            this.GoodsInfo_Button.Click += new System.EventHandler(this.GoodsInfo_Button_Click);
            // 
            // AddGoods_Button
            // 
            resources.ApplyResources(this.AddGoods_Button, "AddGoods_Button");
            this.AddGoods_Button.Name = "AddGoods_Button";
            this.AddGoods_Button.UseVisualStyleBackColor = true;
            this.AddGoods_Button.Click += new System.EventHandler(this.AddGoods_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // SearchButton
            // 
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchText
            // 
            resources.ApplyResources(this.SearchText, "SearchText");
            this.SearchText.Name = "SearchText";
            // 
            // Main_Prodoct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_Prodoct";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UserManage_Button;
        private System.Windows.Forms.Button GoodsInfo_Button;
        private System.Windows.Forms.Button AddGoods_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pSMSDataSetBindingSource;
        private PSMSDataSet pSMSDataSet;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button GoodsManage;
    }
}

