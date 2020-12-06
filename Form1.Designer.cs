namespace RichTextReader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonTitle1 = new System.Windows.Forms.Button();
            this.buttonTitle2 = new System.Windows.Forms.Button();
            this.buttonTitle3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonContent = new System.Windows.Forms.Button();
            this.buttonContentItalic = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(30, 15);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(580, 402);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(682, 57);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRead
            // 
            this.buttonRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRead.Location = new System.Drawing.Point(682, 14);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(86, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "读取";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonTitle1
            // 
            this.buttonTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitle1.Location = new System.Drawing.Point(643, 140);
            this.buttonTitle1.Name = "buttonTitle1";
            this.buttonTitle1.Size = new System.Drawing.Size(125, 41);
            this.buttonTitle1.TabIndex = 3;
            this.buttonTitle1.Text = "大标题";
            this.buttonTitle1.UseVisualStyleBackColor = true;
            this.buttonTitle1.Click += new System.EventHandler(this.buttonTitle1_Click);
            // 
            // buttonTitle2
            // 
            this.buttonTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitle2.Location = new System.Drawing.Point(643, 187);
            this.buttonTitle2.Name = "buttonTitle2";
            this.buttonTitle2.Size = new System.Drawing.Size(125, 41);
            this.buttonTitle2.TabIndex = 4;
            this.buttonTitle2.Text = "小标题";
            this.buttonTitle2.UseVisualStyleBackColor = true;
            this.buttonTitle2.Click += new System.EventHandler(this.buttonTitle2_Click);
            // 
            // buttonTitle3
            // 
            this.buttonTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTitle3.Location = new System.Drawing.Point(643, 234);
            this.buttonTitle3.Name = "buttonTitle3";
            this.buttonTitle3.Size = new System.Drawing.Size(125, 41);
            this.buttonTitle3.TabIndex = 5;
            this.buttonTitle3.Text = "标题3";
            this.buttonTitle3.UseVisualStyleBackColor = true;
            this.buttonTitle3.Click += new System.EventHandler(this.buttonTitle3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(643, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(643, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "读取";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonContent
            // 
            this.buttonContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContent.Location = new System.Drawing.Point(643, 281);
            this.buttonContent.Name = "buttonContent";
            this.buttonContent.Size = new System.Drawing.Size(125, 41);
            this.buttonContent.TabIndex = 6;
            this.buttonContent.Text = "正文";
            this.buttonContent.UseVisualStyleBackColor = true;
            this.buttonContent.Click += new System.EventHandler(this.buttonContent_Click);
            // 
            // buttonContentItalic
            // 
            this.buttonContentItalic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContentItalic.Location = new System.Drawing.Point(643, 328);
            this.buttonContentItalic.Name = "buttonContentItalic";
            this.buttonContentItalic.Size = new System.Drawing.Size(125, 41);
            this.buttonContentItalic.TabIndex = 7;
            this.buttonContentItalic.Text = "正文斜体";
            this.buttonContentItalic.UseVisualStyleBackColor = true;
            this.buttonContentItalic.Click += new System.EventHandler(this.buttonContentItalic_Click);
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.buttonContentItalic);
            this.Controls.Add(this.buttonContent);
            this.Controls.Add(this.buttonTitle3);
            this.Controls.Add(this.buttonTitle2);
            this.Controls.Add(this.buttonTitle1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "REW RTF Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonTitle1;
        private System.Windows.Forms.Button buttonTitle2;
        private System.Windows.Forms.Button buttonTitle3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonContent;
        private System.Windows.Forms.Button buttonContentItalic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Messaging.MessageQueue messageQueue1;
    }
}

