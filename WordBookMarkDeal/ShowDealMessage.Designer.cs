namespace WordBookMarkDeal
{
    public partial class ShowDealMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtShowMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtShowMessage
            // 
            this.txtShowMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShowMessage.Location = new System.Drawing.Point(0, 0);
            this.txtShowMessage.Name = "txtShowMessage";
            this.txtShowMessage.ReadOnly = true;
            this.txtShowMessage.Size = new System.Drawing.Size(800, 450);
            this.txtShowMessage.TabIndex = 0;
            this.txtShowMessage.Text = "";
            // 
            // ShowDealMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShowMessage);
            this.Name = "ShowDealMessage";
            this.Text = "操作详情";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtShowMessage;
    }
}