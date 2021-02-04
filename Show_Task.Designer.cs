namespace TODO
{
    partial class Show_Task
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.button_Done = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button_Reminder = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label_Title_Text = new System.Windows.Forms.Label();
            this.label_Description_Text = new System.Windows.Forms.Label();
            this.label_Date_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.Location = new System.Drawing.Point(9, 9);
            this.label_Title.MaximumSize = new System.Drawing.Size(350, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(46, 17);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Title: ";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Description.Location = new System.Drawing.Point(9, 128);
            this.label_Description.MaximumSize = new System.Drawing.Size(350, 0);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(90, 17);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "Description: ";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Date.Location = new System.Drawing.Point(8, 101);
            this.label_Date.MaximumSize = new System.Drawing.Size(350, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(47, 17);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "Date: ";
            // 
            // button_Done
            // 
            this.button_Done.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Done.Location = new System.Drawing.Point(27, 221);
            this.button_Done.Name = "button_Done";
            this.button_Done.Size = new System.Drawing.Size(75, 23);
            this.button_Done.TabIndex = 3;
            this.button_Done.Text = "Done";
            this.button_Done.UseVisualStyleBackColor = true;
            this.button_Done.Click += new System.EventHandler(this.button_Done_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelete.Location = new System.Drawing.Point(278, 221);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button_Reminder
            // 
            this.button_Reminder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Reminder.Location = new System.Drawing.Point(108, 221);
            this.button_Reminder.Name = "button_Reminder";
            this.button_Reminder.Size = new System.Drawing.Size(83, 23);
            this.button_Reminder.TabIndex = 5;
            this.button_Reminder.Text = "Set a reminder";
            this.button_Reminder.UseVisualStyleBackColor = true;
            this.button_Reminder.Click += new System.EventHandler(this.button_Reminder_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Edit.Location = new System.Drawing.Point(197, 221);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 6;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label_Title_Text
            // 
            this.label_Title_Text.AutoSize = true;
            this.label_Title_Text.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title_Text.Location = new System.Drawing.Point(12, 26);
            this.label_Title_Text.MaximumSize = new System.Drawing.Size(350, 200);
            this.label_Title_Text.Name = "label_Title_Text";
            this.label_Title_Text.Size = new System.Drawing.Size(0, 17);
            this.label_Title_Text.TabIndex = 7;
            // 
            // label_Description_Text
            // 
            this.label_Description_Text.AutoSize = true;
            this.label_Description_Text.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Description_Text.Location = new System.Drawing.Point(12, 145);
            this.label_Description_Text.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.label_Description_Text.MaximumSize = new System.Drawing.Size(350, 190);
            this.label_Description_Text.MinimumSize = new System.Drawing.Size(350, 20);
            this.label_Description_Text.Name = "label_Description_Text";
            this.label_Description_Text.Size = new System.Drawing.Size(350, 20);
            this.label_Description_Text.TabIndex = 8;
            // 
            // label_Date_Text
            // 
            this.label_Date_Text.AutoSize = true;
            this.label_Date_Text.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Date_Text.Location = new System.Drawing.Point(57, 101);
            this.label_Date_Text.MaximumSize = new System.Drawing.Size(350, 0);
            this.label_Date_Text.Name = "label_Date_Text";
            this.label_Date_Text.Size = new System.Drawing.Size(0, 17);
            this.label_Date_Text.TabIndex = 9;
            // 
            // Show_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(384, 250);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.label_Date_Text);
            this.Controls.Add(this.label_Description_Text);
            this.Controls.Add(this.label_Title_Text);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Reminder);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button_Done);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Description);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(0, 270);
            this.Name = "Show_Task";
            this.Text = "Show task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Button button_Done;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button_Reminder;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Label label_Title_Text;
        private System.Windows.Forms.Label label_Description_Text;
        private System.Windows.Forms.Label label_Date_Text;
    }
}