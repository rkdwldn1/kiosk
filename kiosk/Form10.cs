using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        int count = 0;

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //콤보박스 (목적지 설정)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //콤보박스 (출발지 설정)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text==""||comboBox2.Text=="")
            {
                MessageBox.Show("출발지와 목적지를 선택해주세요.");

            }
            else if (comboBox1.Text==comboBox2.Text)
            {
                MessageBox.Show("출발지와 목적지를 다시 확인해주세요.");
                comboBox1.Text = "";
                comboBox2.Text ="";
            }

            else if (comboBox5.Text=="")
            {
                MessageBox.Show("날짜와 시간을 선택해주세요");
            }
            else if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0 && numericUpDown3.Value == 0 && numericUpDown4.Value == 0 &&numericUpDown5.Value ==0)
            {
                MessageBox.Show("좌석 수를 확인해주세요.");
            }
            else if (comboBox1.Text==""||comboBox2.Text==""||numericUpDown1.Value == 0 && numericUpDown2.Value == 0 && numericUpDown3.Value == 0 && numericUpDown4.Value == 0 &&numericUpDown5.Value ==0)
            {
                tabControl1.SelectedIndex = 0;
            }



            else
            {
                string a = "출발지는 " +comboBox1.Text + " 목적지는 " +comboBox2.Text + " 출발시간은 " + comboBox5.Text + "입니다";
                MessageBox.Show(a);

                tabControl1.SelectedIndex =1;
                string strr = "선택한 인원은 총 "+lbsum.Text+"명 입니다.";
                MessageBox.Show(strr);
            }

            if (numericUpDown1.Value>0)
            {
                lbpp.Text =  "어른";
            }
            else if (numericUpDown2.Value>0)
            {
                lbpp.Text ="어린이";
            }
            else if (numericUpDown3.Value>0)
            {
                lbpp.Text ="유아";

            }
            else if (numericUpDown4.Value>0)
            {
                lbpp.Text ="경로";
            }
            else if (numericUpDown5.Value>0)
            {
                lbpp.Text="장애인";
            }



            lbTime.Text =dateTimePicker1.Text;
            lbSStart.Text = comboBox1.Text;
            lbEEnd.Text = comboBox2.Text;

            lbsum.Text=(numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown4.Value+numericUpDown5.Value).ToString();

            int price = 4500*(int)numericUpDown1.Value+3200*(int)numericUpDown2.Value+2200*(int)numericUpDown3.Value+3000*(int)numericUpDown4.Value+3000*(int)numericUpDown5.Value;
            lbPrice.Text=price.ToString()+"원";

            lbNosale.Text=price.ToString()+"원";

            lbSt.Text=comboBox5.Text;

            lbDay.Text=dateTimePicker1.Text;

            ladate.Text=DateTime.Now.ToLongDateString();

            timer1.Start();
            timer1.Interval = 1000;

            lbstart1.Text = comboBox1.Text;
            lbend1.Text = comboBox2.Text;

            lbttime.Text=comboBox5.Text;


        }


        private void btn_no_Click(object sender, EventArgs e)
        {

            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text="";
            numericUpDown1.Value =0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            comboBox5.Text = "";
            lbsum.Text = "";

        }

        /*
        private void btn1_Click(object sender, EventArgs e) //첫번째 좌석
        {
           

        }
        */



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbtxt5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSok_Click(object sender, EventArgs e) // 좌석 선택완료 버튼            
        {


            if (int.Parse(lbsum.Text) > 0)
            {


                if (ch1.Checked==true)
                {
                    //MessageBox.Show("1번 좌석을 선택하였습니다.");
                    lbNum.Text = "1";
                    count++;

                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }

                if (ch2.Checked==true)
                {
                    // MessageBox.Show("2번 좌석을 선택하였습니다.");
                    lbNum.Text = "2";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch3.Checked==true)
                {
                    //MessageBox.Show("3번 좌석을 선택하였습니다.");
                    lbNum.Text = "3";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch4.Checked==true)
                {
                    //MessageBox.Show("4번 좌석을 선택하였습니다.");
                    lbNum.Text = "4";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch5.Checked==true)
                {
                    //MessageBox.Show("5번 좌석을 선택하였습니다.");
                    lbNum.Text = "5";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch6.Checked==true)
                {
                    //MessageBox.Show("6번 좌석을 선택하였습니다.");
                    lbNum.Text = "6";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch7.Checked==true)
                {
                    //MessageBox.Show("7번 좌석을 선택하였습니다.");
                    lbNum.Text = "7";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch8.Checked==true)
                {
                    //MessageBox.Show("8번 좌석을 선택하였습니다.");
                    lbNum.Text = "8";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch9.Checked==true)
                {
                    //MessageBox.Show("9번 좌석을 선택하였습니다.");
                    lbNum.Text = "9";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch10.Checked==true)
                {
                    // MessageBox.Show("10번 좌석을 선택하였습니다.");
                    lbNum.Text = "10";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch11.Checked==true)
                {
                    //  MessageBox.Show("11번 좌석을 선택하였습니다.");
                    lbNum.Text = "11";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch12.Checked==true)
                {
                    // MessageBox.Show("12번 좌석을 선택하였습니다.");
                    lbNum.Text = "12";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch13.Checked==true)
                {
                    //  MessageBox.Show("13번 좌석을 선택하였습니다.");
                    lbNum.Text = "13";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch14.Checked==true)
                {
                    // MessageBox.Show("14번 좌석을 선택하였습니다.");
                    lbNum.Text = "14";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch15.Checked==true)
                {
                    // MessageBox.Show("15번 좌석을 선택하였습니다.");
                    lbNum.Text = "15";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch16.Checked==true)
                {
                    //  MessageBox.Show("16번 좌석을 선택하였습니다.");
                    lbNum.Text = "16";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch17.Checked==true)
                {
                    //MessageBox.Show("17번 좌석을 선택하였습니다.");
                    lbNum.Text = "17";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch18.Checked==true)
                {
                    //  MessageBox.Show("18번 좌석을 선택하였습니다.");
                    lbNum.Text = "18";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch19.Checked==true)
                {
                    // MessageBox.Show("19번 좌석을 선택하였습니다.");
                    lbNum.Text = "19";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch20.Checked==true)
                {
                    // MessageBox.Show("20번 좌석을 선택하였습니다.");
                    lbNum.Text = "20";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch21.Checked==true)
                {
                    // MessageBox.Show("21번 좌석을 선택하였습니다.");
                    lbNum.Text = "21";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch22.Checked==true)
                {
                    //  MessageBox.Show("22번 좌석을 선택하였습니다.");
                    lbNum.Text = "22";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch23.Checked==true)
                {
                    //  MessageBox.Show("23번 좌석을 선택하였습니다.");
                    lbNum.Text = "23";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
                if (ch24.Checked==true)
                {
                    //   MessageBox.Show("24번 좌석을 선택하였습니다.");
                    lbNum.Text = "24";
                    count++;
                    int a = int.Parse(lbremain.Text)-1;
                    lbremain.Text=a.ToString();
                }
            }

            if (int.Parse(lbsum.Text)==count)
            {
                MessageBox.Show("좌석이 선택되었습니다.");
                tabControl1.SelectedIndex =2;
            }

            else if (count==0)
            {
                MessageBox.Show("좌석을 선택해주세요."); // 좌석이 하나도 선택되어 있지 않으면 메세지박스 출력
                count=0;
                int a = 24;
                lbremain.Text=a.ToString();
            }

            else if (int.Parse(lbsum.Text)!=count)
            {
                MessageBox.Show("좌석 수를 다시 확인해주세요"); //좌석 수가 전체 인원 수와 다르다면  메세지 ㅏㅂㄱ스 출력
                count=0;
                int a = 24;
                lbremain.Text=a.ToString();

            }

            if (int.Parse(lbsum.Text)>1) //만약 인원수가 1명 이상이라면
            {
                lbother.Text= "외 " + (int.Parse(lbsum.Text)-1).ToString()+"석";
            }

            else
            {
                lbother.Text = "";
            }

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //어른 업다운
        {
            lbsum.Text=(numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown4.Value+numericUpDown5.Value).ToString();


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //어린이 업다운
        {
            lbsum.Text=(numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown4.Value+numericUpDown5.Value).ToString();


        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) //유아 업다운
        {
            lbsum.Text=(numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown4.Value+numericUpDown5.Value).ToString();

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e) //경로 업다운
        {
            lbsum.Text=(numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown4.Value+numericUpDown5.Value).ToString();

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e) //장애인 업다운
        {
            lbsum.Text=(numericUpDown1.Value+numericUpDown2.Value+numericUpDown3.Value+numericUpDown4.Value+numericUpDown5.Value).ToString();

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e) // 결제방법
        {
            lbPay.Items.Clear(); //리스트박스 초기화

            if (cbPay.SelectedIndex == 0) //신용카드
            {
                lbPay.Items.Add("일시불");
                lbPay.Items.Add("3개월 할부");
                lbPay.Items.Add("6개월 할부");
            }

            else if (cbPay.SelectedIndex ==1) //무통장
            {
                lbPay.Items.Add("농협은행");
                lbPay.Items.Add("신한은행");
                lbPay.Items.Add("기업은행");
                lbPay.Items.Add("국민은행");
                lbPay.Items.Add("하나은행");
                lbPay.Items.Add("카카오뱅크");
                lbPay.Items.Add("새마을금고");
                lbPay.Items.Add("우체국");
                lbPay.Items.Add("신협중앙회");
            }

            else if (cbPay.SelectedIndex ==2) //간편결제
            {
                lbPay.Items.Add("토스페이");
                lbPay.Items.Add("PAYCO");
                lbPay.Items.Add("카카오페이");
                lbPay.Items.Add("내통장결제");
                lbPay.Items.Add("BC페이북");
                lbPay.Items.Add("신한pLay");
                lbPay.Items.Add("제로페이");
                lbPay.Items.Add("네이버페이");

            }
        }

        private void btCom_Click(object sender, EventArgs e)
        {



            if (lbPay.Text==""||cbPay.Text=="")
                MessageBox.Show("결제 방법 및 결제 정보를 다시 확인해주세요.");


            else
            {

                MessageBox.Show("결제가 완료되었습니다.");
                tabControl1.SelectedIndex = 3;
            }

            int price = 4500*(int)numericUpDown1.Value+3200*(int)numericUpDown2.Value+2200*(int)numericUpDown3.Value+3000*(int)numericUpDown4.Value+3000*(int)numericUpDown5.Value;

            if (cbSale.SelectedIndex ==0)
            {
                price= price-1000;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex ==1)
            {
                price= price-1500;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex ==2)


            {
                price= price-1000;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex==3)
            {

                price= price-1000;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex ==4)
            {
                price= price-1200;
                lbPrice.Text=price.ToString()+"원";
            }
            lbnn.Text = lbNum.Text;
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cbSale_SelectedIndexChanged(object sender, EventArgs e) //cbSale
        {
            int price = 4500*(int)numericUpDown1.Value+3200*(int)numericUpDown2.Value+2200*(int)numericUpDown3.Value+3000*(int)numericUpDown4.Value+3000*(int)numericUpDown5.Value;

            lbPrice.Text=price.ToString()+"원";

            if (cbSale.SelectedIndex ==0)
            {
                price= price-1000;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex ==1)
            {
                price= price-1500;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex ==2)


            {
                price= price-1000;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex==3)
            {

                price= price-1000;
                lbPrice.Text=price.ToString()+"원";
            }

            else if (cbSale.SelectedIndex ==4)
            {
                price= price-1200;
                lbPrice.Text=price.ToString()+"원";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbnt.Text  = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
