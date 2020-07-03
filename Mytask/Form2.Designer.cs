namespace Mytask
{
    partial class Form2
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
            this.Task_textBox1 = new System.Windows.Forms.TextBox();
            this.Task_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TaskEntrybutton1 = new System.Windows.Forms.Button();
            this.PrioritycomboBox1 = new System.Windows.Forms.ComboBox();
            this.TimecheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tasklist_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TaskInput_checkBox1 = new System.Windows.Forms.CheckBox();
            this.Timeset_button1 = new System.Windows.Forms.Button();
            this.TimeSelect_comboBox1 = new System.Windows.Forms.ComboBox();
            this.Reset_button1 = new System.Windows.Forms.Button();
            this.Close_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task_textBox1
            // 
            this.Task_textBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Task_textBox1.Location = new System.Drawing.Point(20, 155);
            this.Task_textBox1.Multiline = true;
            this.Task_textBox1.Name = "Task_textBox1";
            this.Task_textBox1.Size = new System.Drawing.Size(248, 60);
            this.Task_textBox1.TabIndex = 0;
            // 
            // Task_dateTimePicker1
            // 
            this.Task_dateTimePicker1.CustomFormat = "HH:mm";
            this.Task_dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Task_dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Task_dateTimePicker1.Location = new System.Drawing.Point(287, 85);
            this.Task_dateTimePicker1.Name = "Task_dateTimePicker1";
            this.Task_dateTimePicker1.ShowUpDown = true;
            this.Task_dateTimePicker1.Size = new System.Drawing.Size(105, 23);
            this.Task_dateTimePicker1.TabIndex = 2;
            // 
            // TaskEntrybutton1
            // 
            this.TaskEntrybutton1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.TaskEntrybutton1.Location = new System.Drawing.Point(285, 196);
            this.TaskEntrybutton1.Name = "TaskEntrybutton1";
            this.TaskEntrybutton1.Size = new System.Drawing.Size(107, 48);
            this.TaskEntrybutton1.TabIndex = 3;
            this.TaskEntrybutton1.Text = "タスク登録";
            this.TaskEntrybutton1.UseVisualStyleBackColor = true;
            this.TaskEntrybutton1.Click += new System.EventHandler(this.TaskEntrybutton1_Click);
            // 
            // PrioritycomboBox1
            // 
            this.PrioritycomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrioritycomboBox1.Font = new System.Drawing.Font("MS UI Gothic", 13.25F);
            this.PrioritycomboBox1.FormattingEnabled = true;
            this.PrioritycomboBox1.Location = new System.Drawing.Point(199, 86);
            this.PrioritycomboBox1.Name = "PrioritycomboBox1";
            this.PrioritycomboBox1.Size = new System.Drawing.Size(44, 26);
            this.PrioritycomboBox1.TabIndex = 4;
            // 
            // TimecheckBox1
            // 
            this.TimecheckBox1.AutoSize = true;
            this.TimecheckBox1.CausesValidation = false;
            this.TimecheckBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimecheckBox1.Location = new System.Drawing.Point(287, 59);
            this.TimecheckBox1.Name = "TimecheckBox1";
            this.TimecheckBox1.Size = new System.Drawing.Size(91, 20);
            this.TimecheckBox1.TabIndex = 5;
            this.TimecheckBox1.Text = "時間指定";
            this.TimecheckBox1.UseVisualStyleBackColor = true;
            this.TimecheckBox1.CheckedChanged += new System.EventHandler(this.TimecheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(196, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "優先度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(138, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "タスク入力";
            // 
            // Tasklist_comboBox1
            // 
            this.Tasklist_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tasklist_comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Tasklist_comboBox1.FormattingEnabled = true;
            this.Tasklist_comboBox1.Location = new System.Drawing.Point(22, 86);
            this.Tasklist_comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.Tasklist_comboBox1.Name = "Tasklist_comboBox1";
            this.Tasklist_comboBox1.Size = new System.Drawing.Size(109, 24);
            this.Tasklist_comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "タスク選択リスト";
            // 
            // TaskInput_checkBox1
            // 
            this.TaskInput_checkBox1.AutoSize = true;
            this.TaskInput_checkBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TaskInput_checkBox1.Location = new System.Drawing.Point(21, 123);
            this.TaskInput_checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.TaskInput_checkBox1.Name = "TaskInput_checkBox1";
            this.TaskInput_checkBox1.Size = new System.Drawing.Size(91, 20);
            this.TaskInput_checkBox1.TabIndex = 10;
            this.TaskInput_checkBox1.Text = "直接入力";
            this.TaskInput_checkBox1.UseVisualStyleBackColor = true;
            this.TaskInput_checkBox1.CheckedChanged += new System.EventHandler(this.TaskInput_checkBox1_CheckedChanged);
            // 
            // Timeset_button1
            // 
            this.Timeset_button1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Timeset_button1.Location = new System.Drawing.Point(349, 122);
            this.Timeset_button1.Name = "Timeset_button1";
            this.Timeset_button1.Size = new System.Drawing.Size(52, 27);
            this.Timeset_button1.TabIndex = 12;
            this.Timeset_button1.Text = "セット";
            this.Timeset_button1.UseVisualStyleBackColor = true;
            this.Timeset_button1.Click += new System.EventHandler(this.Timeset_button1_Click);
            // 
            // TimeSelect_comboBox1
            // 
            this.TimeSelect_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeSelect_comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.TimeSelect_comboBox1.FormattingEnabled = true;
            this.TimeSelect_comboBox1.Location = new System.Drawing.Point(272, 123);
            this.TimeSelect_comboBox1.Name = "TimeSelect_comboBox1";
            this.TimeSelect_comboBox1.Size = new System.Drawing.Size(56, 24);
            this.TimeSelect_comboBox1.TabIndex = 13;
            // 
            // Reset_button1
            // 
            this.Reset_button1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Reset_button1.Location = new System.Drawing.Point(33, 229);
            this.Reset_button1.Name = "Reset_button1";
            this.Reset_button1.Size = new System.Drawing.Size(87, 48);
            this.Reset_button1.TabIndex = 14;
            this.Reset_button1.Text = "リセット";
            this.Reset_button1.UseVisualStyleBackColor = true;
            this.Reset_button1.Click += new System.EventHandler(this.Reset_button1_Click);
            // 
            // Close_button1
            // 
            this.Close_button1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Close_button1.Location = new System.Drawing.Point(156, 229);
            this.Close_button1.Name = "Close_button1";
            this.Close_button1.Size = new System.Drawing.Size(87, 48);
            this.Close_button1.TabIndex = 15;
            this.Close_button1.Text = "閉じる";
            this.Close_button1.UseVisualStyleBackColor = true;
            this.Close_button1.Click += new System.EventHandler(this.Close_button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(403, 308);
            this.Controls.Add(this.Close_button1);
            this.Controls.Add(this.Reset_button1);
            this.Controls.Add(this.TimeSelect_comboBox1);
            this.Controls.Add(this.Timeset_button1);
            this.Controls.Add(this.TaskInput_checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tasklist_comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimecheckBox1);
            this.Controls.Add(this.PrioritycomboBox1);
            this.Controls.Add(this.TaskEntrybutton1);
            this.Controls.Add(this.Task_dateTimePicker1);
            this.Controls.Add(this.Task_textBox1);
            this.Name = "Form2";
            this.Text = "タスク入力画面";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Task_textBox1;
        private System.Windows.Forms.DateTimePicker Task_dateTimePicker1;
        private System.Windows.Forms.Button TaskEntrybutton1;
        private System.Windows.Forms.ComboBox PrioritycomboBox1;
        private System.Windows.Forms.CheckBox TimecheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Tasklist_comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox TaskInput_checkBox1;
        private System.Windows.Forms.Button Timeset_button1;
        private System.Windows.Forms.ComboBox TimeSelect_comboBox1;
        private System.Windows.Forms.Button Reset_button1;
        private System.Windows.Forms.Button Close_button1;
    }
}