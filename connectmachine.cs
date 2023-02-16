using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using IoTClient;
using HslCommunication.Profinet.OpenProtocol;


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
                MessageBox.Show("设备连接成功！","连接提示");
                textBox5.Text = FanucOpe.Handle.ToString();
            }
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            short ret = FanucOpe.cnc_freelibhndl(FanucOpe.Handle);
            MessageBox.Show("设备断开成功","断开提示");
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
                //MessageBox.Show(x.ToString());
                //绝对
                //textBox10.Text = x.ToString(); //x绝对坐标值
                string namex = textBox7.Text; //x绝对坐标名
                string recordtime = DateTime.Now.ToString(); //数据的记录时间
                if (FanucOpe.Handle != 0)
                {
                    listBox1.Items.Add(x.ToString());
                    //string value1 = textBox10.Text;

                    string insertCommand = "insert into dbo.focas(type, value, time) values('" + namex + "','" + x + "','" + recordtime + "')"; //插入数据库
                    sqlcon.Open();
                    Console.WriteLine("open database successfully!!!");
                    SqlCommand command = new SqlCommand(insertCommand, sqlcon);
                    command.ExecuteNonQuery();
                    sqlcon.Close();
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
            Focas1.ODBACT data = new Focas1.ODBACT();
            short ret = Focas1.cnc_acts(FanucOpe.Handle, data);
            if (ret == Focas1.EW_OK)
            {
               string Speed = data.data.ToString();
                this.spindlespeed.Text = Speed.ToString();//单位r/min
            }

            //
        }
    }
}