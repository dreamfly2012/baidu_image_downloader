using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = "";

        public string keyword = "";

        public int  download_num = 0;

        public string sizechoice = "9";

        public string[] size = { "1", "2", "6", "9" };

        public delegate void updatebar();



        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.keyword = tb_keyword.Text;

          

            this.download_num = Convert.ToInt32(nu_num.Value.ToString());

            if (String.IsNullOrEmpty(this.keyword))
            {
                MessageBox.Show("关键词不能为空");
                return;
            }

            if (this.download_num == 0)
            {
                MessageBox.Show("爬取数量不能为0");
                return;
            }

            if(!Directory.Exists(tb_path.Text))
            {
                MessageBox.Show("保存路径不存在");
                return;
            }

            // todo 文件是否可写
            pb_download.Visible = true;

            Thread thread = new Thread(delegate ()
            {
                this.Downloads(keyword);
            });
           
            thread.Start();







            /* pb_download.Visible = true;
             for (int i = 0; i < 100; i++)
             {
                 pb_download.Value = i;
                 Thread.Sleep(500);
             }*/

            //pb_download.Value = 100;



        }


        private  void Downloads(string keyword)
        {

            int count = (int)Math.Ceiling((double)this.download_num / 60);
            
            for (int j = 0; j < count; j++)
            {
                
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://image.baidu.com/search/avatarjson?tn=resultjsonavatarnew&ie=utf-8&word=" + Uri.EscapeUriString(keyword) + "&cg=girl&pn=" + (j + 1) * 60 + "&rn=60&itg=0&z="+this.sizechoice+"&fr=&width=&height=&lm=-1&ic=0&s=0&st=-1&gsm=360600003c");
                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    if (res.StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream stream = res.GetResponseStream())
                        {
                            try
                            {
                                this.download(stream);
                            }
                            catch (Exception e)
                            {
                                //MessageBox.Show(e.Message);
                            }   
                        }
                    }
                    else
                    {
                        MessageBox.Show("获取第" + j + "页失败！" + res.StatusCode);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //设置文件保存路径
            folderBrowserDialog1.ShowDialog();

            tb_path.Text = folderBrowserDialog1.SelectedPath;

            this.path = tb_path.Text;

            //MessageBox.Show(tb_path.Text);
        }

        private void download(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                JObject objRoot = (JObject)JsonConvert.DeserializeObject(json);
                JArray imgs = (JArray)objRoot["imgs"];
                for (int j = 0; j < imgs.Count; j++)
                {
                    if (common.currentNum > this.download_num)
                    {
                        
                        
                        MessageBox.Show("下载完成");
                        common.currentNum = 0;

                        pb_download.Visible = false;
                        return;
                    }
                    else
                    {
                        JObject img = (JObject)imgs[j];
                        string objUrl = (string)img["objURL"];//http://hibiadu....../1.jpg
                                                              // textShow.AppendText(objUrl + Environment.NewLine);
                                                              //保存的路径是：destDir；
                        try
                        {
                            this.DownloadFile(objUrl);//避免一个方法中的代码过于复杂
                        }
                        catch (Exception e)
                        {
                            //MessageBox.Show(e.Message);
                        }
                    }
                    
                    
                }
            }

        }

        public void UpdateProgress()
        {
            pb_download.Value = (int)((common.currentNum-1) * 100 / this.download_num);
        }

        public void DownloadFile(string URL)
        {
            string path = Path.Combine(this.path, Path.GetFileName(URL));
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(URL);
            req.Referer = "http://image.baidu.com/";//欺骗网站服务器这是从百度图片发出的
            using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
            {
                if (res.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream stream = res.GetResponseStream())
                    using (Stream filestream = new FileStream(path, FileMode.Create))
                    {
                        stream.CopyTo(filestream);
                    }
                    common.currentNum += 1;

                    pb_download.Invoke(new updatebar(this.UpdateProgress));

                    
                }
                else
                {
                    throw new Exception("下载失败" + res.StatusCode);
                }
            }
        }

        private static string getUA()
        {
            string[] userAgents =
            {
                // Opera
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36",
                "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/65.0.3314.0 Safari/537.36 SE 2.X MetaSr 1.0"
            };

            return userAgents[new Random().Next(0, userAgents.Length)];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.sizechoice = "6";
        }

        private void rb_small_CheckedChanged(object sender, EventArgs e)
        {
            this.sizechoice = "1";
        }

        private void rb_middle_CheckedChanged(object sender, EventArgs e)
        {
            this.sizechoice = "2";
        }

        private void rb_supper_CheckedChanged(object sender, EventArgs e)
        {
            this.sizechoice = "9";
        }
    }

    public static class common
    {
        public static int currentNum { get; set; }
    }
}
