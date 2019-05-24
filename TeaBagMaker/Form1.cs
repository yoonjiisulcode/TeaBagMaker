using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]{"홍차", "녹차", "루이보스차", "국화차"};
        string orgStr = ""; // 선택 결과 저장

        int CountOrgNum = 0; // 초기 카운터


        public Form1()
        {
            InitializeComponent();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            this.orgStr = lblResult.Text;
            if (cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }

        }

        private void CbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbList.Text != "")
            {
                this.lblResult.Text = orgStr + this.cbList.Text;
            }
        }

        private void LblResult_Click(object sender, EventArgs e)
        {

        }


        private void BtnCount_Click(object sender, EventArgs e)
        {
            if (this.cbList.Text != "")
            {
                this.CountOrgNum = Convert.ToInt32(this.cbList.Text);
                this.Timer.Enabled = true;
            }
            else
            {
                this.cbList.Text = "";
                this.cbList.Focus();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.cbList.Text = "";
                MessageBox.Show("펑!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbList.Focus();
            }
            else
            {
                this.CountOrgNum--;
                this.txtCountDown.Text = Convert.ToString(this.CountOrgNum);
            }

        }
    }
}
