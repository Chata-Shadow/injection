using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 注入整合
{
    public partial class remote : Form
    {
        public remote()
        {
            InitializeComponent();
            this.TopLevel = false;
        }
        public String InjectName = "";
        public String InjectDll = "";

        [DllImport("远程注入dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool RemoteThreadInject(String szBuf, String szDll);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InjectName = textBox1.Text;
            InjectDll = textBox2.Text;
            bool Result = RemoteThreadInject(InjectName, InjectDll);
        }
    }
}
