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
            this.Task_dateTimePicker1.Location = new System.Drawing.Point(291, 104);
            this.Task_dateTimePicker1.Name = "Task_dateTimePicker1";
            this.Task_dateTimePicker1.ShowUpDown = true;
            this.Task_dateTimePicker1.Size = new System.Drawing.Size(117, 23);
            this.Task_dateTimePicker1.TabIndex = 2;
            // 
            // TaskEntrybutton1
            // 
            this.TaskEntrybutton1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.TaskEntrybutton1.Location = new System.Drawing.Point(52, 229);
            this.TaskEntrybutton1.Name = "TaskEntrybutton1";
            this.TaskEntrybutton1.Size = new System.Drawing.Size(107, 48);
            this.TaskEntrybutton1.TabIndex = 3;
            this.TaskEntrybutton1.Text = "タスク登録";
            this.TaskEntrybutton1.UseVisualStyleBackColor = true;
            this.TaskEntrybutton1.Click += new System.EventHandler(this.TaskEntrybutton1_Click);
            // 
            // PrioritycomboBox1
            // 
            this.PrioritycomboBox1.Font = new System.Drawing.Font("MS UI Gothic", 13.25F);
            this.PrioritycomboBox1.FormattingEnabled = true;
            this.PrioritycomboBox1.Location = new System.Drawing.Point(364, 142);
            this.PrioritycomboBox1.Name = "PrioritycomboBox1";
            this.PrioritycomboBox1.Size = new System.Drawing.Size(44, 26);
            this.PrioritycomboBox1.TabIndex = 4;
            // 
            // TimecheckBox1
            // 
            this.TimecheckBox1.AutoSize = true;
            this.TimecheckBox1.CausesValidation = false;
            this.TimecheckBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimecheckBox1.Location = new System.Drawing.Point(291, 70);
            this.TimecheckBox1.Name = "TimecheckBox1";
            this.TimecheckBox1.Size = new System.Drawing.Size(91, 20);
            this.TimecheckBox1.TabIndex = 5;
            this.TimecheckBox1.Text = "時間不要";
            this.TimecheckBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(288, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "優先度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(50, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "タスク入力";
            // 
            // Tasklist_comboBox1
            // 
            this.Tasklist_comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Tasklist_comboBox1.FormattingEnabled = true;
            this.Tasklist_comboBox1.Location = new System.Drawing.Point(20, 82);
            this.Tasklist_comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tasklist_comboBox1.Name = "Tasklist_comboBox1";
            this.Tasklist_comboBox1.Size = new System.Drawing.Size(109, 24);
            this.Tasklist_comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(18, 58);
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
            this.TaskInput_checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaskInput_checkBox1.Name = "TaskInput_checkBox1";
            this.TaskInput_checkBox1.Size = new System.Drawing.Size(91, 20);
            this.TaskInput_checkBox1.TabIndex = 10;
            this.TaskInput_checkBox1.Text = "直接入力";
            this.TaskInput_checkBox1.UseVisualStyleBackColor = true;
            this.TaskInput_checkBox1.CheckedChanged += new System.EventHandler(this.TaskInput_checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 287);
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
            this.Text = "Form2";
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
    }
}