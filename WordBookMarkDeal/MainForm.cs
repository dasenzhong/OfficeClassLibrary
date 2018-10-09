using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeHelper;

namespace WordBookMarkDeal
{
    public partial class MainForm : Form
    {
        #region 全局变量

        /// <summary>
        /// Word操作类
        /// </summary>
        private readonly WordHelper _word = null;

        /// <summary>
        /// 显示操作信息类
        /// </summary>
        private readonly ShowDealMessage _showDialog;

        #endregion

        #region 记录变量

        /// <summary>
        /// Word文件名
        /// </summary>
        private String _fileName = null;

        /// <summary>
        /// Word文件名,包含路径
        /// </summary>
        private String _fileNameWithPath = null;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            _word = new WordHelper();

            _showDialog = ShowDealMessage.Instance;
        }

        #region 加载按钮点击事件

        private void BtLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                //是否可以多选
                Multiselect = false,
                //初始路径
                InitialDirectory = @"D:\",
                //文件不存在时,警告
                CheckFileExists = true,
                //文件路径不存在时,警告
                CheckPathExists = true,
                //设置标题
                Title = "请选择文件",
                //设置筛选
                Filter = "Word文件|*.doc"
            };

            //打开窗口
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = fileDialog.SafeFileName;
                _fileNameWithPath = fileDialog.FileName;
                txtFilePath.Text = fileDialog.FileName;

                #region 开始自动插入书签之前的准备工作
                //一个布尔值, 如果该值为 True 则会打开 Word 文档, 如果该值为 False 则不会启动(打开) Word 文档
                _word.NewCom(true);
                //从模板新建一个 Word 文件
                _word.NewDocWithModel(fileDialog.FileName, true);
                //将当前线程挂起一段时间, 以待 Word 文件完成加载
                System.Threading.Thread.Sleep(2000);
                #endregion

                controlPanel.Enabled = true;
            }
        }

        #endregion

        #region 删除所有书签点击事件

        private void BtDeleteAllBookmark_Click(object sender, EventArgs e)
        {
            btDeleteAllBookmark.Enabled = false;

            //切换当前文档的视图类型为 [页面视图]
            _word.ChangePrintView();
            //删除 Word 文档中所有标记的书签
            DeleteAllBookmark();

            btDeleteAllBookmark.Enabled = true;
        } 

        private void DeleteAllBookmark()
        {
            _showDialog.Show();
            _showDialog.ClearMessage();
            
            foreach (Microsoft.Office.Interop.Word.Bookmark bookmark in _word.oDocument.Bookmarks)
            {
                _showDialog.AppendText(bookmark.Name);
                _showDialog.AppendText("剩余:" + _word.oDocument.Bookmarks.Count);
                bookmark.Delete();
            }
        }

        #endregion
    }
}
