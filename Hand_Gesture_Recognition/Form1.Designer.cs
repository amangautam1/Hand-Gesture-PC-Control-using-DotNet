namespace Hand_Gesture_Recognition
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_xy = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbx = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_gesture = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_startCam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 503);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Palm open/Closed -> Media play /pause";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 479);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Palm Right-> Increade brightness/next track";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(470, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Palm Left -> decrease Brightness/previous track";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(470, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Palm Down -> Volume DOWN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Palm UP -> Volume UP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(470, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Gestures ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(470, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 62);
            this.label8.TabIndex = 49;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(467, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Description :";
            // 
            // lbl_xy
            // 
            this.lbl_xy.AutoSize = true;
            this.lbl_xy.Location = new System.Drawing.Point(718, 221);
            this.lbl_xy.Name = "lbl_xy";
            this.lbl_xy.Size = new System.Drawing.Size(10, 13);
            this.lbl_xy.TabIndex = 47;
            this.lbl_xy.Text = " ";
            this.lbl_xy.Visible = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(533, 529);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(115, 13);
            this.lbl_status.TabIndex = 45;
            this.lbl_status.Text = "Camera not connected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(470, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Status :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(467, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Points table";
            // 
            // rtbx
            // 
            this.rtbx.Location = new System.Drawing.Point(467, 63);
            this.rtbx.Name = "rtbx";
            this.rtbx.Size = new System.Drawing.Size(160, 221);
            this.rtbx.TabIndex = 42;
            this.rtbx.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(652, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Recognised Gesture :";
            // 
            // lbl_gesture
            // 
            this.lbl_gesture.AutoSize = true;
            this.lbl_gesture.Location = new System.Drawing.Point(652, 89);
            this.lbl_gesture.Name = "lbl_gesture";
            this.lbl_gesture.Size = new System.Drawing.Size(0, 13);
            this.lbl_gesture.TabIndex = 38;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(34, 11);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(113, 23);
            this.btn_start.TabIndex = 37;
            this.btn_start.Text = "Start Camera";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Processed Frame";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(29, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 221);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Camera frame";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(327, 11);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(95, 23);
            this.btn_stop.TabIndex = 33;
            this.btn_stop.Text = "Pause";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_startCam
            // 
            this.btn_startCam.Location = new System.Drawing.Point(182, 11);
            this.btn_startCam.Name = "btn_startCam";
            this.btn_startCam.Size = new System.Drawing.Size(95, 23);
            this.btn_startCam.TabIndex = 32;
            this.btn_startCam.Text = "Start";
            this.btn_startCam.UseVisualStyleBackColor = true;
            this.btn_startCam.Click += new System.EventHandler(this.btn_startCam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 221);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 569);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_xy);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_gesture);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_startCam);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(856, 608);
            this.MinimumSize = new System.Drawing.Size(856, 608);
            this.Name = "Home";
            this.Text = "Hand Gesture System Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_xy;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_gesture;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_startCam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

