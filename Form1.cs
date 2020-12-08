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
        private const string formName = "REW Text Reader"; 
        private string currentFileName = null;
        private bool isChanged = false;

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
            //重设名称
            ResetFormName();

            //打开命令
            string cmd = Environment.CommandLine;
            string[] para = cmd.Split('\"');
            if(para.Length > 3)
            {
                string path = para[3];
                string rtf = System.IO.File.ReadAllText(path);
                richTextBox.Rtf = rtf;

                currentFileName = path;
                isChanged = false;
                ResetFormName();
            }

            //全屏
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// 重新显示名字
        /// </summary>
        /// <param name="str"></param>
        private void ResetFormName()
        {
            if(currentFileName == null)
            {
                this.Text = formName;
            }
            else
            {
                this.Text = formName + "(" + currentFileName.Substring(currentFileName.LastIndexOf('\\') + 1) + ")" + (isChanged ? "*" : "");
            }
            
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(currentFileName))
            {
                System.IO.File.WriteAllText(currentFileName, richTextBox.Rtf);
                isChanged = false;
                ResetFormName();

                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("目录不存在");
            }
            #region 另存为代码
            //saveFileDialog1.Filter = "RichText(*.rewrtf)|*.rewrtf";
            //DialogResult result = saveFileDialog1.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    string fileName = saveFileDialog1.FileName;
            //    saveFileDialog1.FileOk += ((x, y) => { MessageBox.Show(fileName); });
            //    System.IO.File.WriteAllText(fileName, richTextBox.Rtf);
            //}
            #endregion
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

                currentFileName = fileName;
                isChanged = false;
                ResetFormName();
            }
        }
        /// <summary>
        /// 标题1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTitle1_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("黑体", 32f, (FontStyle.Bold));
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.SelectionIndent = 0;
            richTextBox.SelectionHangingIndent = 0;
        }

        private void buttonTitle2_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("黑体", 20f, (FontStyle.Underline | FontStyle.Bold));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 0;
            richTextBox.SelectionHangingIndent = 0;
        }

        private void buttonTitle3_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("宋体", 16f, (FontStyle.Bold));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 0;
            richTextBox.SelectionHangingIndent = 0;
        }

        private void buttonContent_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("宋体", 12f, (FontStyle.Regular));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 20;
            richTextBox.SelectionHangingIndent = -20;
        }

        private void buttonContentItalic_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("宋体", 12f, (FontStyle.Italic));
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.SelectionIndent = 20;
            richTextBox.SelectionHangingIndent = -20;
        }
        /// <summary>
        /// 文字改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isChanged)
            {
                isChanged = true;
                ResetFormName();
            }
        }
        /// <summary>
        /// 事件：KeyDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                buttonSaveFile.PerformClick();
            }
        }
        /// <summary>
        /// 事件：KeyPress
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
