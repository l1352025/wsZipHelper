using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ZipHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Compress File
        private void btCprsFileSelct_Click(object sender, EventArgs e)
        {
            openFileDlg.Filter = "所有文件|*.*";
            if(DialogResult.OK == openFileDlg.ShowDialog())
            {
                txtToCprsFile.Text = openFileDlg.FileName;
            }

            combCprsType.SelectedIndex = 0;
        }

        private void btCprs_Click(object sender, EventArgs e)
        {
            if (txtToCprsFile.Text.Trim() == "" || combCprsType.SelectedIndex < 0) return;

            FileInfo fileInfo = new FileInfo(txtToCprsFile.Text.Trim());
            string cprsFileName = fileInfo.FullName.Remove(fileInfo.FullName.IndexOf(fileInfo.Extension));

            cprsFileName += "." + combCprsType.Text;


        }
        #endregion

        #region Decompress File
        private void btDecprsFileSelct_Click(object sender, EventArgs e)
        {
            openFileDlg.Filter = "压缩文件|*.rar;*.zip;*.gz;*.bz;*.tar|所有文件|*.*";
            if (DialogResult.OK == openFileDlg.ShowDialog())
            {
                txtToDecprsFile.Text = openFileDlg.FileName;
            }
        }

        private void btDecprs_Click(object sender, EventArgs e)
        {
            if (txtToDecprsFile.Text.Trim() == "") return;

            FileInfo fileInfo = new FileInfo(txtToCprsFile.Text.Trim());

            if (txtDecprsPath.Text.Trim() == "")
            {
                txtDecprsPath.Text = fileInfo.FullName.Remove(fileInfo.FullName.IndexOf(fileInfo.Extension));
            }
            else if (Directory.Exists(txtDecprsPath.Text) == false)
            {
                try
                {
                    Directory.CreateDirectory(txtDecprsPath.Text);
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return;
                }
            }


        }
        #endregion
    }
}
