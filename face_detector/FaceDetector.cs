using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using DirectShowLib;

namespace face_detector
{
    public partial class FaceDetector : Form
    {
        bool _streaming;
        Capture _capture;
        public FaceDetector()
        {
            InitializeComponent();
        }

        
        
        private void FaceDetector_load(object sender, EventArgs e)
        {
            _streaming = false;
            _capture = new Capture();
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            //List<String> deviceNames = new List<string>();
            foreach (var device in _SystemCamereas)
            {
                devicesComboBox.Items.Add(device.Name);
            }
            //Video_Device[] WebCams = new Video_Device[_SystemCamereas.Length];
        }
        private void streaming(object sender, System.EventArgs e)
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            liveViewPictureBox.Image = bmp;

        }

        private void liveViewPictureBox_Click(object sender, EventArgs e)
        {
            if (!_streaming)
            {
                Application.Idle += streaming;
            }
            else
            {
                Application.Idle -= streaming;
                liveViewPictureBox.Image = null;
            }
            _streaming = !_streaming;
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
