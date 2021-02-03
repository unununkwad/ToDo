namespace TODO
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Add_Task = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Refresh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_Calendar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddItem_Text = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Calendar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Task
            // 
            this.Add_Task.Location = new System.Drawing.Point(340, 23);
            this.Add_Task.Name = "Add_Task";
            this.Add_Task.Size = new System.Drawing.Size(75, 23);
            this.Add_Task.TabIndex = 0;
            this.Add_Task.Text = "Add";
            this.Add_Task.UseVisualStyleBackColor = true;
            this.Add_Task.Click += new System.EventHandler(this.Add_Task_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.pictureBox_Refresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox_Calendar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 71);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox_Refresh
            // 
            this.pictureBox_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Refresh.Image")));
            this.pictureBox_Refresh.Location = new System.Drawing.Point(12, 11);
            this.pictureBox_Refresh.Name = "pictureBox_Refresh";
            this.pictureBox_Refresh.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_Refresh.TabIndex = 7;
            this.pictureBox_Refresh.TabStop = false;
            this.pictureBox_Refresh.Click += new System.EventHandler(this.pictureBox_Refresh_Click);
            this.pictureBox_Refresh.MouseHover += new System.EventHandler(this.pictureBox_Refresh_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(172, 11);
            this.label2.MaximumSize = new System.Drawing.Size(80, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "To do list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // pictureBox_Calendar
            // 
            this.pictureBox_Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Calendar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Calendar.Image")));
            this.pictureBox_Calendar.Location = new System.Drawing.Point(362, 12);
            this.pictureBox_Calendar.Name = "pictureBox_Calendar";
            this.pictureBox_Calendar.Size = new System.Drawing.Size(41, 37);
            this.pictureBox_Calendar.TabIndex = 4;
            this.pictureBox_Calendar.TabStop = false;
            this.pictureBox_Calendar.Click += new System.EventHandler(this.pictureBox_Calendar_Click);
            this.pictureBox_Calendar.MouseHover += new System.EventHandler(this.pictureBox_Calendar_MouseHover);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(12, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 281);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.AddItem_Text);
            this.panel2.Controls.Add(this.Add_Task);
            this.panel2.Location = new System.Drawing.Point(0, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 57);
            this.panel2.TabIndex = 3;
            // 
            // AddItem_Text
            // 
            this.AddItem_Text.Location = new System.Drawing.Point(12, 25);
            this.AddItem_Text.Name = "AddItem_Text";
            this.AddItem_Text.Size = new System.Drawing.Size(322, 20);
            this.AddItem_Text.TabIndex = 4;
            this.AddItem_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddItem_Text_KeyDown);
            this.AddItem_Text.MouseHover += new System.EventHandler(this.AddItem_Text_MouseHover);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(10, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(115, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "calendar";
            this.groupBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "To do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Calendar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Task;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox AddItem_Text;
        private System.Windows.Forms.PictureBox pictureBox_Calendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_Refresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

