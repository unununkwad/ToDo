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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo_Item));
            this.checkBox_Item = new System.Windows.Forms.CheckBox();
            this.label_Item = new System.Windows.Forms.Label();
            this.pictureBox_Edit = new System.Windows.Forms.PictureBox();
            this.pictureBox_Delete = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Delete)).BeginInit();
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
            this.checkBox_Item.MouseHover += new System.EventHandler(this.checkBox_Item_MouseHover);
            // 
            // label_Item
            // 
            this.label_Item.AutoSize = true;
            this.label_Item.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Item.Location = new System.Drawing.Point(30, 10);
            this.label_Item.MaximumSize = new System.Drawing.Size(280, 0);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(27, 13);
            this.label_Item.TabIndex = 1;
            this.label_Item.Text = "text";
            this.label_Item.DoubleClick += new System.EventHandler(this.label_Item_DoubleClick);
            this.label_Item.MouseHover += new System.EventHandler(this.label_Item_MouseHover);
            // 
            // pictureBox_Edit
            // 
            this.pictureBox_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Edit.Image")));
            this.pictureBox_Edit.Location = new System.Drawing.Point(348, 3);
            this.pictureBox_Edit.Name = "pictureBox_Edit";
            this.pictureBox_Edit.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Edit.TabIndex = 2;
            this.pictureBox_Edit.TabStop = false;
            this.pictureBox_Edit.Click += new System.EventHandler(this.pictureBox_Edit_Click);
            this.pictureBox_Edit.MouseHover += new System.EventHandler(this.pictureBox_Edit_MouseHover);
            // 
            // pictureBox_Delete
            // 
            this.pictureBox_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Delete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Delete.Image")));
            this.pictureBox_Delete.Location = new System.Drawing.Point(318, 6);
            this.pictureBox_Delete.Name = "pictureBox_Delete";
            this.pictureBox_Delete.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Delete.TabIndex = 5;
            this.pictureBox_Delete.TabStop = false;
            this.pictureBox_Delete.Click += new System.EventHandler(this.pictureBox_Delete_Click);
            this.pictureBox_Delete.MouseHover += new System.EventHandler(this.pictureBox_Delete_MouseHover);
            // 
            // ToDo_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pictureBox_Delete);
            this.Controls.Add(this.pictureBox_Edit);
            this.Controls.Add(this.label_Item);
            this.Controls.Add(this.checkBox_Item);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ToDo_Item";
            this.Size = new System.Drawing.Size(378, 33);
            this.Click += new System.EventHandler(this.ToDo_Item_Click);
            this.DoubleClick += new System.EventHandler(this.ToDo_Item_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Item;
        private System.Windows.Forms.Label label_Item;
        private System.Windows.Forms.PictureBox pictureBox_Edit;
        private System.Windows.Forms.PictureBox pictureBox_Delete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
