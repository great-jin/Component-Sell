namespace ComponentSell
{
    partial class Employee
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.cmb_occp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_seach = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_amend = new System.Windows.Forms.Button();
            this.EmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_depart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_name.Location = new System.Drawing.Point(66, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(119, 23);
            this.txt_name.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmName,
            this.EmGender,
            this.EmTel,
            this.EmType,
            this.EmDepart,
            this.EmAdress,
            this.EmNote,
            this.ID});
            this.dgv.Location = new System.Drawing.Point(12, 226);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(644, 231);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(444, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "电话:";
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tel.Location = new System.Drawing.Point(492, 20);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(127, 23);
            this.txt_tel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "职位:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(233, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "部门:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "家庭住址:";
            // 
            // txt_adress
            // 
            this.txt_adress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_adress.Location = new System.Drawing.Point(88, 107);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(531, 23);
            this.txt_adress.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(444, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "备注:";
            // 
            // txt_memo
            // 
            this.txt_memo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_memo.Location = new System.Drawing.Point(491, 68);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(128, 23);
            this.txt_memo.TabIndex = 2;
            // 
            // cmb_sex
            // 
            this.cmb_sex.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb_sex.Location = new System.Drawing.Point(281, 20);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(119, 22);
            this.cmb_sex.TabIndex = 4;
            // 
            // cmb_occp
            // 
            this.cmb_occp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_occp.FormattingEnabled = true;
            this.cmb_occp.Items.AddRange(new object[] {
            "员工",
            "科长"});
            this.cmb_occp.Location = new System.Drawing.Point(66, 65);
            this.cmb_occp.Name = "cmb_occp";
            this.cmb_occp.Size = new System.Drawing.Size(119, 22);
            this.cmb_occp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(233, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox1.Controls.Add(this.txt_adress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.cmb_depart);
            this.groupBox1.Controls.Add(this.cmb_occp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_sex);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_memo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 145);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox2.Controls.Add(this.bt_quit);
            this.groupBox2.Controls.Add(this.bt_add);
            this.groupBox2.Controls.Add(this.bt_seach);
            this.groupBox2.Controls.Add(this.bt_del);
            this.groupBox2.Controls.Add(this.bt_amend);
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 57);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(535, 20);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(75, 29);
            this.bt_quit.TabIndex = 5;
            this.bt_quit.Text = "退出";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(147, 20);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 29);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "添加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_seach
            // 
            this.bt_seach.Location = new System.Drawing.Point(17, 20);
            this.bt_seach.Name = "bt_seach";
            this.bt_seach.Size = new System.Drawing.Size(75, 29);
            this.bt_seach.TabIndex = 5;
            this.bt_seach.Text = "查询";
            this.bt_seach.UseVisualStyleBackColor = true;
            this.bt_seach.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(412, 20);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(75, 29);
            this.bt_del.TabIndex = 5;
            this.bt_del.Text = "删除";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // bt_amend
            // 
            this.bt_amend.Location = new System.Drawing.Point(282, 20);
            this.bt_amend.Name = "bt_amend";
            this.bt_amend.Size = new System.Drawing.Size(75, 29);
            this.bt_amend.TabIndex = 5;
            this.bt_amend.Text = "修改";
            this.bt_amend.UseVisualStyleBackColor = true;
            this.bt_amend.Click += new System.EventHandler(this.bt_amend_Click);
            // 
            // EmName
            // 
            this.EmName.DataPropertyName = "EmName";
            this.EmName.HeaderText = "姓名";
            this.EmName.Name = "EmName";
            // 
            // EmGender
            // 
            this.EmGender.DataPropertyName = "EmGender";
            this.EmGender.HeaderText = "性别";
            this.EmGender.Name = "EmGender";
            // 
            // EmTel
            // 
            this.EmTel.DataPropertyName = "EmTel";
            this.EmTel.HeaderText = "电话";
            this.EmTel.Name = "EmTel";
            // 
            // EmType
            // 
            this.EmType.DataPropertyName = "EmType";
            this.EmType.HeaderText = "职位";
            this.EmType.Name = "EmType";
            // 
            // EmDepart
            // 
            this.EmDepart.DataPropertyName = "EmDepart";
            this.EmDepart.HeaderText = "部门";
            this.EmDepart.Name = "EmDepart";
            // 
            // EmAdress
            // 
            this.EmAdress.DataPropertyName = "EmAdress";
            this.EmAdress.HeaderText = "家庭住址";
            this.EmAdress.Name = "EmAdress";
            // 
            // EmNote
            // 
            this.EmNote.DataPropertyName = "EmNote";
            this.EmNote.HeaderText = "备注";
            this.EmNote.Name = "EmNote";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // cmb_depart
            // 
            this.cmb_depart.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_depart.FormattingEnabled = true;
            this.cmb_depart.Items.AddRange(new object[] {
            "销售科",
            "计划科",
            "财务科"});
            this.cmb_depart.Location = new System.Drawing.Point(281, 67);
            this.cmb_depart.Name = "cmb_depart";
            this.cmb_depart.Size = new System.Drawing.Size(119, 22);
            this.cmb_depart.TabIndex = 4;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.ClientSize = new System.Drawing.Size(667, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_memo;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_occp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_seach;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_amend;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.ComboBox cmb_depart;
    }
}