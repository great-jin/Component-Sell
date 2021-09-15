namespace ComponentSell
{
    partial class Main_Em
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Em));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.t2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.t4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.t6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm4_recovery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3_lock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3_pwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm3_power = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ts2_man = new System.Windows.Forms.ToolStripMenuItem();
            this.ts2_client = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm5_calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm5_note = new System.Windows.Forms.ToolStripMenuItem();
            this.iList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_check = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_done = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_order = new System.Windows.Forms.Button();
            this.bt_check = new System.Windows.Forms.Button();
            this.bt_sign = new System.Windows.Forms.Button();
            this.bt_storage = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.t2,
            this.toolStripStatusLabel3,
            this.t4,
            this.toolStripStatusLabel2,
            this.t6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(709, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "用户名:";
            // 
            // t2
            // 
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel3.Text = "职  别:";
            // 
            // t4
            // 
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(12, 17);
            this.t4.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "当前时间：";
            // 
            // t6
            // 
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm4,
            this.tsm3,
            this.tsm2,
            this.tsm5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm4
            // 
            this.tsm4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm4_backup,
            this.tsm4_recovery});
            this.tsm4.Name = "tsm4";
            this.tsm4.Size = new System.Drawing.Size(85, 21);
            this.tsm4.Text = "数据管理(&D)";
            // 
            // tsm4_backup
            // 
            this.tsm4_backup.Name = "tsm4_backup";
            this.tsm4_backup.Size = new System.Drawing.Size(124, 22);
            this.tsm4_backup.Text = "数据备份";
            this.tsm4_backup.Click += new System.EventHandler(this.tsm4_backup_Click);
            // 
            // tsm4_recovery
            // 
            this.tsm4_recovery.Name = "tsm4_recovery";
            this.tsm4_recovery.Size = new System.Drawing.Size(124, 22);
            this.tsm4_recovery.Text = "数据恢复";
            this.tsm4_recovery.Click += new System.EventHandler(this.tsm4_recovery_Click);
            // 
            // tsm3
            // 
            this.tsm3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm3_lock,
            this.tsm3_pwd,
            this.tsm3_power});
            this.tsm3.Name = "tsm3";
            this.tsm3.Size = new System.Drawing.Size(84, 21);
            this.tsm3.Text = "账号管理(&C)";
            // 
            // tsm3_lock
            // 
            this.tsm3_lock.Name = "tsm3_lock";
            this.tsm3_lock.Size = new System.Drawing.Size(124, 22);
            this.tsm3_lock.Text = "暂时离开";
            this.tsm3_lock.Click += new System.EventHandler(this.tsm3_lock_Click);
            // 
            // tsm3_pwd
            // 
            this.tsm3_pwd.Name = "tsm3_pwd";
            this.tsm3_pwd.Size = new System.Drawing.Size(124, 22);
            this.tsm3_pwd.Text = "修改密码";
            this.tsm3_pwd.Click += new System.EventHandler(this.tsm3_pwd_Click);
            // 
            // tsm3_power
            // 
            this.tsm3_power.Name = "tsm3_power";
            this.tsm3_power.Size = new System.Drawing.Size(124, 22);
            this.tsm3_power.Text = "修改权限";
            this.tsm3_power.Click += new System.EventHandler(this.tsm3_power_Click);
            // 
            // tsm2
            // 
            this.tsm2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts2_man,
            this.ts2_client});
            this.tsm2.Name = "tsm2";
            this.tsm2.Size = new System.Drawing.Size(85, 21);
            this.tsm2.Text = "人员信息(&H)";
            // 
            // ts2_man
            // 
            this.ts2_man.Name = "ts2_man";
            this.ts2_man.Size = new System.Drawing.Size(124, 22);
            this.ts2_man.Text = "员工信息";
            this.ts2_man.Click += new System.EventHandler(this.ts2_man_Click);
            // 
            // ts2_client
            // 
            this.ts2_client.Name = "ts2_client";
            this.ts2_client.Size = new System.Drawing.Size(124, 22);
            this.ts2_client.Text = "客户信息";
            this.ts2_client.Click += new System.EventHandler(this.ts2_client_Click);
            // 
            // tsm5
            // 
            this.tsm5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm5_calculate,
            this.tsm5_note});
            this.tsm5.Name = "tsm5";
            this.tsm5.Size = new System.Drawing.Size(83, 21);
            this.tsm5.Text = "辅助工具(&T)";
            // 
            // tsm5_calculate
            // 
            this.tsm5_calculate.Name = "tsm5_calculate";
            this.tsm5_calculate.Size = new System.Drawing.Size(112, 22);
            this.tsm5_calculate.Text = "计算器";
            this.tsm5_calculate.Click += new System.EventHandler(this.tsm5_calculate_Click);
            // 
            // tsm5_note
            // 
            this.tsm5_note.Name = "tsm5_note";
            this.tsm5_note.Size = new System.Drawing.Size(112, 22);
            this.tsm5_note.Text = "记事本";
            this.tsm5_note.Click += new System.EventHandler(this.tsm5_note_Click);
            // 
            // iList1
            // 
            this.iList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iList1.ImageStream")));
            this.iList1.TransparentColor = System.Drawing.Color.Transparent;
            this.iList1.Images.SetKeyName(0, "conpact.png");
            this.iList1.Images.SetKeyName(1, "conpact_act.png");
            this.iList1.Images.SetKeyName(2, "worn.png");
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.cms;
            this.listView1.LargeImageList = this.iList1;
            this.listView1.Location = new System.Drawing.Point(0, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 318);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_check,
            this.cms_done});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(125, 48);
            // 
            // cms_check
            // 
            this.cms_check.Name = "cms_check";
            this.cms_check.Size = new System.Drawing.Size(124, 22);
            this.cms_check.Text = "查看合同";
            this.cms_check.Click += new System.EventHandler(this.cms_check_Click);
            // 
            // cms_done
            // 
            this.cms_done.Name = "cms_done";
            this.cms_done.Size = new System.Drawing.Size(124, 22);
            this.cms_done.Text = "完成交付";
            this.cms_done.Click += new System.EventHandler(this.cms_done_Click);
            // 
            // bt_order
            // 
            this.bt_order.Location = new System.Drawing.Point(11, 20);
            this.bt_order.Name = "bt_order";
            this.bt_order.Size = new System.Drawing.Size(83, 40);
            this.bt_order.TabIndex = 0;
            this.bt_order.Text = "购物前台";
            this.bt_order.UseVisualStyleBackColor = true;
            this.bt_order.Click += new System.EventHandler(this.bt_order_Click);
            // 
            // bt_check
            // 
            this.bt_check.Location = new System.Drawing.Point(11, 78);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(83, 40);
            this.bt_check.TabIndex = 1;
            this.bt_check.Text = "订单审核";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // bt_sign
            // 
            this.bt_sign.Location = new System.Drawing.Point(11, 134);
            this.bt_sign.Name = "bt_sign";
            this.bt_sign.Size = new System.Drawing.Size(83, 40);
            this.bt_sign.TabIndex = 2;
            this.bt_sign.Text = "签署订单";
            this.bt_sign.UseVisualStyleBackColor = true;
            this.bt_sign.Click += new System.EventHandler(this.bt_sign_Click);
            // 
            // bt_storage
            // 
            this.bt_storage.Location = new System.Drawing.Point(11, 190);
            this.bt_storage.Name = "bt_storage";
            this.bt_storage.Size = new System.Drawing.Size(83, 40);
            this.bt_storage.TabIndex = 3;
            this.bt_storage.Text = "库存管理";
            this.bt_storage.UseVisualStyleBackColor = true;
            this.bt_storage.Click += new System.EventHandler(this.bt_storage_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(11, 308);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(83, 37);
            this.bt_quit.TabIndex = 4;
            this.bt_quit.Text = "退出";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox1.Controls.Add(this.bt_order);
            this.groupBox1.Controls.Add(this.bt_check);
            this.groupBox1.Controls.Add(this.bt_quit);
            this.groupBox1.Controls.Add(this.bt_sign);
            this.groupBox1.Controls.Add(this.bt_storage);
            this.groupBox1.Location = new System.Drawing.Point(591, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 356);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "灰色：已完成";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(172, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "红色：待交付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(324, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "感叹号：即将到期（离交付日 < 3天）";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 36);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Main_Em
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.ClientSize = new System.Drawing.Size(709, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Em";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎光临";
            this.Activated += new System.EventHandler(this.Main_Em_Activated);
            this.Load += new System.EventHandler(this.Main_Em_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel t2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel t4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel t6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm2;
        private System.Windows.Forms.ToolStripMenuItem tsm3;
        private System.Windows.Forms.ToolStripMenuItem tsm4;
        private System.Windows.Forms.ToolStripMenuItem tsm5;
        private System.Windows.Forms.ToolStripMenuItem tsm3_lock;
        private System.Windows.Forms.ToolStripMenuItem tsm3_pwd;
        private System.Windows.Forms.ToolStripMenuItem tsm3_power;
        private System.Windows.Forms.ToolStripMenuItem tsm5_calculate;
        private System.Windows.Forms.ToolStripMenuItem tsm5_note;
        private System.Windows.Forms.ToolStripMenuItem tsm4_backup;
        private System.Windows.Forms.ToolStripMenuItem tsm4_recovery;
        private System.Windows.Forms.ImageList iList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem ts2_man;
        private System.Windows.Forms.ToolStripMenuItem ts2_client;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cms_check;
        private System.Windows.Forms.ToolStripMenuItem cms_done;
        private System.Windows.Forms.Button bt_order;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Button bt_sign;
        private System.Windows.Forms.Button bt_storage;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}