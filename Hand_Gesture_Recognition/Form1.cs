using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using WindowsInput.Native;
using WindowsInput;
using Emgu.CV.Structure;
using CSCore.CoreAudioAPI;
namespace Hand_Gesture_Recognition
{
    public partial class Home : Form
    {
        VideoCapture capture;
        bool stop = false;
        Deque<Point> d;
        InputSimulator sim;
        public Home()
        {

            d = new Deque<Point>();
            sim = new InputSimulator();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                capture = new VideoCapture(0);
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 1280);
                capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 720);
                stop = false;
                lbl_status.Text = "Camera Started";
                MessageBox.Show("Camera Started");
            }
        }

        private async void btn_startCam_Click(object sender, EventArgs e)
        {

            if (capture == null)
            {
                return;
            }
            try
            {
                stop = false;
                while (!stop)
                {
                    Mat m = new Mat();
                    //Thread.Sleep(1000);
                    capture.Read(m);
                    if (!m.IsEmpty)
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = m.Bitmap;
                        Image<Bgr, Byte> bitmap = new Image<Bgr, Byte>(m.Bitmap);
                        //grayScale
                        // bitmap=BackgroundToGreen(bitmap);

                        Image<Gray, byte> gray = bitmap.Convert<Gray, Byte>();
                        CvInvoke.GaussianBlur(gray, gray, new Size(5, 5), 5);
                        //gray = removeBG(gray);
                        var element = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Cross, new Size(3, 3), new Point(-1, -1));
                        CvInvoke.Erode(gray, gray, element, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar));
                        CvInvoke.Flip(gray, gray, Emgu.CV.CvEnum.FlipType.Horizontal);
                       //CvInvoke.MorphologyEx(gray, gray, Emgu.CV.CvEnum.MorphOp.Open, element, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Reflect, default(MCvScalar)); 
                        CascadeClassifier classfier = new CascadeClassifier("palm.xml");
                        CascadeClassifier classfierfist = new CascadeClassifier("fist.xml");
                        Rectangle[] recfist = classfierfist.DetectMultiScale(gray, 1.1, 5, new Size(125, 125));
                        Rectangle[] rect = classfier.DetectMultiScale(gray, 1.1, 5, new Size(125, 125));

                        //Bitmap newg = gray.Bitmap;
                        // point.Text = rec.ToString();
                        if (recfist.Length != 0)
                        {
                            if (d.Count != 0)
                            {
                                lbl_status.Text = "Gesture Detected";
                                Point p1 = d.PeekBack();
                                Point p2 = d.PeekFront();
                                int x = p1.X - p2.X;
                                int y = p1.Y - p2.Y;
                                lbl_xy.Text = x + "," + y;
                                if ((Math.Abs(x) > Math.Abs(y)) && Math.Abs(x) > 40)
                                {
                                    if (x > 0)
                                    {
                                        if (IsAudioPlaying(GetDefaultRenderDevice()))
                                        {
                                            lbl_gesture.Text = "Gesture right/next Track";
                                            sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);

                                        }
                                        else
                                        {
                                            /* lbl_gesture.Text = "Brightness increased";
                                             ChangeBrightness("+10");
                                             */
                                            lbl_gesture.Text = "Volume UP";
                                            for (int i = 1; i <= 5; i++)
                                            {
                                                sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
                                            }
                                            d.Clear();
                                            rtbx.Text = "";

                                        }

                                    }
                                    if (x <= 0)
                                    {
                                        if (IsAudioPlaying(GetDefaultRenderDevice()))
                                        {
                                            lbl_gesture.Text = "Gesture left/Prev TracG";
                                            sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
                                        }
                                        else
                                        {
                                            lbl_gesture.Text = "Gesture down/VOlume DOWN";
                                            for (int i = 1; i <= 5; i++)
                                            {
                                                sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
                                            }
                                            /* lbl_gesture.Text = "Brightness decreaased";
                                             ChangeBrightness("-10");*/
                                            d.Clear();
                                            rtbx.Text = "";
                                        }

                                    }
                                }
                                else if ((Math.Abs(x) < Math.Abs(y)) && Math.Abs(y) > 40)
                                {
                                    if (y < 0)
                                    {
                                        /* lbl_gesture.Text = "Gesture top/Volume UP";
                                         for (int i = 1; i <= 5; i++)
                                         {
                                             sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
                                         }*/
                                        lbl_gesture.Text = "Brightness increased";
                                        ChangeBrightness("+10");
                                        d.Clear();
                                        rtbx.Text = "";


                                    }
                                    if (y > 0)
                                    {
                                       
                                        lbl_gesture.Text = "Brightness decreaased";
                                        ChangeBrightness("-10");
                                        d.Clear();
                                        rtbx.Text = "";
                                        /* lbl_gesture.Text = "Gesture down/VOlume DOWN";
                                        for (int i = 1; i <= 5; i++)
                                        {
                                            sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
                                        }*/

                                    }
                                }
                                else
                                {
                                    sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                                    lbl_gesture.Text = "Gesture detected/Media pause/play";
                                    d.Clear();
                                    rtbx.Text = "";
                                }
                                /* if (x > 50&&(x>=0)
                                 {
                                     lbl_gesture.Text = "getutre right";
                                     sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);
                                 }
                                 else if (x <0)
                                 {
                                     lbl_gesture.Text = "gestire left";
                                     sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
                                 }
                                 else if (y < 0)
                                 {
                                     lbl_gesture.Text = "gesture top";
                                     sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
                                 }
                                 else if (y > 50)
                                 {
                                     lbl_gesture.Text = "getture down";
                                     sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
                                 }*/

                                d.Clear();
                                rtbx.Text = "";
                            }

                            // Point p = new Point(re.X + (re.Width / 2), re.Y + (re.Height / 2));
                            //point.Text = "x= " + p.X + " y =" + p.Y;
                           // lbl_pts.Text = "stored";
                           // lbl_pts.Text = "";
                            //gray.Draw(recfist, new Gray(0.0), 3);
                        }

                        foreach (Rectangle re in rect)
                        {
                            //  Rectangle r = re;
                            Point p = new Point(re.X + (re.Width / 2), re.Y + (re.Height / 2));
                            //point.Text="x= "+p.X+" y ="+p.Y;
                            rtbx.Text = "x= " + p.X + " y =" + p.Y + "\n" + rtbx.Text;
                            d.PushBack(p);
                            // Graphics g = Graphics.FromImage(bitmap.Bitmap);
                            //  g.DrawImage(bitmap.Bitmap, new Point(0, 0));
                            //CvInvoke.CvtColor(gray, gray,;
                            gray.Draw(re, new Gray(0.0), 3);
                            lbl_status.Text = "Hand detected";
                        }

                        //  Image<Gray,byte> bsbinary= gray.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255));                       
                        // pictureBox2.Image =bsbinary.Bitmap;

                        pictureBox2.Image = gray.Bitmap;
                        // pictureBox2.Image =gray.Bitmap;
                        // double fps = capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                        double fps = 30;
                        await Task.Delay(1000 / Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

            rtbx.Text = "";
            lbl_gesture.Text = "";
            d.Clear();
            lbl_status.Text = "Queue reset";
        }

        public static MMDevice GetDefaultRenderDevice()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                return enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
            }
        }

        public static bool IsAudioPlaying(MMDevice device)
        {
            using (var meter = AudioMeterInformation.FromDevice(device))
            {
                return meter.PeakValue > 0;
            }
        }
        public void ChangeBrightness(string br)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C nircmd.exe changebrightness " + br;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
