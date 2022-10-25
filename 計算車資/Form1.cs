using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算車資
{
	public partial class Form1 : Form
	{
		//根據客戶性別及年齡計算應付車資, 規則如下:
        // <=3 零元
        // >=70, 男, 2元
        // >=60, 女, 3元
        // 全票, 15元
		public Form1()
		{
			InitializeComponent();
			resultlbl.Text = string.Empty;
		}

		private void calcbtn_Click(object sender, EventArgs e)
		{
			int age,fee;
			bool gender;
			string reason;
			try
			{
				age = GetAge();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			try
			{
				gender = GetGender();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			

			if (age <= 3)
			{
				fee = 0;
				reason = "小於三歲";
			}
			else if (gender == true && age >= 70)
			{
				fee = 2;
				reason = "超過70歲男性";
			}
			else if (gender == false && age >= 60)
			{
				fee = 3;
				reason = "超過60歲女性";
			}
			else
			{
				fee = 15;
				reason = "全票";
			}
			
			Display(fee,reason);
	
		}

		private bool GetGender()
		{
			if (malebtn.Checked == false && femalebtn.Checked == false)
			{
				throw new Exception("請勾選性別");
			}
			else if (malebtn.Checked == true)
			{
				return true;
			}
			else 
				return false;
		}

		private void Display(int fee,string resson)
		{
			string result = $" 車資: {fee} \r\n\r\n 原因: {resson}";
			resultlbl.Text = result;
		}

		private int GetAge()
		{
			string input = agetxtb.Text;
			bool isInt = int.TryParse(input, out int age);
			if (isInt==false || age < 0)
			{
				throw new Exception("請輸入正整數");
			}
			return age ;
		}
	}
}
