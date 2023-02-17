using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using IoTClient;
using System.Security.Claims;


namespace WindowsFormsAppforFanuc
{
    public partial class connectmachine : Form
    {
        public connectmachine()
        {
            InitializeComponent();
        }

        // SQL Server 连接
        private SqlConnection sqlcon = new SqlConnection("Server = DESKTOP-0UTSD34\\SQLEXPRESS; User Id = xiehui; Pwd=xiehui;DataBase=test");

        private void btconn_Click(object sender, EventArgs e)
        {
            string ip = textBox2.Text;
            string port = textBox4.Text;
            string timeout = textBox9.Text;
            short ret = FanucOpe.cnc_allclibhndl3(ip, Convert.ToUInt16(port), Convert.ToInt32(timeout), out FanucOpe.Handle); //连接设备

            //sqlcon.Open(); //打开SQL server数据库

            if (ret != FanucOpe.EW_OK)
            {
                //设备连接失败，返回ret错误代码
                MessageBox.Show("设备连接失败" + "错误代码：" + ret);
            }
            else if (ret == FanucOpe.EW_OK)
            {
                MessageBox.Show("设备连接成功！", "连接提示");
                textBox5.Text = FanucOpe.Handle.ToString();
            }
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            short ret = FanucOpe.cnc_freelibhndl(FanucOpe.Handle);
            MessageBox.Show("设备断开成功", "断开提示");
            textBox5.Text = "0";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FanucOpe.ODBPOS fos = new FanucOpe.ODBPOS();
            short num = FanucOpe.MAX_AXIS;
            short type = -1;
            short ret = FanucOpe.cnc_rdposition(FanucOpe.Handle, type, ref num, fos);
            if (ret == 0)
            {
                double x = fos.p1.abs.data * Math.Pow(10, -fos.p1.abs.dec);
                string namex = textBox7.Text; //x绝对坐标名
                string recordtime = DateTime.Now.ToString(); //数据的记录时间
                this.showtime.Text = DateTime.Now.ToString();
                if (FanucOpe.Handle != 0)
                {
                    listBox1.Items.Add(x.ToString());
                    //string value1 = textBox10.Text;

                    //string insertCommand = "insert into dbo.focas(type, value, time) values('" + namex + "','" + x + "','" + recordtime + "')"; //插入数据库
                    //sqlcon.Open();
                    //Console.WriteLine("open database successfully!!!");
                    //SqlCommand command = new SqlCommand(insertCommand, sqlcon);
                    //command.ExecuteNonQuery();
                    //sqlcon.Close();
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //插入数据到数据库
        }

        private void testDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void spindlespeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //主轴实际转速：
            FanucOpe.ODBACT data = new FanucOpe.ODBACT();
            short ret = FanucOpe.cnc_acts(FanucOpe.Handle, data);
            if (ret == FanucOpe.EW_OK)
            {
                string Speed = data.data.ToString();
                this.spindlespeed.Text = Speed.ToString();//单位r/min
            }

            //切削实际速度 F
            FanucOpe.ODBACT data1 = new FanucOpe.ODBACT();
            ret = FanucOpe.cnc_actf(FanucOpe.Handle, data);
            if (ret == FanucOpe.EW_OK)
            {
                string OverRide = data1.data.ToString();
                this.cuttingspeed.Text = OverRide.ToString();//单位m m/min
            }

            // CNC类型
            FanucOpe.ODBSYS k1 = new FanucOpe.ODBSYS();
            ret = FanucOpe.cnc_sysinfo(FanucOpe.Handle, k1);
            if (ret == FanucOpe.EW_OK)
            {
                string MaxAxis = k1.max_axis.ToString();//最大轴数 
                this.maxaxis.Text = MaxAxis;
                string type1 = k1.cnc_type[0].ToString() + k1.cnc_type[1].ToString();//CNC类型
                //机床系统类型判断
                string CNCType;
                switch (type1)
                {
                    case "15":
                        CNCType = "Series 15/15i";
                        break;
                    case "16":
                        CNCType = "Series 16/16i";
                        break;
                    case "18":
                        CNCType = "Series 18/18i";
                        break;
                    case "21":
                        CNCType = "Series 21/21i";
                        break;
                    case "30":
                        CNCType = "Series 30i";
                        break;
                    case "31":
                        CNCType = "Series 31i";
                        break;
                    case "32":
                        CNCType = "Series 32i";
                        break;
                    case "35":
                        CNCType = "Series 35i";
                        break;
                    case " 0":
                        CNCType = "Series 0i";
                        break;
                    case "PD":
                        CNCType = "Power Mate i-D";
                        break;
                    case "PH":
                        CNCType = "Power Mate i-H";
                        break;
                    case "PM":
                        CNCType = "Power Motion i";
                        break;
                    default:
                        CNCType = "其它类型";
                        break;
                }
                this.cnctype1.Text = CNCType;
                string MTType = k1.mt_type[0].ToString() + k1.mt_type[1].ToString();
                //CNC型号
                string SerialNumber = k1.series[0].ToString() + k1.series[1].ToString() + k1.series[2].ToString() + k1.series[3].ToString();
                this.cncspec.Text = SerialNumber;
                string Version = k1.version[0].ToString() + k1.version[1].ToString() + k1.version[2].ToString() + k1.version[3].ToString();
                string Axis = k1.axes[0].ToString() + k1.axes[1].ToString();
            }


            //CNC工作模式
            FanucOpe.ODBST statinfo = new FanucOpe.ODBST();
            ret = FanucOpe.cnc_statinfo(FanucOpe.Handle, statinfo);
            if (ret == FanucOpe.EW_OK)
            {
                //设备状态的判定方法：如果Alarm不为0则有报警。当没有报警时，如果run=3认为是在运行，其他都为待机
                short run = statinfo.run;
                short Alarm = statinfo.alarm;
                //MTMode = statinfo.tmmode;
                if (Alarm != 0)
                    run = 5;//5为设备报警状态
                this.mcnstatus.Text = run.ToString();
                //工作模式判断
                string CNCModel = "";
                switch (statinfo.aut)
                {
                    case 0:
                        CNCModel = "MDI";
                        break;
                    case 1:
                        CNCModel = "MEMory";
                        break;
                    case 2:
                        CNCModel = "Not Defined";
                        break;
                    case 3:
                        CNCModel = "EDIT";
                        break;
                    case 4:
                        CNCModel = "HaNDle";
                        break;
                    case 5:
                        CNCModel = "JOG";
                        break;
                    case 6:
                        CNCModel = "Teach in JOG";
                        break;
                    case 7:
                        CNCModel = "Teach in HaNDle";
                        break;
                    case 8:
                        CNCModel = "INC·feed";
                        break;
                    case 9:
                        CNCModel = "REFerence";
                        break;
                    case 10:
                        CNCModel = "ReMoTe";
                        break;
                    default:
                        CNCModel = "others mode";
                        break;
                }
                this.cncworktype.Text = CNCModel.ToString();
            }
            //设备状态

            //进给倍率
            FanucOpe.IODBPMC0 ig = new FanucOpe.IODBPMC0();
            ret = FanucOpe.pmc_rdpmcrng(FanucOpe.Handle, 0, 1, 12, 13, 8 + 1 * 2, ig);
            if (ret == FanucOpe.EW_OK)
            {
                string FeedOverRide = (100 - (ig.cdata[0] - 155)).ToString();//进给倍率,转换成百分比为什么是155没搞懂，设备不同也可能不是155
                this.feedrate.Text = FeedOverRide.ToString();
            }

            //程序相关
            FanucOpe.ODBPRO dbpro = new FanucOpe.ODBPRO();
            if (FanucOpe.EW_OK == FanucOpe.cnc_rdprgnum(FanucOpe.Handle, dbpro))
            {
                short Mainpg = dbpro.mdata;//主程序号
                this.mainprogno.Text = Mainpg.ToString();
                short Currentpg = dbpro.data;//当前运行程序号（子程序号）
                this.subprogno.Text = Currentpg.ToString();

            }

            //加工计数
            FanucOpe.ODBM bb = new FanucOpe.ODBM();
            ret = FanucOpe.cnc_rdmacro(FanucOpe.Handle, 0xf3d, 0x0a, bb);
            if (ret == FanucOpe.EW_OK)
            {
                string PartCnt = (bb.mcr_val / 100000).ToString();
                this.countpertime.Text = PartCnt.ToString();
            }

            FanucOpe.IODBPSD_1 param6712 = new FanucOpe.IODBPSD_1();
            ret = FanucOpe.cnc_rdparam(FanucOpe.Handle, 6712, 0, 8, param6712);
            if (ret == FanucOpe.EW_OK)
            {
                int totalparts = param6712.ldata;
                this.counttotal.Text = totalparts.ToString();
            }

            //时间

            //获取切削时间
            FanucOpe.IODBPSD_1 param6753 = new FanucOpe.IODBPSD_1();
            FanucOpe.IODBPSD_1 param6754 = new FanucOpe.IODBPSD_1();
            ret = FanucOpe.cnc_rdparam(FanucOpe.Handle, 6753, 0, 8 + 32, param6753);
            if (ret == FanucOpe.EW_OK)
            {
                int cuttingTimeSec = param6753.ldata / 1000;
                ret = FanucOpe.cnc_rdparam(FanucOpe.Handle, 6754, 0, 8 + 32, param6754);
                if (ret == FanucOpe.EW_OK)
                {
                    int cuttingTimeMin = param6754.ldata;
                    int CutTime = cuttingTimeMin * 60 + cuttingTimeSec;
                    this.cuttingtime.Text = CutTime.ToString();
                }
            }
            //获取运行时间
            FanucOpe.IODBPSD_1 param6751 = new FanucOpe.IODBPSD_1();
            FanucOpe.IODBPSD_1 param6752 = new FanucOpe.IODBPSD_1();
            ret = FanucOpe.cnc_rdparam(FanucOpe.Handle, 6751, 0, 8, param6751);
            if (ret == FanucOpe.EW_OK)
            {
                int workingTimeSec = param6751.ldata / 1000;
                ret = FanucOpe.cnc_rdparam(FanucOpe.Handle, 6752, 0, 8, param6752);
                if (ret == FanucOpe.EW_OK)
                {
                    int workingTimeMin = param6752.ldata;
                    int CycSec = workingTimeMin * 60 + workingTimeSec;
                    this.worktimetotal.Text = CycSec.ToString();
                }
            }
            //获取开机时间
            FanucOpe.IODBPSD_1 param6750 = new FanucOpe.IODBPSD_1();
            ret = FanucOpe.cnc_rdparam(FanucOpe.Handle, 6750, 0, 8 + 32, param6750);
            if (ret == FanucOpe.EW_OK)
            {
                int PoweOnTime = param6750.ldata * 60;
                this.ontimetotal.Text = PoweOnTime.ToString();
            }

            //坐标
            FanucOpe.ODBPOS fos = new FanucOpe.ODBPOS();
            short num = FanucOpe.MAX_AXIS;
            short type = -1;
            ret = FanucOpe.cnc_rdposition(FanucOpe.Handle, type, ref num, fos);
            if (ret == 0)
            {
                //绝对
                this.xposact.Text = (fos.p1.abs.data * Math.Pow(10, -fos.p1.abs.dec)).ToString();
                this.yposact.Text = (fos.p2.abs.data * Math.Pow(10, -fos.p2.abs.dec)).ToString();
                //相对
                this.xpos.Text = (fos.p1.rel.data * Math.Pow(10, -fos.p1.rel.dec)).ToString();
                this.ypos.Text = (fos.p2.rel.data * Math.Pow(10, -fos.p2.rel.dec)).ToString();
            }

            //报警信息

            //报警数据
            ret = FanucOpe.cnc_alarm2(FanucOpe.Handle, out int almdsta);//FanucOpe.cnc_alarm2(FanucOpe.Handle out almdsta);
            if (ret == FanucOpe.EW_OK)
            {
                //报警判断
                string AlarmMessage = "";
                switch (almdsta)
                {
                    case 0:
                        AlarmMessage = "参数开启（SW）";
                        break;
                    case 1:
                        AlarmMessage = "关机参数设置（PW）";
                        break;
                    case 2:
                        AlarmMessage = "I / O错误（IO）";
                        break;
                    case 3:
                        AlarmMessage = "前景P / S（PS";
                        break;
                    case 4:
                        AlarmMessage = "超程，外部数据（OT";
                        break;
                    case 5:
                        AlarmMessage = "过热报警（OH）";
                        break;
                    case 6:
                        AlarmMessage = "伺服报警（SV";
                        break;
                    case 7:
                        AlarmMessage = "数据I / O错误（SR）";
                        break;
                    case 8:
                        AlarmMessage = "宏指令报警（MC";
                        break;
                    case 9:
                        AlarmMessage = "主轴报警（SP）";
                        break;
                    case 10:
                        AlarmMessage = "其他警报（DS）";
                        break;
                    case 11:
                        AlarmMessage = "有关故障防止功能（IE）的警报";
                        break;
                    case 12:
                        AlarmMessage = "背景P / S（BG）";
                        break;
                    case 13:
                        AlarmMessage = "同步错误（SN）";
                        break;
                    case 14:
                        AlarmMessage = "保留";
                        break;
                    case 15:
                        AlarmMessage = "外部报警信息（EX）";
                        break;
                    case 16:
                        AlarmMessage = "正向超程（软限位1）";
                        break;
                    default:
                        AlarmMessage = "未知错误";
                        break;
                }
                this.txtalarmmsg.Text = AlarmMessage;
            }



        }

        private void connectmachine_Load(object sender, EventArgs e)
        {
            this.showtime.Text = DateTime.Now.ToString();
        }

        private void refreshtime_Tick(object sender, EventArgs e)
        {
            this.showtime.Text = DateTime.Now.ToString();
        }
    }    
}