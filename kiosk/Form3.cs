using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listView1.View=View.Details; // View.Details가 선언되어있어야 열 값이 출력됨
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e) //입력 이벤트
        {
            if (tbName.Text ==""||tbPhone.Text==""|| tbOrg.Text=="") //만약 이름, 휴대폰, 소속 셋 중 하나라도 입력되지 않았다면
                MessageBox.Show("입력하지 않은 곳을 채워주세요."); //메세지 박스 출력
            else
            {
                listView1.Items.Add(new ListViewItem(new string[] { tbName.Text, tbPhone.Text, tbOrg.Text })); //텍스트 박스에 입력된 값을 리스트의 속성에 추가함
                tbName.Clear(); //테스트 박스 초기화
                tbPhone.Clear(); 
                tbOrg.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //삭제 이벤트
        {
            try //예외처리
            {              
                listView1.Items.RemoveAt(listView1.FocusedItem.Index); //선택된 인덱스를 리스트의 속성에서 삭제함
            } catch(Exception exp)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }
        }

        private void btnChange_Click(object sender, EventArgs e) //수정 이벤트
        {
            if (tbName.Text ==""||tbPhone.Text==""||tbOrg.Text=="")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
                return;
            }
                
            try
            {
                listView1.SelectedItems[0].SubItems[0].Text=tbName.Text; //SelectedItems[0] : 지정된 인덱스의 항목을 가져옴
                listView1.SelectedItems[0].SubItems[1].Text=tbPhone.Text; //SubItems[0] : 지정된 행의 Columns을 나타냄
                listView1.SelectedItems[0].SubItems[2].Text=tbOrg.Text; //텍스트 박스에 입력된 값을 지정된 인덱스의 지정된 행에 입력
            }

            catch(Exception exp)
            {
                MessageBox.Show("입력 항목 및 리스트 선택을 다시 살펴보세요.");
            }
            finally
            {
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e) //삽입 이벤트
        {
            if (tbName.Text ==""||tbPhone.Text==""||tbOrg.Text=="")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
                return;
            }
            try
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.Insert(index, new ListViewItem(new string[] { tbName.Text, tbPhone.Text, tbOrg.Text }));
            }
            catch (Exception exp)
            {
                MessageBox.Show("입력 항목 및 리스트 선택을 다시 살펴보세요.");
            }

            finally
            {
                tbName.Clear();
                tbPhone.Clear();
                tbOrg.Clear();
            }
        }
    }
}
