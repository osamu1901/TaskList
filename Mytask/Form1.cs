﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mytask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            TasklistView1.View = View.Details;
            TasklistView1.Columns.Add("",20);
            TasklistView1.Columns.Add("優先順位",150,HorizontalAlignment.Center);
            TasklistView1.Columns.Add("タスク", 350, HorizontalAlignment.Center);
            TasklistView1.Columns.Add("予定時間", 150, HorizontalAlignment.Center);
            TasklistView1.CheckBoxes = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void Task_Form_Load_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void Task_Delete_button_Click(object sender, EventArgs e)
        {
            if (TasklistView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("タスクを選択してください");
            }
            else
            {
                foreach(ListViewItem ditem in TasklistView1.CheckedItems)
                {
                    TasklistView1.Items.Remove(ditem);
                }
            }
        }
                
        private void TasklistView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem citem in TasklistView1.Items)
            {
                if (citem.Checked)
                {
                    citem.BackColor = Color.LightGray;
                }
                else
                {
                    citem.BackColor = Color.White;
                }
                
            }
        }

        private void task_Allselect_button_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem sitem in TasklistView1.Items)
            {
                sitem.Checked = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           foreach(ListViewItem item in TasklistView1.Items)
            {
                if(item.Checked == false && item.SubItems[3].Text != "")
                {
                    if(DateTime.Now.ToString("HH:mm") == item.SubItems[3].Text && DateTime.Now.Second == 0)
                    {
                        MessageBox.Show(item.SubItems[2].Text,"タスク確認");
                    }
                    
                }
            }
        }
    }
}
