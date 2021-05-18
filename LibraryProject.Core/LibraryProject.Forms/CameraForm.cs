using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using AForge.Video;
using System.Diagnostics;
using AForge.Video.DirectShow;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Globalization;
using System.Net;
using AForge.Controls;
using System.Drawing.Drawing2D;

namespace LibraryProject.Forms
{
    public partial class CameraForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] snapshotCapabilities;
        private ArrayList listCamera = new ArrayList();
        public string pathFolder = Application.StartupPath + "C:\\git\\libraryproject\\LibraryProject.Core\\images";
        //private Stopwatch stopWatch = null;
        public CameraForm()
        {
            InitializeComponent();
            getListCameraUSB();
        }
        public delegate void AddressUpdateHandler(object sender, AddressUpdateEventArgs e);
        public event AddressUpdateHandler AddressUpdated;
        public string usbcamera { get; set; }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                usbcamera = comboBox1.SelectedIndex.ToString();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in videoDevices)
                    {
                        listCamera.Add(device.Name);
                    }
                }
                else
                {
                    MessageBox.Show("No camera devices found");
                }
                videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(usbcamera)].MonikerString);
                snapshotCapabilities = videoDevice.SnapshotCapabilities;
                if (snapshotCapabilities.Length == 0)
                {
                    MessageBox.Show("Camera Capture Not supported");
                }
                OpenVideoSource(videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;
                // stop current video source
                CloseCurrentVideoSource();
                // start new video source
                videoSourcePlayer1.VideoSource = source;
                videoSourcePlayer1.Start();
                // reset stop watch
                //stopWatch = null;
                this.Cursor = Cursors.Default;
            }
            catch { }
        }
        private void getListCameraUSB()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }
            }
            else
            {
                comboBox1.Items.Add("No DirectShow devices found");
            }
            comboBox1.SelectedIndex = 0;
        }
        public void CloseCurrentVideoSource()
        {
            try
            {
                if (videoSourcePlayer1.VideoSource != null)
                {
                    if (videoSourcePlayer1.IsRunning)
                    {
                        videoSourcePlayer1.Stop();
                    }
                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch { }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = videoSourcePlayer1.GetCurrentVideoFrame();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                string name = "BookCover_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
                string path = pathFolder + name;

            if (Directory.Exists(pathFolder))
            {
                pictureBox1.Image.Save(path, ImageFormat.Jpeg);
            }
            else
            {
                Directory.CreateDirectory(pathFolder);
                pictureBox1.Image.Save(path, ImageFormat.Jpeg);
            }
            CloseCurrentVideoSource();
                AddressUpdateEventArgs args = new AddressUpdateEventArgs(path, name);
                AddressUpdated(this, args);
                this.Dispose();
            AdminHomeForm f2 = AdminHomeForm.GetInstance();
            f2.Show();

        }

        private void CameraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCurrentVideoSource();
            this.Dispose();
            AdminHomeForm f2 = AdminHomeForm.GetInstance();
            f2.Show();
        }
    }
}
