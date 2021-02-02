namespace TODO
{
    partial class ToDo_Item
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo_Item));
            this.checkBox_Item = new System.Windows.Forms.CheckBox();
            this.label_Item = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Item
            // 
            this.checkBox_Item.AutoSize = true;
            this.checkBox_Item.Location = new System.Drawing.Point(9, 9);
            this.checkBox_Item.Name = "checkBox_Item";
            this.checkBox_Item.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Item.TabIndex = 0;
            this.checkBox_Item.UseVisualStyleBackColor = true;
            this.checkBox_Item.CheckedChanged += new System.EventHandler(this.checkBox_Item_CheckedChanged);
            this.checkBox_Item.Click += new System.EventHandler(this.checkBox_Item_Click);
            this.checkBox_Item.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox_Item_MouseClick);
            // 
            // label_Item
            // 
            this.label_Item.AutoSize = true;
            this.label_Item.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Item.Location = new System.Drawing.Point(30, 10);
            this.label_Item.MaximumSize = new System.Drawing.Size(320, 0);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(27, 13);
            this.label_Item.TabIndex = 1;
            this.label_Item.Text = "text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(307, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 24);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ToDo_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Item);
            this.Controls.Add(this.checkBox_Item);
            this.Name = "ToDo_Item";
            this.Size = new System.Drawing.Size(378, 33);
            this.Click += new System.EventHandler(this.ToDo_Item_Click);
            this.DoubleClick += new System.EventHandler(this.ToDo_Item_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Item;
        private System.Windows.Forms.Label label_Item;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}
