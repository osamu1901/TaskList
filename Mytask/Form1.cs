using System;
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

        private void TasklistView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (ListViewItem citem in TasklistView1.CheckedItems)
            {
                citem.BackColor = Color.White;
            }
        }

        private void TasklistView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            foreach (ListViewItem citem in TasklistView1.CheckedItems)
            {
                citem.BackColor = Color.Gray;
            }
        }

        private void task_Allselect_button_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem sitem in TasklistView1.Items)
            {
                sitem.Checked = true;
            }
        }
    }
}
