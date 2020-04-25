﻿using ARCSoftFaceApp.Controller;
using ARCSoftFaceApp.Entity;
using ARCSoftFaceApp.EntityFrameDataModel;
using ARCSoftFaceApp.Util;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibHKCamera.HKNetWork;
using ARCSoftFaceApp.CameraManage;
using ARCSoftFaceApp.Util.ARCFace;

namespace ARCSoftFaceApp
{
    public partial class MainWindow : Form
    {
        public const int RealPlayWndWidth= 642;
        public const int RealPlayWndHeigh = 360;
        private int nowWindowxWidth;
        private int nowWindowyHeigh;
        private long iSelectedIndex;

        private List<PictureBox> realPlayList;
        private CameraControler cameraControler;

        private bool m_bInitHKSDK;//标记华康SDK是否初始化成功

        public MainWindow()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            cameraControler = new CameraControler();
            iSelectedIndex = 0;
        }

        /// <summary>
        /// 根据屏幕分辨率分配预览控件
        /// 将预览显示控件注册到流布局控件中
        /// </summary>
        private void groupRealPlayWnd()
        {

            nowWindowxWidth = this.flowLayoutPanelVideoReal.Width;
            nowWindowyHeigh = this.flowLayoutPanelVideoReal.Height;

            int playRow = nowWindowyHeigh / RealPlayWndHeigh;
            int playColum = nowWindowxWidth / RealPlayWndWidth;
            int playWndCount = playRow * playColum;

            realPlayList = new List<PictureBox>();

            for (int i = 0; i < playWndCount; i++)
            {
                PictureBox tmpPictureBox = new PictureBox();
                tmpPictureBox.Name = $"PictureBoxRealPlayWnd{i}";
                tmpPictureBox.Width = RealPlayWndWidth;
                tmpPictureBox.Height = RealPlayWndHeigh;
                tmpPictureBox.BackColor = Color.Black;
                tmpPictureBox.Image=(Properties.Resources.NoSIgnalpng);
                tmpPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                realPlayList.Add(tmpPictureBox);
                this.flowLayoutPanelVideoReal.Controls.Add(tmpPictureBox);
            }
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            groupRealPlayWnd();

            LoggerService.IniterLogService();

            //初始化海康SDK
            m_bInitHKSDK = HKNetSDKS.NET_DVR_Init();

            if (m_bInitHKSDK == false)
            {
                MessageBox.Show("海康SDK::NET_DVR_Init 初始化错误！");
                return;
            }
            else
            {
                HKNetSDKS.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }

            ARCFaceEngineUtils.InitARCFaceEngine();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// 登录摄像机
        /// 先弹出一个用于输入连接摄像机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 登录IP摄像机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            CameraManage.CameraManageForm cameraManageForm = new CameraManage.CameraManageForm(camera, realPlayList);
            
            if(DialogResult.OK== cameraManageForm.ShowDialog())
            {
                //设置成功
                cameraControler.RegistrerCameraDevice(camera, listViewVideoChannel);
            }
        }

        private void 数据库测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db=new attendance_sysEntities())
            {
                var query = from user in db.t_user orderby user.user_id select user;

                foreach (var item in query)
                {
                    MessageBox.Show($"id:{item.user_id}, name:{item.username}, pwd:{item.password}");
                }
            }
        }

        private void 日志输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggerService.logger.Info("点击测试成功！");
        }

        private void listViewVideoChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewVideoChannel.SelectedItems.Count>0)
            {
                iSelectedIndex = listViewVideoChannel.SelectedItems[0].Index;
            }
        }

        private void listViewVideoChannel_MouseClick(object sender, MouseEventArgs e)
        {
            //点击的方式为右键的话，弹出设备的选中的面板
            if(e.Button==MouseButtons.Right)
            {
                if(iSelectedIndex>=0)
                {
                    CameraManageForm cameraManageForm = new CameraManageForm(cameraControler.cameras[(int)iSelectedIndex].camera, realPlayList);

                    cameraManageForm.Show();
                }
            }
        }
    }
}
