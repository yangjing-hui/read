﻿
namespace read
{
    partial class login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文新魏", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(252, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎登录阅读管理系统！";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(407, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(407, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(525, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 44);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(525, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 44);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(413, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Checked = true;
            this.user.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user.Location = new System.Drawing.Point(439, 392);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(102, 40);
            this.user.TabIndex = 7;
            this.user.TabStop = true;
            this.user.Text = "用户";
            this.user.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.admin.Location = new System.Drawing.Point(724, 392);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(130, 40);
            this.admin.TabIndex = 8;
            this.admin.Text = "管理员";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(668, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "注册";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-40, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1389, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 722);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login1";
            this.Text = "阅读管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

