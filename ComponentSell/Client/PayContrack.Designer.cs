namespace ComponentSell
{
    partial class PayContrack
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.lb_charge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_recieve = new System.Windows.Forms.TextBox();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 316);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_count);
            this.groupBox1.Controls.Add(this.lb_charge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_recieve);
            this.groupBox1.Controls.Add(this.bt_quit);
            this.groupBox1.Controls.Add(this.bt_pay);
            this.groupBox1.Location = new System.Drawing.Point(339, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 326);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "找零：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "收款：";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.BackColor = System.Drawing.Color.Transparent;
            this.lb_count.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_count.Location = new System.Drawing.Point(100, 38);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(40, 16);
            this.lb_count.TabIndex = 2;
            this.lb_count.Text = "    ";
            // 
            // lb_charge
            // 
            this.lb_charge.AutoSize = true;
            this.lb_charge.BackColor = System.Drawing.Color.Transparent;
            this.lb_charge.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_charge.Location = new System.Drawing.Point(100, 167);
            this.lb_charge.Name = "lb_charge";
            this.lb_charge.Size = new System.Drawing.Size(40, 16);
            this.lb_charge.TabIndex = 2;
            this.lb_charge.Text = "    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "总计：";
            // 
            // txt_recieve
            // 
            this.txt_recieve.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_recieve.Location = new System.Drawing.Point(103, 97);
            this.txt_recieve.Name = "txt_recieve";
            this.txt_recieve.Size = new System.Drawing.Size(100, 26);
            this.txt_recieve.TabIndex = 1;
            this.txt_recieve.TextChanged += new System.EventHandler(this.txt_recieve_TextChanged);
            this.txt_recieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_recieve_KeyPress);
            // 
            // bt_quit
            // 
            this.bt_quit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_quit.Location = new System.Drawing.Point(140, 240);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(76, 36);
            this.bt_quit.TabIndex = 0;
            this.bt_quit.Text = "退出";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // bt_pay
            // 
            this.bt_pay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_pay.Location = new System.Drawing.Point(24, 240);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(76, 36);
            this.bt_pay.TabIndex = 0;
            this.bt_pay.Text = "支付";
            this.bt_pay.UseVisualStyleBackColor = true;
            this.bt_pay.Click += new System.EventHandler(this.bt_pay_Click);
            // 
            // PayContrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ComponentSell.Properties.Resources.bg_03;
            this.ClientSize = new System.Drawing.Size(587, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "PayContrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayContrack";
            this.Load += new System.EventHandler(this.PayContrack_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_charge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_recieve;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_pay;
        private System.Windows.Forms.Label lb_count;
    }
}