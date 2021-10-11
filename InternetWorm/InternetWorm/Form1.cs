using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetWorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable phoneTable = Hashtable.Synchronized(new Hashtable());
        Hashtable urlTable = Hashtable.Synchronized(new Hashtable());

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchContent.Text))
            {
                MessageBox.Show("搜索内容为空", "警告");
                return;
            }
            listView1.Items.Clear();
            phoneTable.Clear();
            urlTable.Clear();
            var t1 = Task.Factory.StartNew(() => searchTask());
            
        }

        string phoneRegex = @"1[3456789]\d{9}"; //匹配电话号码
        //string webRegex = @"http://www\.baidu\.com(/[\w- ./?%&=]*)?";   //匹配百度的搜索结果的网页
        string webRegex = @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";   //匹配所有网页

        void searchTask()
        {
            Console.WriteLine("开始搜索");
            string searchURL = @"http://www.baidu.com/s?wd=" + searchContent.Text;
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.85 Safari/537.36");
            client.Encoding = Encoding.UTF8;
            string pageHtml = client.DownloadString(searchURL);


            
           
            MatchCollection urlMatch = Regex.Matches(pageHtml, webRegex);
            
  
            foreach (var _url in urlMatch)
            {
                if (phoneTable.Count >= 100)
                {
                    return;
                }
                if (urlTable.Contains(_url.ToString()))
                {
                    continue;
                }
                else
                {
                    urlTable.Add(_url.ToString(), _url.ToString());
                    var t1 = Task.Factory.StartNew(() => getPhoneNumber(_url.ToString()));
                }
                
                
            }
            
        }

        void getPhoneNumber(string url)
        {
           
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.85 Safari/537.36");
                client.Encoding = Encoding.UTF8;
                string pageHtml2 = client.DownloadString(url);
                MatchCollection mc = Regex.Matches(pageHtml2, phoneRegex);

                //获得新的网页
                MatchCollection umc = Regex.Matches(pageHtml2, webRegex);
                foreach (var _url in umc)
                {
                    if(phoneTable.Count >= 100)
                    {
                        return;
                    }
                    if (urlTable.Contains(_url.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        urlTable.Add(_url.ToString(), _url.ToString());
                        var t1 = Task.Factory.StartNew(() => getPhoneNumber(_url.ToString()));
                    }


                }

                this.Invoke((Action)(() =>
                {

                    foreach (var match in mc)
                    {
                        if (phoneTable.Contains(match.ToString()))
                        {
                            continue;
                        }
                        else if (phoneTable.Count >= 100)
                        {
                            return;
                        }
                        else
                        {
                            phoneTable.Add(match.ToString(), match.ToString());

                            Console.WriteLine("找到一个电话号码");
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = phoneTable.Count.ToString();
                            item.SubItems.Add(match.ToString());
                            item.SubItems.Add(url);
                            listView1.Items.Add(item);
                        }
                        
                        
                    }
                }));

            }
            catch (WebException)
            {
            }
        }
    }
}
