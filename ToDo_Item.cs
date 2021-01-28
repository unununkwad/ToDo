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
    }
}
