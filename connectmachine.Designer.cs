using System;

namespace WindowsFormsAppforFanuc
{
    partial class connectmachine
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btconn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cancelbut = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.spindlespeed = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cuttingspeed = new System.Windows.Forms.TextBox();
            this.cnctype1 = new System.Windows.Forms.TextBox();
            this.cncspec = new System.Windows.Forms.TextBox();
            this.cncworktype = new System.Windows.Forms.TextBox();
            this.maxaxis = new System.Windows.Forms.TextBox();
            this.feedrate = new System.Windows.Forms.TextBox();
            this.mcnstatus = new System.Windows.Forms.TextBox();
            this.subprogno = new System.Windows.Forms.TextBox();
            this.mainprogno = new System.Windows.Forms.TextBox();
            this.counttotal = new System.Windows.Forms.TextBox();
            this.countpertime = new System.Windows.Forms.TextBox();
            this.worktimetotal = new System.Windows.Forms.TextBox();
            this.ontimetotal = new System.Windows.Forms.TextBox();
            this.ypos = new System.Windows.Forms.TextBox();
            this.xpos = new System.Windows.Forms.TextBox();
            this.yposact = new System.Windows.Forms.TextBox();
            this.cuttingtime = new System.Windows.Forms.TextBox();
            this.xposact = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.txtalarmmsg = new System.Windows.Forms.TextBox();
            this.showtime = new System.Windows.Forms.TextBox();
            this.refreshdata = new System.Windows.Forms.Timer(this.components);
            this.progname = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.datetimeupdate = new System.Windows.Forms.Timer(this.components);
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.txtmaxgrp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "机床IP:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "192.168.56.200";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "连接端口:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(41, 21);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "8193";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btconn
            // 
            this.btconn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btconn.Location = new System.Drawing.Point(528, 10);
            this.btconn.Name = "btconn";
            this.btconn.Size = new System.Drawing.Size(75, 23);
            this.btconn.TabIndex = 5;
            this.btconn.Text = "连接机床";
            this.btconn.UseVisualStyleBackColor = false;
            this.btconn.Click += new System.EventHandler(this.btconn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(858, 562);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 21);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(810, 562);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(42, 21);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "句柄：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(364, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(68, 21);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "超时时间:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(449, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(27, 21);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "10";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancelbut
            // 
            this.cancelbut.Location = new System.Drawing.Point(618, 10);
            this.cancelbut.Name = "cancelbut";
            this.cancelbut.Size = new System.Drawing.Size(75, 23);
            this.cancelbut.TabIndex = 12;
            this.cancelbut.Text = "断开";
            this.cancelbut.UseVisualStyleBackColor = true;
            this.cancelbut.Click += new System.EventHandler(this.cancelbut_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 291);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "X轴绝对坐标";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "写入数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(-1, 450);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 124);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 65);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 21);
            this.textBox11.TabIndex = 17;
            this.textBox11.Text = "主轴实际转速";
            // 
            // spindlespeed
            // 
            this.spindlespeed.Location = new System.Drawing.Point(120, 65);
            this.spindlespeed.Name = "spindlespeed";
            this.spindlespeed.Size = new System.Drawing.Size(98, 21);
            this.spindlespeed.TabIndex = 18;
            this.spindlespeed.TextChanged += new System.EventHandler(this.spindlespeed_TextChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 92);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 21);
            this.textBox12.TabIndex = 17;
            this.textBox12.Text = "CNC型号";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(270, 92);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 21);
            this.textBox13.TabIndex = 17;
            this.textBox13.Text = "CNC类型";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(270, 65);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 21);
            this.textBox14.TabIndex = 19;
            this.textBox14.Text = "切削实际速度";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(12, 119);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 21);
            this.textBox15.TabIndex = 17;
            this.textBox15.Text = "最大轴数";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(270, 119);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 21);
            this.textBox16.TabIndex = 17;
            this.textBox16.Text = "CNC工作模式";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(12, 146);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 21);
            this.textBox17.TabIndex = 17;
            this.textBox17.Text = "设备状态";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(270, 146);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 21);
            this.textBox18.TabIndex = 17;
            this.textBox18.Text = "进给倍率";
            this.textBox18.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(12, 178);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 21);
            this.textBox19.TabIndex = 17;
            this.textBox19.Text = "主程序号";
            this.textBox19.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(270, 178);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 21);
            this.textBox20.TabIndex = 17;
            this.textBox20.Text = "当前程序号";
            this.textBox20.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(13, 214);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 21);
            this.textBox21.TabIndex = 17;
            this.textBox21.Text = "单次加工数";
            this.textBox21.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(271, 214);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 21);
            this.textBox22.TabIndex = 17;
            this.textBox22.Text = "工件总数";
            this.textBox22.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(270, 291);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 21);
            this.textBox23.TabIndex = 13;
            this.textBox23.Text = "Y轴绝对坐标";
            this.textBox23.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(12, 328);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 21);
            this.textBox24.TabIndex = 13;
            this.textBox24.Text = "X轴相对坐标";
            this.textBox24.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(270, 328);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 21);
            this.textBox25.TabIndex = 13;
            this.textBox25.Text = "Y轴相对坐标";
            this.textBox25.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(12, 254);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 21);
            this.textBox27.TabIndex = 17;
            this.textBox27.Text = "开机时间";
            this.textBox27.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(270, 254);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 21);
            this.textBox28.TabIndex = 17;
            this.textBox28.Text = "运行时间";
            this.textBox28.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(534, 254);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(100, 21);
            this.textBox29.TabIndex = 17;
            this.textBox29.Text = "切削时间";
            this.textBox29.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "获取数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cuttingspeed
            // 
            this.cuttingspeed.Location = new System.Drawing.Point(392, 64);
            this.cuttingspeed.Name = "cuttingspeed";
            this.cuttingspeed.Size = new System.Drawing.Size(100, 21);
            this.cuttingspeed.TabIndex = 21;
            // 
            // cnctype1
            // 
            this.cnctype1.Location = new System.Drawing.Point(392, 92);
            this.cnctype1.Name = "cnctype1";
            this.cnctype1.Size = new System.Drawing.Size(100, 21);
            this.cnctype1.TabIndex = 21;
            // 
            // cncspec
            // 
            this.cncspec.Location = new System.Drawing.Point(118, 92);
            this.cncspec.Name = "cncspec";
            this.cncspec.Size = new System.Drawing.Size(100, 21);
            this.cncspec.TabIndex = 21;
            // 
            // cncworktype
            // 
            this.cncworktype.Location = new System.Drawing.Point(392, 119);
            this.cncworktype.Name = "cncworktype";
            this.cncworktype.Size = new System.Drawing.Size(100, 21);
            this.cncworktype.TabIndex = 21;
            // 
            // maxaxis
            // 
            this.maxaxis.Location = new System.Drawing.Point(118, 119);
            this.maxaxis.Name = "maxaxis";
            this.maxaxis.Size = new System.Drawing.Size(100, 21);
            this.maxaxis.TabIndex = 21;
            // 
            // feedrate
            // 
            this.feedrate.Location = new System.Drawing.Point(392, 146);
            this.feedrate.Name = "feedrate";
            this.feedrate.Size = new System.Drawing.Size(100, 21);
            this.feedrate.TabIndex = 21;
            // 
            // mcnstatus
            // 
            this.mcnstatus.Location = new System.Drawing.Point(118, 146);
            this.mcnstatus.Name = "mcnstatus";
            this.mcnstatus.Size = new System.Drawing.Size(100, 21);
            this.mcnstatus.TabIndex = 21;
            // 
            // subprogno
            // 
            this.subprogno.Location = new System.Drawing.Point(392, 178);
            this.subprogno.Name = "subprogno";
            this.subprogno.Size = new System.Drawing.Size(100, 21);
            this.subprogno.TabIndex = 21;
            // 
            // mainprogno
            // 
            this.mainprogno.Location = new System.Drawing.Point(118, 178);
            this.mainprogno.Name = "mainprogno";
            this.mainprogno.Size = new System.Drawing.Size(100, 21);
            this.mainprogno.TabIndex = 21;
            // 
            // counttotal
            // 
            this.counttotal.Location = new System.Drawing.Point(392, 214);
            this.counttotal.Name = "counttotal";
            this.counttotal.Size = new System.Drawing.Size(100, 21);
            this.counttotal.TabIndex = 21;
            // 
            // countpertime
            // 
            this.countpertime.Location = new System.Drawing.Point(118, 214);
            this.countpertime.Name = "countpertime";
            this.countpertime.Size = new System.Drawing.Size(100, 21);
            this.countpertime.TabIndex = 21;
            // 
            // worktimetotal
            // 
            this.worktimetotal.Location = new System.Drawing.Point(392, 254);
            this.worktimetotal.Name = "worktimetotal";
            this.worktimetotal.Size = new System.Drawing.Size(100, 21);
            this.worktimetotal.TabIndex = 21;
            // 
            // ontimetotal
            // 
            this.ontimetotal.Location = new System.Drawing.Point(118, 254);
            this.ontimetotal.Name = "ontimetotal";
            this.ontimetotal.Size = new System.Drawing.Size(100, 21);
            this.ontimetotal.TabIndex = 21;
            // 
            // ypos
            // 
            this.ypos.Location = new System.Drawing.Point(392, 328);
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(100, 21);
            this.ypos.TabIndex = 21;
            // 
            // xpos
            // 
            this.xpos.Location = new System.Drawing.Point(118, 328);
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(100, 21);
            this.xpos.TabIndex = 21;
            // 
            // yposact
            // 
            this.yposact.Location = new System.Drawing.Point(392, 291);
            this.yposact.Name = "yposact";
            this.yposact.Size = new System.Drawing.Size(100, 21);
            this.yposact.TabIndex = 21;
            // 
            // cuttingtime
            // 
            this.cuttingtime.Location = new System.Drawing.Point(649, 254);
            this.cuttingtime.Name = "cuttingtime";
            this.cuttingtime.Size = new System.Drawing.Size(100, 21);
            this.cuttingtime.TabIndex = 21;
            // 
            // xposact
            // 
            this.xposact.Location = new System.Drawing.Point(118, 291);
            this.xposact.Name = "xposact";
            this.xposact.Size = new System.Drawing.Size(100, 21);
            this.xposact.TabIndex = 21;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(12, 391);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 21);
            this.textBox26.TabIndex = 13;
            this.textBox26.Text = "报警信息";
            this.textBox26.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtalarmmsg
            // 
            this.txtalarmmsg.Location = new System.Drawing.Point(118, 390);
            this.txtalarmmsg.Name = "txtalarmmsg";
            this.txtalarmmsg.Size = new System.Drawing.Size(100, 21);
            this.txtalarmmsg.TabIndex = 22;
            // 
            // showtime
            // 
            this.showtime.Font = new System.Drawing.Font("宋体", 10F);
            this.showtime.Location = new System.Drawing.Point(665, 559);
            this.showtime.Name = "showtime";
            this.showtime.Size = new System.Drawing.Size(139, 23);
            this.showtime.TabIndex = 23;
            this.showtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refreshdata
            // 
            this.refreshdata.Tick += new System.EventHandler(this.refreshtime_Tick);
            // 
            // progname
            // 
            this.progname.Location = new System.Drawing.Point(618, 178);
            this.progname.Name = "progname";
            this.progname.Size = new System.Drawing.Size(100, 21);
            this.progname.TabIndex = 24;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(512, 178);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 25;
            this.textBox10.Text = "当前程序名";
            // 
            // datetimeupdate
            // 
            this.datetimeupdate.Tick += new System.EventHandler(this.datetimeupdate_Tick);
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(270, 390);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(100, 21);
            this.textBox30.TabIndex = 26;
            this.textBox30.Text = "最大刀具组号";
            // 
            // txtmaxgrp
            // 
            this.txtmaxgrp.Location = new System.Drawing.Point(392, 390);
            this.txtmaxgrp.Name = "txtmaxgrp";
            this.txtmaxgrp.Size = new System.Drawing.Size(100, 21);
            this.txtmaxgrp.TabIndex = 27;
            // 
            // connectmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 583);
            this.Controls.Add(this.txtmaxgrp);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.progname);
            this.Controls.Add(this.showtime);
            this.Controls.Add(this.txtalarmmsg);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.ontimetotal);
            this.Controls.Add(this.countpertime);
            this.Controls.Add(this.mainprogno);
            this.Controls.Add(this.mcnstatus);
            this.Controls.Add(this.maxaxis);
            this.Controls.Add(this.cncspec);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.cuttingtime);
            this.Controls.Add(this.xposact);
            this.Controls.Add(this.yposact);
            this.Controls.Add(this.worktimetotal);
            this.Controls.Add(this.counttotal);
            this.Controls.Add(this.subprogno);
            this.Controls.Add(this.feedrate);
            this.Controls.Add(this.cncworktype);
            this.Controls.Add(this.cnctype1);
            this.Controls.Add(this.cuttingspeed);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.spindlespeed);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.cancelbut);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btconn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "connectmachine";
            this.Text = "FANUC FOCAS";
            this.Load += new System.EventHandler(this.connectmachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox10_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btconn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button cancelbut;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox spindlespeed;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cuttingspeed;
        private System.Windows.Forms.TextBox cnctype1;
        private System.Windows.Forms.TextBox cncspec;
        private System.Windows.Forms.TextBox cncworktype;
        private System.Windows.Forms.TextBox maxaxis;
        private System.Windows.Forms.TextBox feedrate;
        private System.Windows.Forms.TextBox mcnstatus;
        private System.Windows.Forms.TextBox subprogno;
        private System.Windows.Forms.TextBox mainprogno;
        private System.Windows.Forms.TextBox counttotal;
        private System.Windows.Forms.TextBox countpertime;
        private System.Windows.Forms.TextBox worktimetotal;
        private System.Windows.Forms.TextBox ontimetotal;
        private System.Windows.Forms.TextBox ypos;
        private System.Windows.Forms.TextBox xpos;
        private System.Windows.Forms.TextBox yposact;
        private System.Windows.Forms.TextBox cuttingtime;
        private System.Windows.Forms.TextBox xposact;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox txtalarmmsg;
        private System.Windows.Forms.TextBox showtime;
        private System.Windows.Forms.Timer refreshdata;
        private System.Windows.Forms.TextBox progname;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Timer datetimeupdate;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox txtmaxgrp;
    }
}