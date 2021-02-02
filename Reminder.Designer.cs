namespace TODO
{
    partial class Reminder
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
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Remind = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Show
            // 
            this.button_Show.Location = new System.Drawing.Point(13, 150);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(179, 23);
            this.button_Show.TabIndex = 0;
            this.button_Show.Text = "Show task";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(215, 150);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(171, 23);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Silver;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Title.ForeColor = System.Drawing.Color.MediumBlue;
            this.label_Title.Location = new System.Drawing.Point(3, 0);
            this.label_Title.MaximumSize = new System.Drawing.Size(355, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(51, 20);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "label1";
            // 
            // label_Remind
            // 
            this.label_Remind.AutoSize = true;
            this.label_Remind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Remind.Location = new System.Drawing.Point(93, 95);
            this.label_Remind.Name = "label_Remind";
            this.label_Remind.Size = new System.Drawing.Size(210, 18);
            this.label_Remind.TabIndex = 3;
            this.label_Remind.Text = "You have to do this task today.";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.MaximumSize = new System.Drawing.Size(374, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 26);
            this.panel1.TabIndex = 4;
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 188);
            this.Controls.Add(this.label_Remind);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.panel1);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Remind;
        private System.Windows.Forms.Panel panel1;
    }
}