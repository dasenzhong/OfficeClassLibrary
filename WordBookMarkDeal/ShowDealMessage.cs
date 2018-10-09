using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordBookMarkDeal
{
    /// <summary>
    /// 显示操作信息
    /// </summary>
    public partial class ShowDealMessage : Form
    {
        //唯一实例,单例模式
        private static ShowDealMessage _instance;

        public static ShowDealMessage Instance => _instance ?? new ShowDealMessage();

        private ShowDealMessage()
        {
            InitializeComponent();


        }

        /// <summary>
        /// 清空文本框的文本
        /// </summary>
        public void  ClearMessage()
        {
            txtShowMessage.Clear();
        }

        public void AppendText(String text)
        {
            txtShowMessage.AppendText(text + Environment.NewLine);
        }
    }
}
