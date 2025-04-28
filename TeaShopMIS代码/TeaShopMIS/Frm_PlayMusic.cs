using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//new
using System.IO;

namespace TeaShopMIS
{
    public partial class Frm_PlayMusic : Form
    {
        public Frm_PlayMusic()
        {
            InitializeComponent();
        }


        //浏览文件夹
        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            string[] strArr = { ".mp3", ".mp4", ".wma", ".avi", ".rm", ".rmvb", ".flv", ".mpg", ".mov", ".mkv" };


            folderBrowserDialog1.Description = "选择所有文件存放目录";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                string sPath = folderBrowserDialog1.SelectedPath;

                DirectoryInfo dir = new DirectoryInfo(sPath);
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo info in files)
                {
                    string str = info.Extension;//获取扩展名

                    if (((System.Collections.IList)strArr).Contains(str))
                    {
                        string[] musicdata = new string[2];
                        musicdata[0] = info.Name;
                        musicdata[1] = info.FullName;
                        listView1.Items.Add(new ListViewItem(musicdata));
                    }
                }
            }
        }

        int itemid = -1;

        //播放音乐
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                itemid = listView1.SelectedItems[0].Index;
                string path = listView1.SelectedItems[0].SubItems[1].Text;
                axWindowsMediaPlayer1.URL = path;
            }
        }


        //删除选中项
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (itemid == -1)
            {
                MessageBox.Show("请先选择要删除的音视频文件");
            }
            else 
            {
                listView1.Items[itemid].Remove();
                itemid = -1;
            }
        }


        //清空列表
        private void btn_ClearItems_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // 获取你想要播放的歌曲路径
            string path = @"C:\Users\13823\Desktop\林俊杰 _ 孙燕姿 - Stay With You (英文版).mp3"; // 这里填入歌曲文件的实际路径

            // 确保路径有效
            if (File.Exists(path))
            {
                axWindowsMediaPlayer1.URL = path;  // 设置要播放的文件路径
                axWindowsMediaPlayer1.Ctlcontrols.play(); // 播放歌曲
            }
            else
            {
                MessageBox.Show("文件路径无效");
            }
        }
    }
}
