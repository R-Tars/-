﻿namespace Garbagemanage.User
{
    partial class FrmEmployeeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkState = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmiaoshu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttRe = new System.Windows.Forms.Button();
            this.buttok = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtEmpTypled = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmpIDnumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblerr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttDel = new System.Windows.Forms.Button();
            this.chkShowDel = new System.Windows.Forms.CheckBox();
            this.buttRemove = new System.Windows.Forms.Button();
            this.buttRecover = new System.Windows.Forms.Button();
            this.buttfind = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uPager1 = new Garbagemanage.UControls.UPager();
            this.dgvEmpList = new System.Windows.Forms.DataGridView();
            this.ColChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSpeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSPeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeIDnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialVillage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkState);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmiaoshu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttRe);
            this.groupBox1.Controls.Add(this.buttok);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.txtEmpName);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtEmpTypled);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmpIDnumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEmpNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblerr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1107, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // chkState
            // 
            this.chkState.AutoSize = true;
            this.chkState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkState.Location = new System.Drawing.Point(605, 121);
            this.chkState.Name = "chkState";
            this.chkState.Size = new System.Drawing.Size(39, 21);
            this.chkState.TabIndex = 7;
            this.chkState.Text = "是";
            this.chkState.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(567, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "在职";
            // 
            // txtmiaoshu
            // 
            this.txtmiaoshu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtmiaoshu.Location = new System.Drawing.Point(123, 105);
            this.txtmiaoshu.Multiline = true;
            this.txtmiaoshu.Name = "txtmiaoshu";
            this.txtmiaoshu.Size = new System.Drawing.Size(432, 54);
            this.txtmiaoshu.TabIndex = 5;
            this.txtmiaoshu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(61, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "人员描述";
            // 
            // buttRe
            // 
            this.buttRe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttRe.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttRe.FlatAppearance.BorderSize = 0;
            this.buttRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttRe.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttRe.ForeColor = System.Drawing.Color.White;
            this.buttRe.Location = new System.Drawing.Point(956, 103);
            this.buttRe.Name = "buttRe";
            this.buttRe.Size = new System.Drawing.Size(62, 27);
            this.buttRe.TabIndex = 3;
            this.buttRe.Text = "重置";
            this.buttRe.UseVisualStyleBackColor = false;
            this.buttRe.Click += new System.EventHandler(this.buttRe_Click);
            // 
            // buttok
            // 
            this.buttok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttok.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttok.FlatAppearance.BorderSize = 0;
            this.buttok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttok.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttok.ForeColor = System.Drawing.Color.White;
            this.buttok.Location = new System.Drawing.Point(956, 47);
            this.buttok.Name = "buttok";
            this.buttok.Size = new System.Drawing.Size(62, 30);
            this.buttok.TabIndex = 3;
            this.buttok.Text = "添加";
            this.buttok.UseVisualStyleBackColor = false;
            this.buttok.Click += new System.EventHandler(this.buttok_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAge.Location = new System.Drawing.Point(605, 66);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(53, 23);
            this.txtAge.TabIndex = 1;
            this.txtAge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSex.Location = new System.Drawing.Point(605, 27);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(53, 23);
            this.txtSex.TabIndex = 1;
            this.txtSex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmpName.Location = new System.Drawing.Point(368, 27);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(187, 23);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtArea.Location = new System.Drawing.Point(735, 24);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(140, 23);
            this.txtArea.TabIndex = 1;
            this.txtArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // txtEmpTypled
            // 
            this.txtEmpTypled.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmpTypled.Location = new System.Drawing.Point(735, 66);
            this.txtEmpTypled.Name = "txtEmpTypled";
            this.txtEmpTypled.Size = new System.Drawing.Size(140, 23);
            this.txtEmpTypled.TabIndex = 1;
            this.txtEmpTypled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(368, 66);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(187, 23);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // txtEmpIDnumber
            // 
            this.txtEmpIDnumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmpIDnumber.Location = new System.Drawing.Point(123, 66);
            this.txtEmpIDnumber.Name = "txtEmpIDnumber";
            this.txtEmpIDnumber.Size = new System.Drawing.Size(140, 23);
            this.txtEmpIDnumber.TabIndex = 1;
            this.txtEmpIDnumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(673, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "负责地区";
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmpNumber.Location = new System.Drawing.Point(123, 24);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(140, 23);
            this.txtEmpNumber.TabIndex = 1;
            this.txtEmpNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(697, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "岗位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(306, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "联系电话";
            // 
            // lblerr
            // 
            this.lblerr.AutoSize = true;
            this.lblerr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblerr.ForeColor = System.Drawing.Color.Red;
            this.lblerr.Location = new System.Drawing.Point(686, 122);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(92, 17);
            this.lblerr.TabIndex = 0;
            this.lblerr.Text = "请设置员工编码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(59, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "身份证号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(567, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "年龄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(330, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(567, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工ID";
            // 
            // buttDel
            // 
            this.buttDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttDel.FlatAppearance.BorderSize = 0;
            this.buttDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttDel.ForeColor = System.Drawing.Color.White;
            this.buttDel.Location = new System.Drawing.Point(926, 193);
            this.buttDel.Name = "buttDel";
            this.buttDel.Size = new System.Drawing.Size(62, 23);
            this.buttDel.TabIndex = 17;
            this.buttDel.Text = "删除";
            this.buttDel.UseVisualStyleBackColor = false;
            this.buttDel.Click += new System.EventHandler(this.buttDel_Click);
            // 
            // chkShowDel
            // 
            this.chkShowDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowDel.AutoSize = true;
            this.chkShowDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkShowDel.Location = new System.Drawing.Point(1050, 195);
            this.chkShowDel.Name = "chkShowDel";
            this.chkShowDel.Size = new System.Drawing.Size(63, 21);
            this.chkShowDel.TabIndex = 16;
            this.chkShowDel.Text = "已删除";
            this.chkShowDel.UseVisualStyleBackColor = true;
            // 
            // buttRemove
            // 
            this.buttRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttRemove.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttRemove.FlatAppearance.BorderSize = 0;
            this.buttRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttRemove.ForeColor = System.Drawing.Color.White;
            this.buttRemove.Location = new System.Drawing.Point(845, 193);
            this.buttRemove.Name = "buttRemove";
            this.buttRemove.Size = new System.Drawing.Size(62, 23);
            this.buttRemove.TabIndex = 18;
            this.buttRemove.Text = "移除";
            this.buttRemove.UseVisualStyleBackColor = false;
            this.buttRemove.Click += new System.EventHandler(this.buttRemove_Click);
            // 
            // buttRecover
            // 
            this.buttRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttRecover.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttRecover.FlatAppearance.BorderSize = 0;
            this.buttRecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttRecover.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttRecover.ForeColor = System.Drawing.Color.White;
            this.buttRecover.Location = new System.Drawing.Point(763, 193);
            this.buttRecover.Name = "buttRecover";
            this.buttRecover.Size = new System.Drawing.Size(62, 23);
            this.buttRecover.TabIndex = 19;
            this.buttRecover.Text = "恢复";
            this.buttRecover.UseVisualStyleBackColor = false;
            this.buttRecover.Click += new System.EventHandler(this.buttRecover_Click);
            // 
            // buttfind
            // 
            this.buttfind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttfind.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttfind.FlatAppearance.BorderSize = 0;
            this.buttfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttfind.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttfind.ForeColor = System.Drawing.Color.White;
            this.buttfind.Location = new System.Drawing.Point(613, 193);
            this.buttfind.Name = "buttfind";
            this.buttfind.Size = new System.Drawing.Size(62, 23);
            this.buttfind.TabIndex = 20;
            this.buttfind.Text = "查询";
            this.buttfind.UseVisualStyleBackColor = false;
            this.buttfind.Click += new System.EventHandler(this.buttfind_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(278, 193);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(288, 23);
            this.textBox6.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(18, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "员工信息列表";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(200, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "查询关键词";
            // 
            // uPager1
            // 
            this.uPager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uPager1.BackColor = System.Drawing.Color.White;
            this.uPager1.CurrentPage = 1;
            this.uPager1.Location = new System.Drawing.Point(12, 526);
            this.uPager1.Name = "uPager1";
            this.uPager1.PageSize = 25;
            this.uPager1.Record = 0;
            this.uPager1.Size = new System.Drawing.Size(1107, 44);
            this.uPager1.StartIndex = 1;
            this.uPager1.TabIndex = 22;
            // 
            // dgvEmpList
            // 
            this.dgvEmpList.AllowUserToAddRows = false;
            this.dgvEmpList.AllowUserToDeleteRows = false;
            this.dgvEmpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpList.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpList.ColumnHeadersHeight = 35;
            this.dgvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChk,
            this.colSpeNo,
            this.colSPeName,
            this.colSex,
            this.colAge,
            this.colSpeIDnumber,
            this.colphone,
            this.colSpecialVillage,
            this.colSpeAddress,
            this.colEdit,
            this.colDel,
            this.colRecover,
            this.colRemove});
            this.dgvEmpList.EnableHeadersVisualStyles = false;
            this.dgvEmpList.GridColor = System.Drawing.Color.LightGray;
            this.dgvEmpList.Location = new System.Drawing.Point(12, 220);
            this.dgvEmpList.MultiSelect = false;
            this.dgvEmpList.Name = "dgvEmpList";
            this.dgvEmpList.RowHeadersWidth = 30;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvEmpList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpList.RowTemplate.Height = 23;
            this.dgvEmpList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpList.Size = new System.Drawing.Size(1107, 306);
            this.dgvEmpList.TabIndex = 21;
            this.dgvEmpList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpList_CellContentClick_1);
            // 
            // ColChk
            // 
            this.ColChk.FillWeight = 70F;
            this.ColChk.HeaderText = "选择";
            this.ColChk.Name = "ColChk";
            // 
            // colSpeNo
            // 
            this.colSpeNo.DataPropertyName = "SpeNo";
            this.colSpeNo.HeaderText = "员工ID";
            this.colSpeNo.Name = "colSpeNo";
            this.colSpeNo.ReadOnly = true;
            // 
            // colSPeName
            // 
            this.colSPeName.DataPropertyName = "SpeName";
            this.colSPeName.FillWeight = 80F;
            this.colSPeName.HeaderText = "姓名";
            this.colSPeName.Name = "colSPeName";
            this.colSPeName.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.FillWeight = 80F;
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.FillWeight = 80F;
            this.colAge.HeaderText = "年龄";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            // 
            // colSpeIDnumber
            // 
            this.colSpeIDnumber.DataPropertyName = "SpeIDnumber";
            this.colSpeIDnumber.FillWeight = 150F;
            this.colSpeIDnumber.HeaderText = "身份证号";
            this.colSpeIDnumber.Name = "colSpeIDnumber";
            this.colSpeIDnumber.ReadOnly = true;
            // 
            // colphone
            // 
            this.colphone.DataPropertyName = "Phone";
            this.colphone.FillWeight = 150F;
            this.colphone.HeaderText = "联系电话";
            this.colphone.Name = "colphone";
            this.colphone.ReadOnly = true;
            // 
            // colSpecialVillage
            // 
            this.colSpecialVillage.DataPropertyName = "SpeVillage";
            this.colSpecialVillage.FillWeight = 150F;
            this.colSpecialVillage.HeaderText = "负责地区";
            this.colSpecialVillage.Name = "colSpecialVillage";
            // 
            // colSpeAddress
            // 
            this.colSpeAddress.DataPropertyName = "SpeAddress";
            this.colSpeAddress.FillWeight = 180F;
            this.colSpeAddress.HeaderText = "岗位";
            this.colSpeAddress.Name = "colSpeAddress";
            // 
            // colEdit
            // 
            this.colEdit.FillWeight = 50F;
            this.colEdit.HeaderText = "修改";
            this.colEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEdit.Text = "修改";
            this.colEdit.TrackVisitedState = false;
            this.colEdit.UseColumnTextForLinkValue = true;
            // 
            // colDel
            // 
            this.colDel.FillWeight = 50F;
            this.colDel.HeaderText = "删除";
            this.colDel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colDel.Name = "colDel";
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDel.Text = "删除";
            this.colDel.TrackVisitedState = false;
            this.colDel.UseColumnTextForLinkValue = true;
            // 
            // colRecover
            // 
            this.colRecover.FillWeight = 50F;
            this.colRecover.HeaderText = "恢复";
            this.colRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRecover.Name = "colRecover";
            this.colRecover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRecover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRecover.Text = "恢复";
            this.colRecover.TrackVisitedState = false;
            this.colRecover.UseColumnTextForLinkValue = true;
            // 
            // colRemove
            // 
            this.colRemove.FillWeight = 50F;
            this.colRemove.HeaderText = "移除";
            this.colRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colRemove.Name = "colRemove";
            this.colRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRemove.Text = "移除";
            this.colRemove.TrackVisitedState = false;
            this.colRemove.UseColumnTextForLinkValue = true;
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 581);
            this.Controls.Add(this.uPager1);
            this.Controls.Add(this.dgvEmpList);
            this.Controls.Add(this.buttDel);
            this.Controls.Add(this.chkShowDel);
            this.Controls.Add(this.buttRemove);
            this.Controls.Add(this.buttRecover);
            this.Controls.Add(this.buttfind);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmployeeList";
            this.Text = "FrmEmployeeList";
            this.Load += new System.EventHandler(this.FrmEmployeeList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmiaoshu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttRe;
        private System.Windows.Forms.Button buttok;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtEmpTypled;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmpIDnumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblerr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttDel;
        private System.Windows.Forms.CheckBox chkShowDel;
        private System.Windows.Forms.Button buttRemove;
        private System.Windows.Forms.Button buttRecover;
        private System.Windows.Forms.Button buttfind;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private UControls.UPager uPager1;
        private System.Windows.Forms.DataGridView dgvEmpList;
        private System.Windows.Forms.CheckBox chkState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSPeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeIDnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialVillage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpeAddress;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
        private System.Windows.Forms.DataGridViewLinkColumn colRecover;
        private System.Windows.Forms.DataGridViewLinkColumn colRemove;
    }
}