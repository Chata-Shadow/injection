using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 注入整合
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void 注入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remote remt = new remote();
            //窗体最大化

            remt.WindowState = FormWindowState.Maximized;
            //去掉边框
            remt.FormBorderStyle = FormBorderStyle.None;

            panel1.Controls.Add(remt);

            //remt.MdiParent = this;

            remt.Show();
        }
    }
}
