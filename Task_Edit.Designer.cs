namespace TODO
{
    partial class Task_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task_Edit));
            this.textBox_Task = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Task = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label_Date = new System.Windows.Forms.Label();
            this.button_Edit_Item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Task
            // 
            this.textBox_Task.Location = new System.Drawing.Point(12, 35);
            this.textBox_Task.Multiline = true;
            this.textBox_Task.Name = "textBox_Task";
            this.textBox_Task.Size = new System.Drawing.Size(375, 52);
            this.textBox_Task.TabIndex = 0;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(12, 137);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(375, 107);
            this.textBox_Description.TabIndex = 1;
            // 
            // label_Task
            // 
            this.label_Task.AutoSize = true;
            this.label_Task.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Task.Location = new System.Drawing.Point(12, 9);
            this.label_Task.Name = "label_Task";
            this.label_Task.Size = new System.Drawing.Size(40, 20);
            this.label_Task.TabIndex = 2;
            this.label_Task.Text = "Task";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Description.Location = new System.Drawing.Point(12, 111);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(88, 20);
            this.label_Description.TabIndex = 3;
            this.label_Description.Text = "Description";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 281);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Date.Location = new System.Drawing.Point(12, 259);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(70, 20);
            this.label_Date.TabIndex = 5;
            this.label_Date.Text = "End date";
            // 
            // button_Edit_Item
            // 
            this.button_Edit_Item.Image = ((System.Drawing.Image)(resources.GetObject("button_Edit_Item.Image")));
            this.button_Edit_Item.Location = new System.Drawing.Point(322, 389);
            this.button_Edit_Item.Name = "button_Edit_Item";
            this.button_Edit_Item.Size = new System.Drawing.Size(65, 54);
            this.button_Edit_Item.TabIndex = 6;
            this.button_Edit_Item.UseVisualStyleBackColor = true;
            this.button_Edit_Item.Click += new System.EventHandler(this.button_Edit_Item_Click);
            // 
            // Task_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.button_Edit_Item);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Task);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Task);
            this.Name = "Task_Edit";
            this.Text = "Task_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Task;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Task;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button button_Edit_Item;
    }
}