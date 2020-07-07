namespace Mytask
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TasklistView1 = new System.Windows.Forms.ListView();
            this.Task_Form_Load = new System.Windows.Forms.Button();
            this.Task_Delete_button = new System.Windows.Forms.Button();
            this.task_Allselect_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TasklistView1
            // 
            this.TasklistView1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TasklistView1.Location = new System.Drawing.Point(12, 129);
            this.TasklistView1.Name = "TasklistView1";
            this.TasklistView1.RightToLeftLayout = true;
            this.TasklistView1.Size = new System.Drawing.Size(675, 217);
            this.TasklistView1.TabIndex = 0;
            this.TasklistView1.UseCompatibleStateImageBehavior = false;
            this.TasklistView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.TasklistView1_ItemChecked);
            // 
            // Task_Form_Load
            // 
            this.Task_Form_Load.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Task_Form_Load.Location = new System.Drawing.Point(294, 37);
            this.Task_Form_Load.Name = "Task_Form_Load";
            this.Task_Form_Load.Size = new System.Drawing.Size(127, 59);
            this.Task_Form_Load.TabIndex = 1;
            this.Task_Form_Load.Text = "タスク入力";
            this.Task_Form_Load.UseVisualStyleBackColor = true;
            this.Task_Form_Load.Click += new System.EventHandler(this.Task_Form_Load_Click);
            // 
            // Task_Delete_button
            // 
            this.Task_Delete_button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Task_Delete_button.Location = new System.Drawing.Point(173, 361);
            this.Task_Delete_button.Name = "Task_Delete_button";
            this.Task_Delete_button.Size = new System.Drawing.Size(115, 76);
            this.Task_Delete_button.TabIndex = 2;
            this.Task_Delete_button.Text = "タスク削除";
            this.Task_Delete_button.UseVisualStyleBackColor = true;
            this.Task_Delete_button.Click += new System.EventHandler(this.Task_Delete_button_Click);
            // 
            // task_Allselect_button
            // 
            this.task_Allselect_button.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.task_Allselect_button.Location = new System.Drawing.Point(436, 361);
            this.task_Allselect_button.Name = "task_Allselect_button";
            this.task_Allselect_button.Size = new System.Drawing.Size(115, 76);
            this.task_Allselect_button.TabIndex = 3;
            this.task_Allselect_button.Text = "全選択";
            this.task_Allselect_button.UseVisualStyleBackColor = true;
            this.task_Allselect_button.Click += new System.EventHandler(this.task_Allselect_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 478);
            this.Controls.Add(this.task_Allselect_button);
            this.Controls.Add(this.Task_Delete_button);
            this.Controls.Add(this.Task_Form_Load);
            this.Controls.Add(this.TasklistView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Task_Form_Load;
        private System.Windows.Forms.Button Task_Delete_button;
        internal System.Windows.Forms.ListView TasklistView1;
        private System.Windows.Forms.Button task_Allselect_button;
        private System.Windows.Forms.Timer timer1;
    }
}

