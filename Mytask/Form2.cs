using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mytask
{
    public partial class Form2 : Form
    {
        Form1 form1;

        private string senditem ;

        public Form2(Form1 f)
        {
            form1 = f;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PrioritycomboBox1.Items.Add("高");
            PrioritycomboBox1.Items.Add("中");
            PrioritycomboBox1.Items.Add("低");
            Task_textBox1.Text = "";
            Task_textBox1.ReadOnly = true;
            Task_textBox1.Enabled = false;
            TaskInput_checkBox1.Checked = false;
            Task_dateTimePicker1.Value = DateTime.Now;
            Task_dateTimePicker1.Enabled = false;
            TimecheckBox1.Checked = false;
            TimeSelect_comboBox1.Enabled = false;
            Timeset_button1.Enabled = false;

            TaskItemLoad();
            ScheduledTime_Load();
        }

        private void TaskEntrybutton1_Click(object sender, EventArgs e)
        {
            string spriority = "";

            if (PrioritycomboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("優先度を選択してください");
                return;
            }
            else
            {
                spriority = PrioritycomboBox1.SelectedItem.ToString();
            }

            Senditem();

            if(senditem == "")
            {
                return;
            }

            string stime = Sendtime();

            String[] sendtask = {"",spriority,senditem,stime };
            form1.TasklistView1.Items.Add(new ListViewItem(sendtask));

            Array.Clear(sendtask, 0, 4);
            
            if(TaskInput_checkBox1.Checked == true)
            {
                Task_textBox1.Text = "";
                Task_textBox1.ReadOnly = true;
                TaskInput_checkBox1.Checked = false;
                Task_textBox1.Enabled = false;
            }
            else
            {
                Tasklist_comboBox1.SelectedIndex = -1;
            }

            if(TimecheckBox1.Checked == true)
            {
                stime = "";
                TimecheckBox1.Checked = false;
                Task_dateTimePicker1.Enabled = false;
                TimeSelect_comboBox1.Enabled = false;
                TimeSelect_comboBox1.SelectedIndex = -1;
                Timeset_button1.Enabled = false;
            }

            Task_dateTimePicker1.Value = DateTime.Now;

            spriority = "";
        }

        private string Sendtime()
        {
            string sendtime = "";

            if (TimecheckBox1.Checked == false)
            {
                sendtime = "";
            }
            else
            {
                int th = Task_dateTimePicker1.Value.Hour;
                int tm = Task_dateTimePicker1.Value.Minute;
                String Sth;
                String Stm;

                if (th < 10)
                {
                    Sth = "0" + th.ToString();
                }
                else
                {
                    Sth = th.ToString();
                }

                if (tm < 10)
                {
                    Stm = "0" + tm.ToString();
                }
                else
                {
                    Stm = tm.ToString();
                }

                sendtime = Sth + ":" + Stm;
            }

            return sendtime;
        }

        private void TaskItemLoad()
        {
            List<string> tlist = new List<string>();

            string filepath = Properties.Settings.Default.ListPath;

            if (File.Exists(filepath))
            {
                StreamReader reader = new StreamReader(filepath, Encoding.GetEncoding("UTF-8"));

                while (!reader.EndOfStream)
                {
                    string[] sline = reader.ReadLine().Split(new string[] { "\r\n" }, StringSplitOptions.None);

                    tlist.AddRange(sline);
                }

                foreach (string titem in tlist)
                {
                    Tasklist_comboBox1.Items.Add(titem);
                }

                Graphics g = Tasklist_comboBox1.CreateGraphics();

                int max = 0;

                foreach (string item in Tasklist_comboBox1.Items)
                {
                    max = (int)Math.Max(max, g.MeasureString(item, Tasklist_comboBox1.Font).Width);
                }

                Tasklist_comboBox1.Width = max + 10;
            }
            else
            {
                MessageBox.Show("指定されたパスにTaskList.txtが存在しません");
                Application.Exit();
            }
        }

        private void TaskInput_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TaskInput_checkBox1.Checked == true)
            {
                Task_textBox1.ReadOnly = false;
                Task_textBox1.Enabled = true;
            }
            else
            {
                Task_textBox1.ReadOnly = true;
                Task_textBox1.Enabled = false;
            }

        }

        private string Senditem()
        {
            senditem = "";

            if(TaskInput_checkBox1.Checked == true)
            {
                if (Task_textBox1.Text == "")
                {
                    MessageBox.Show("タスクを入力してください");
                }
                else
                {
                    senditem = Task_textBox1.Text;
                }
            }
            else
            {
                if(Tasklist_comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("タスクを選択してください");
                }
                else
                {
                    senditem = Tasklist_comboBox1.SelectedItem.ToString();
                }
            }

            return senditem;
        }

        private void TimecheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(TimecheckBox1.Checked == true)
            {
                Task_dateTimePicker1.Enabled = true;
                TimeSelect_comboBox1.Enabled = true;
                Timeset_button1.Enabled = true;
            }
            else
            {
                Task_dateTimePicker1.Enabled = false;
                TimeSelect_comboBox1.Enabled = false;
                Timeset_button1.Enabled = false;
            }
        }

        private void ScheduledTime_Load()
        {
            string stime = Properties.Settings.Default.ScheduledTime;
            string[] stline = stime.Split(',');

            foreach (string stitem in stline)
            {
                string initem = stitem + "分後";
                TimeSelect_comboBox1.Items.Add(initem);
            }

            Graphics g = TimeSelect_comboBox1.CreateGraphics();

            int max = 0;

            foreach (string item in TimeSelect_comboBox1.Items)
            {
                max = (int)Math.Max(max, g.MeasureString(item, TimeSelect_comboBox1.Font).Width);
            }

            TimeSelect_comboBox1.Width = max + 20;

        }

        private void Timeset_button1_Click(object sender, EventArgs e)
        {
            if (TimeSelect_comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("時間を選択してください");
            }
            else
            {
                int stm = int.Parse(TimeSelect_comboBox1.SelectedItem.ToString().Replace("分後", ""));

                Task_dateTimePicker1.Value = Task_dateTimePicker1.Value.AddMinutes(stm);

                TimeSelect_comboBox1.SelectedIndex = -1;
            }

        }
    }
}
