namespace WordBookMarkDeal
{
    partial class MainForm
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
            if (disposing && ( components != null ))
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
            this.filePanel = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btDeleteAllBookmark = new System.Windows.Forms.Button();
            this.filePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filePanel.Controls.Add(this.txtFilePath);
            this.filePanel.Controls.Add(this.btLoad);
            this.filePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePanel.Location = new System.Drawing.Point(0, 0);
            this.filePanel.Name = "filePanel";
            this.filePanel.Size = new System.Drawing.Size(800, 34);
            this.filePanel.TabIndex = 0;
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilePath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFilePath.Location = new System.Drawing.Point(69, 10);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(719, 16);
            this.txtFilePath.TabIndex = 10000;
            this.txtFilePath.TabStop = false;
            this.txtFilePath.Text = "请选择加载文件";
            this.txtFilePath.WordWrap = false;
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLoad.Location = new System.Drawing.Point(3, 7);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(60, 20);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "加载";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.controlPanel.Controls.Add(this.btDeleteAllBookmark);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(0, 34);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(800, 416);
            this.controlPanel.TabIndex = 1;
            // 
            // btDeleteAllBookmark
            // 
            this.btDeleteAllBookmark.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteAllBookmark.Location = new System.Drawing.Point(3, 6);
            this.btDeleteAllBookmark.Name = "btDeleteAllBookmark";
            this.btDeleteAllBookmark.Size = new System.Drawing.Size(111, 23);
            this.btDeleteAllBookmark.TabIndex = 0;
            this.btDeleteAllBookmark.Text = "删除所有的书签";
            this.btDeleteAllBookmark.UseVisualStyleBackColor = true;
            this.btDeleteAllBookmark.Click += new System.EventHandler(this.BtDeleteAllBookmark_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.filePanel);
            this.Name = "MainForm";
            this.Text = "书签处理";
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btDeleteAllBookmark;
    }
}

