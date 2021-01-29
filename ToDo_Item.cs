using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO
{
    public partial class ToDo_Item : UserControl
    {
        public ToDo_Item()
        {
            InitializeComponent();
        }
        string Description = "test";
        public ToDo_Item(string Text, bool Checked)
        {
            InitializeComponent();
            label_Item.Text = Text;
            checkBox_Item.Checked = Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Task_Edit edit = new TODO.Task_Edit(label_Item.Text, Description);
            edit.Show();
        }

        private void checkBox_Item_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Item.Checked == true)
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#85B185");
            }
            else
            {
                BackColor = System.Drawing.ColorTranslator.FromHtml("#dcdcdc");
            }
        }
    }
}
