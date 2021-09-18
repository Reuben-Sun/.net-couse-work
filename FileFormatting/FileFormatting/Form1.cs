using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFormatting
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.cs|*.cs";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileNameText.Text = file.SafeFileName;
                filePath = file.FileName;
                summaryFile();
            }


        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            summaryFile();
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            formatFile();
            summaryFile();
        }

        void summaryFile()  //统计文件信息
        {
            if (filePath == null)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 32; i <= 126; i++)
            {
                if (i >= 48 && i <= 57)  //数字
                {
                    continue;
                }
                if (i >= 65 && i <= 90)  //大写字母
                {
                    continue;
                }
                if (i >= 97 && i <= 122)
                {
                    continue;
                }
                sb.Append((char)i);
            }
            char[] splitList = sb.ToString().ToCharArray();

            using (FileStream fs = File.OpenRead(filePath))
            {

                StreamReader sr = new StreamReader(fs); //读取行数
                int lines = 0;
                var ls = "";
                int world = 0;
                while ((ls = sr.ReadLine()) != null)
                {
                    lines++;
                    string[] worldList = ls.Split(splitList);
                    foreach (var item in worldList)
                    {
                        if (!String.IsNullOrEmpty(item))
                        {
                            world++;
                        }
                    }

                }
                lineNumText.Text = lines.ToString();
                worldNumText.Text = world.ToString();
            }


        }


        Regex mutiNote = new Regex("/\\*.*?\\*/", RegexOptions.Singleline);
        Regex emptyLine = new Regex("^\\s*$[\\r\\n]*", RegexOptions.Multiline);
        void formatFile()
        {
            if (filePath == null)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();

            using var sr = new StreamReader(filePath);
            var result = sr.ReadToEnd();
            var withoutSingleNote = Regex.Replace(result, "//.*", "");
            var withoutMultiNote = mutiNote.Replace(withoutSingleNote, "");
            var withoutEmptyLine = emptyLine.Replace(withoutMultiNote, "");
            sr.Close();
            using var sw = new StreamWriter(filePath);
            sw.Write(withoutEmptyLine);
            //var ls = "";
            //while ((ls = sr.ReadLine()) != null)
            //{
            //    if (!String.IsNullOrWhiteSpace(ls))  //清除空行
            //    {
            //        int i = ls.IndexOf("//");
            //        if (i == -1)
            //        {
            //            sb.AppendLine(ls);

            //        }
            //        else if (i != 0)
            //        {
            //            sb.AppendLine(ls.Substring(0, i));
            //        }


            //    }
            //}



        }
    }
}
