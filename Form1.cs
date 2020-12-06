using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Net.Http;

namespace RichTextReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 窗口载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string cmd = Environment.CommandLine;

            string[] para = cmd.Split('\"');

            if(para.Length > 3)
            {
                string path = para[3];
                string rtf = System.IO.File.ReadAllText(path);
                richTextBox.Rtf = rtf;
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RichText(*.rewrtf)|*.rewrtf";
            DialogResult result = saveFileDialog1.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                saveFileDialog1.FileOk += ((x, y) => { MessageBox.Show(fileName); });
                System.IO.File.WriteAllText(fileName, richTextBox.Rtf);
            }
            //System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\test.rewrtf", richTextBox.Rtf);

        }
        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRead_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                string rtf = System.IO.File.ReadAllText(fileName);
                richTextBox.Rtf = rtf;
            }
        }
        /// <summary>
        /// 标题1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTitle1_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("黑体", 36f, (FontStyle.Bold));
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.SelectionIndent = 0;
        }

        private void buttonTitle2_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("黑体", 24f, (FontStyle.Underline | FontStyle.Bold));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 0;
        }

        private void buttonTitle3_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("宋体", 18f, (FontStyle.Bold));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 0;
        }

        private void buttonContent_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("宋体", 12f, (FontStyle.Regular));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 20;
        }

        private void buttonContentItalic_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("宋体", 12f, (FontStyle.Italic));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 20;
        }
    }
}
