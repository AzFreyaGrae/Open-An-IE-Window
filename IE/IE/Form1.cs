using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadEmbeddedHtml();
        }
        
        private void LoadEmbeddedHtml()
        {
            // 获取嵌入资源的命名空间
            string resourceNamespace = "IE"; // 修改为你的命名空间

            // 构建资源路径
            string resourcePath = resourceNamespace + ".10.html";

            // 从程序集中读取资源文件内容
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream resourceStream = assembly.GetManifestResourceStream(resourcePath);

            if (resourceStream != null)
            {
                using (StreamReader reader = new StreamReader(resourceStream))
                {
                    string htmlContent = reader.ReadToEnd();
                    webBrowser1.DocumentText = htmlContent;
                }
            }
            else
            {
                MessageBox.Show("Failed to load embedded HTML resource.");
            }
        }

        private void 软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" - 这是偶然间发现的一个新方式！！！ \n - 不知道在其它电脑上怎样？ \n - Ps:新发现！嘿咻!", "Software Message !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" - Ae （2023/03/28） \n - FreyaGrace  \n - Q Group: 767508000", "Author Message !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 广告位招租ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" - 再这样下去，就要穷的吃土了！！！！", "Advertisement Message !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
