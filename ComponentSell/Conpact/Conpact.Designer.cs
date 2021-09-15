namespace ComponentSell
{
    partial class Conpact
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_sell = new System.Windows.Forms.ComboBox();
            this.cmb_check = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_amend = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSellMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CClient,
            this.CList,
            this.CPrice,
            this.COTime,
            this.CGTime,
            this.CStatus,
            this.CPay,
            this.CSellMan,
            this.CCheck,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(809, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.cmb_client);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmb_sell);
            this.groupBox1.Controls.Add(this.cmb_check);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 74);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 21);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(225, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "下 单 日：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "状  态：";
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "待交付",
            "已交付"});
            this.cmb_status.Location = new System.Drawing.Point(79, 75);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(114, 20);
            this.cmb_status.TabIndex = 6;
            // 
            // cmb_client
            // 
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(79, 29);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.Size = new System.Drawing.Size(114, 20);
            this.cmb_client.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // cmb_sell
            // 
            this.cmb_sell.FormattingEnabled = true;
            this.cmb_sell.Location = new System.Drawing.Point(79, 117);
            this.cmb_sell.Name = "cmb_sell";
            this.cmb_sell.Size = new System.Drawing.Size(114, 20);
            this.cmb_sell.TabIndex = 3;
            // 
            // cmb_check
            // 
            this.cmb_check.FormattingEnabled = true;
            this.cmb_check.Location = new System.Drawing.Point(79, 156);
            this.cmb_check.Name = "cmb_check";
            this.cmb_check.Size = new System.Drawing.Size(114, 20);
            this.cmb_check.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(17, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "审核员:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(17, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "销售员:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(227, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "交付时间:";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_price.Location = new System.Drawing.Point(308, 27);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(109, 23);
            this.txt_price.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(227, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "总    价:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "客  户:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox2.Controls.Add(this.bt_quit);
            this.groupBox2.Controls.Add(this.bt_del);
            this.groupBox2.Controls.Add(this.bt_amend);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Controls.Add(this.bt_search);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // bt_quit
            // 
            this.bt_quit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_quit.Location = new System.Drawing.Point(707, 20);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(81, 38);
            this.bt_quit.TabIndex = 0;
            this.bt_quit.Text = "退出";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // bt_del
            // 
            this.bt_del.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_del.Location = new System.Drawing.Point(407, 20);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(81, 38);
            this.bt_del.TabIndex = 0;
            this.bt_del.Text = "删除";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_amend
            // 
            this.bt_amend.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_amend.Location = new System.Drawing.Point(279, 20);
            this.bt_amend.Name = "bt_amend";
            this.bt_amend.Size = new System.Drawing.Size(81, 38);
            this.bt_amend.TabIndex = 0;
            this.bt_amend.Text = "修改";
            this.bt_amend.UseVisualStyleBackColor = true;
            this.bt_amend.Click += new System.EventHandler(this.bt_amend_Click);
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_add.Location = new System.Drawing.Point(151, 20);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(81, 38);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_search.Location = new System.Drawing.Point(20, 20);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(81, 38);
            this.bt_search.TabIndex = 0;
            this.bt_search.Text = "查询";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(453, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 172);
            this.listBox1.TabIndex = 3;
            // 
            // CClient
            // 
            this.CClient.DataPropertyName = "CClient";
            this.CClient.HeaderText = "客户";
            this.CClient.Name = "CClient";
            // 
            // CList
            // 
            this.CList.DataPropertyName = "CList";
            this.CList.HeaderText = "产品";
            this.CList.Name = "CList";
            // 
            // CPrice
            // 
            this.CPrice.DataPropertyName = "CPrice";
            this.CPrice.HeaderText = "总价";
            this.CPrice.Name = "CPrice";
            // 
            // COTime
            // 
            this.COTime.DataPropertyName = "COTime";
            this.COTime.HeaderText = "下单时间";
            this.COTime.Name = "COTime";
            // 
            // CGTime
            // 
            this.CGTime.DataPropertyName = "CGTime";
            this.CGTime.HeaderText = "交付时间";
            this.CGTime.Name = "CGTime";
            // 
            // CStatus
            // 
            this.CStatus.DataPropertyName = "CStatus";
            this.CStatus.HeaderText = "交付状态";
            this.CStatus.Name = "CStatus";
            // 
            // CPay
            // 
            this.CPay.DataPropertyName = "CPay";
            this.CPay.HeaderText = "支付状态";
            this.CPay.Name = "CPay";
            // 
            // CSellMan
            // 
            this.CSellMan.DataPropertyName = "CSellMan";
            this.CSellMan.HeaderText = "销售员";
            this.CSellMan.Name = "CSellMan";
            // 
            // CCheck
            // 
            this.CCheck.DataPropertyName = "CCheck";
            this.CCheck.HeaderText = "审核员";
            this.CCheck.Name = "CCheck";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Conpact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.ClientSize = new System.Drawing.Size(833, 509);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Conpact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compact";
            this.Load += new System.EventHandler(this.Conpact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_sell;
        private System.Windows.Forms.ComboBox cmb_check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_amend;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}