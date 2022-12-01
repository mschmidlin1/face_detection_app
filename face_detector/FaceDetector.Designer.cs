namespace face_detector
{
    partial class FaceDetector
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
            this.liveViewPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.liveViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // liveViewPictureBox
            // 
            this.liveViewPictureBox.Location = new System.Drawing.Point(12, 12);
            this.liveViewPictureBox.Name = "liveViewPictureBox";
            this.liveViewPictureBox.Size = new System.Drawing.Size(871, 647);
            this.liveViewPictureBox.TabIndex = 0;
            this.liveViewPictureBox.TabStop = false;
            this.liveViewPictureBox.Click += new System.EventHandler(this.liveViewPictureBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(889, 79);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(121, 24);
            this.devicesComboBox.TabIndex = 2;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // FaceDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 671);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liveViewPictureBox);
            this.Name = "FaceDetector";
            this.Text = "Face Detector";
            this.Load += new System.EventHandler(this.FaceDetector_load);
            ((System.ComponentModel.ISupportInitialize)(this.liveViewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox liveViewPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox devicesComboBox;
    }
}

