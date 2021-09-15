namespace ComponentSell
{
    partial class Main_Ce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Ce));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ts4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_amend = new System.Windows.Forms.Button();
            this.bt_order = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_pay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ts2,
            this.toolStripStatusLabel3,
            this.ts4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(499, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "用户名:";
            // 
            // ts2
            // 
            this.ts2.Name = "ts2";
            this.ts2.Size = new System.Drawing.Size(25, 17);
            this.ts2.Text = "ts2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "当前时间:";
            // 
            // ts4
            // 
            this.ts4.Name = "ts4";
            this.ts4.Size = new System.Drawing.Size(25, 17);
            this.ts4.Text = "ts4";
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_login.Location = new System.Drawing.Point(19, 297);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(73, 34);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "退出";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_amend
            // 
            this.bt_amend.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_amend.Location = new System.Drawing.Point(19, 142);
            this.bt_amend.Name = "bt_amend";
            this.bt_amend.Size = new System.Drawing.Size(73, 34);
            this.bt_amend.TabIndex = 2;
            this.bt_amend.Text = "修改密码";
            this.bt_amend.UseVisualStyleBackColor = true;
            this.bt_amend.Click += new System.EventHandler(this.bt_amend_Click);
            // 
            // bt_order
            // 
            this.bt_order.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_order.Location = new System.Drawing.Point(19, 20);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(73, 34);
            this.bt_order.TabIndex = 1;
            this.bt_order.Text = "选购产品";
            this.bt_order.UseVisualStyleBackColor = true;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox1.Controls.Add(this.bt_pay);
            this.groupBox1.Controls.Add(this.bt_order);
            this.groupBox1.Controls.Add(this.bt_amend);
            this.groupBox1.Controls.Add(this.bt_login);
            this.groupBox1.Location = new System.Drawing.Point(379, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // bt_pay
            // 
            this.bt_pay.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_pay.Location = new System.Drawing.Point(19, 80);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(73, 37);
            this.bt_pay.TabIndex = 4;
            this.bt_pay.Text = "支付订单";
            this.bt_pay.UseVisualStyleBackColor = true;
            this.bt_pay.Click += new System.EventHandler(this.bt_pay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Ce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.ClientSize = new System.Drawing.Size(499, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Main_Ce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Ce";
            this.Load += new System.EventHandler(this.Main_Ce_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_amend;
        private System.Windows.Forms.Button bt_order;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ts2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ts4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_pay;
    }
}