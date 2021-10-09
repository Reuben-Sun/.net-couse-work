using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBrower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //GetTreeView();
        }

        void GetTreeView()
        {
            DirectoryInfo dirPath = new DirectoryInfo(@"C:\");
            TreeNode t = new TreeNode();
            t.Text = dirPath.Name;
            t.Tag = dirPath.FullName;
            treeView1.Nodes.Add(t);
            fileFolderPath.Text = dirPath.FullName;
            //AddTreeNode(t, dirPath);
        }
        void AddTreeNode(TreeNode parent, DirectoryInfo d)
        {
            try
            {    
                DirectoryInfo[] dir = d.GetDirectories();
                if(dir != null)
                {
                    foreach (DirectoryInfo item in dir)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = item.Name;
                        node.Tag = item.FullName;
                        
                        parent.Nodes.Add(node);
                        //AddTreeNode(node, item);
                    }
                }
                parent.Expand();
            }
            catch (Exception)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetTreeView();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            fileFolderPath.Text = e.Node.Tag.ToString();
            if (e.Node.Nodes.Count == 0)
            {
                DirectoryInfo d = new DirectoryInfo(e.Node.Tag.ToString());
                AddTreeNode(e.Node, d);
            }
            listView1.Clear();
            var files = Directory.GetFiles(e.Node.Tag.ToString());
            foreach (var item in files)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item;
                listView1.Items.Add(listViewItem);
            }

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if(e.Node.Nodes.Count == 0) {
            //    DirectoryInfo d = new DirectoryInfo(e.Node.Tag.ToString());
            //    AddTreeNode(e.Node, d);
            //}
            
           
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("made by Reuben", "关于");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能还未上线", "抱歉");
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            if(info.Item != null)
            {
                string ext = Path.GetExtension(info.Item.Text);
                if(ext == ".txt")
                {
                    Process.Start("notepad.exe", info.Item.Text);
                }
                else if(ext == ".exe")
                {
                    Process.Start(info.Item.Text);
                }
                else
                {
                    MessageBox.Show(info.Item.Text);
                }
                
                
            }
        }
    }
}
