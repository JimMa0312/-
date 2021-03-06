﻿namespace ARCSoftFaceApp.CameraManage
{
    partial class CameraManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraManageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonLognIn = new System.Windows.Forms.Button();
            this.buttonLognOut = new System.Windows.Forms.Button();
            this.buttonPlayReal = new System.Windows.Forms.Button();
            this.buttonStopReal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxViewIndex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(73, 42);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(100, 21);
            this.textBoxIp.TabIndex = 1;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(73, 100);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 21);
            this.textBoxUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(284, 45);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 21);
            this.textBoxPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "端口";
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(284, 103);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(100, 21);
            this.textBoxPwd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "密码";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(441, 42);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(113, 82);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonLognIn
            // 
            this.buttonLognIn.Location = new System.Drawing.Point(441, 157);
            this.buttonLognIn.Name = "buttonLognIn";
            this.buttonLognIn.Size = new System.Drawing.Size(113, 23);
            this.buttonLognIn.TabIndex = 9;
            this.buttonLognIn.Text = "登录";
            this.buttonLognIn.UseVisualStyleBackColor = true;
            this.buttonLognIn.Click += new System.EventHandler(this.buttonLognIn_Click);
            // 
            // buttonLognOut
            // 
            this.buttonLognOut.Enabled = false;
            this.buttonLognOut.Location = new System.Drawing.Point(441, 202);
            this.buttonLognOut.Name = "buttonLognOut";
            this.buttonLognOut.Size = new System.Drawing.Size(113, 23);
            this.buttonLognOut.TabIndex = 10;
            this.buttonLognOut.Text = "注销";
            this.buttonLognOut.UseCompatibleTextRendering = true;
            this.buttonLognOut.UseVisualStyleBackColor = true;
            this.buttonLognOut.Click += new System.EventHandler(this.buttonLognOut_Click);
            // 
            // buttonPlayReal
            // 
            this.buttonPlayReal.Location = new System.Drawing.Point(306, 157);
            this.buttonPlayReal.Name = "buttonPlayReal";
            this.buttonPlayReal.Size = new System.Drawing.Size(102, 23);
            this.buttonPlayReal.TabIndex = 11;
            this.buttonPlayReal.Text = "开始预览";
            this.buttonPlayReal.UseVisualStyleBackColor = true;
            this.buttonPlayReal.Click += new System.EventHandler(this.buttonPlayReal_Click);
            // 
            // buttonStopReal
            // 
            this.buttonStopReal.Location = new System.Drawing.Point(306, 202);
            this.buttonStopReal.Name = "buttonStopReal";
            this.buttonStopReal.Size = new System.Drawing.Size(102, 23);
            this.buttonStopReal.TabIndex = 12;
            this.buttonStopReal.Text = "停止预览";
            this.buttonStopReal.UseVisualStyleBackColor = true;
            this.buttonStopReal.Click += new System.EventHandler(this.buttonStopReal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "预览窗口";
            // 
            // comboBoxViewIndex
            // 
            this.comboBoxViewIndex.FormattingEnabled = true;
            this.comboBoxViewIndex.Location = new System.Drawing.Point(85, 154);
            this.comboBoxViewIndex.Name = "comboBoxViewIndex";
            this.comboBoxViewIndex.Size = new System.Drawing.Size(121, 20);
            this.comboBoxViewIndex.TabIndex = 15;
            // 
            // CameraManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 278);
            this.Controls.Add(this.comboBoxViewIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonStopReal);
            this.Controls.Add(this.buttonPlayReal);
            this.Controls.Add(this.buttonLognOut);
            this.Controls.Add(this.buttonLognIn);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraManageForm";
            this.Text = "添加设备";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonLognIn;
        private System.Windows.Forms.Button buttonLognOut;
        private System.Windows.Forms.Button buttonPlayReal;
        private System.Windows.Forms.Button buttonStopReal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxViewIndex;
    }
}