namespace SampleToggleButton
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDeviceOn = new System.Windows.Forms.PictureBox();
            this.pictureBoxDevice = new System.Windows.Forms.PictureBox();
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeviceOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDeviceOn
            // 
            this.pictureBoxDeviceOn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxDeviceOn.Location = new System.Drawing.Point(28, 2);
            this.pictureBoxDeviceOn.Name = "pictureBoxDeviceOn";
            this.pictureBoxDeviceOn.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxDeviceOn.TabIndex = 84;
            this.pictureBoxDeviceOn.TabStop = false;
            this.pictureBoxDeviceOn.Click += new System.EventHandler(this.PictureBoxDevice_Click);
            // 
            // pictureBoxDevice
            // 
            this.pictureBoxDevice.BackColor = System.Drawing.Color.Black;
            this.pictureBoxDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDevice.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDevice.Name = "pictureBoxDevice";
            this.pictureBoxDevice.Size = new System.Drawing.Size(56, 24);
            this.pictureBoxDevice.TabIndex = 83;
            this.pictureBoxDevice.TabStop = false;
            this.pictureBoxDevice.Click += new System.EventHandler(this.PictureBoxDevice_Click);
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(92, 21);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(75, 23);
            this.buttonOn.TabIndex = 85;
            this.buttonOn.Text = "On";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.ButtonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(92, 50);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOff.TabIndex = 86;
            this.buttonOff.Text = "Off";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.ButtonOff_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBoxDeviceOn);
            this.panel4.Controls.Add(this.pictureBoxDevice);
            this.panel4.Location = new System.Drawing.Point(19, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(56, 24);
            this.panel4.TabIndex = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(181, 96);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Name = "Form1";
            this.Text = "sample";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeviceOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDevice)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDeviceOn;
        private System.Windows.Forms.PictureBox pictureBoxDevice;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Panel panel4;
    }
}

