using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleToggleButton
{
    public partial class Form1 : Form
    {
        private readonly object ctsLock = new object();
        CancellationTokenSource cts;
        private bool _buttonDeviceEnable = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBoxDevice_Click(object sender, EventArgs e)
        {
            SetDeviceAlarmToggle(!_buttonDeviceEnable);
        }

        private void ButtonOn_Click(object sender, EventArgs e)
        {
            if (_buttonDeviceEnable)
                return;

            SetDeviceAlarmToggle(true);
        }

        private void ButtonOff_Click(object sender, EventArgs e)
        {
            if (!_buttonDeviceEnable)
                return;

            SetDeviceAlarmToggle(false);
        }


        private async void SetDeviceAlarmToggle(bool enable)
        {
            _buttonDeviceEnable = enable;

            if (enable)
            {
                CancellationToken token;
                lock (ctsLock)
                {
                    if (cts != null)
                    {
                        if (!cts.IsCancellationRequested)
                        {
                            cts.Cancel();
                        }
                        cts.Dispose();
                    }
                    cts = new CancellationTokenSource();
                    token = cts.Token;
                }

                bool result = await MoveComponentToPosition(pictureBoxDeviceOn, 28, 2, 2, token);

                if (result)
                {
                    pictureBoxDeviceOn.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxDeviceOn.Location = new Point(28, 2);
                        pictureBoxDeviceOn.Visible = false;
                        pictureBoxDeviceOn.Visible = true;
                    }));

                    pictureBoxDevice.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxDevice.BackColor = Color.Black;
                    }));
                }
            }
            else
            {
                CancellationToken token;
                lock (ctsLock)
                {
                    if (cts != null)
                    {
                        if (!cts.IsCancellationRequested)
                        {
                            cts.Cancel();
                        }
                        cts.Dispose();
                    }
                    cts = new CancellationTokenSource();
                    token = cts.Token;
                }

                bool result = await MoveComponentToPosition(pictureBoxDeviceOn, 2, 2, 2, token);

                if (result)
                {
                    pictureBoxDeviceOn.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxDeviceOn.Location = new Point(2, 2);
                        pictureBoxDeviceOn.Visible = false;
                        pictureBoxDeviceOn.Visible = true;
                    }));

                    pictureBoxDevice.Invoke((MethodInvoker)(() =>
                    {
                        pictureBoxDevice.BackColor = Color.DimGray;
                    }));
                }
            }
        }

        // 토글 애니메이션
        private async Task<bool> MoveComponentToPosition(Control component, int targetX, int targetY = 2, int speed = 2, CancellationToken cancellationToken = default)
        {
            bool isCompleted = false;

            Point targetPosition = new Point(targetX, targetY);
            bool moveLeft = component.Location.X > targetX;
            //bool moveRight = component.Location.X < targetX;

            while (component.Location != targetPosition)
            {
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    int newX = moveLeft ? Math.Max(targetX, component.Location.X - speed) :
                                         Math.Min(targetX, component.Location.X + speed);

                    component.Invoke((MethodInvoker)(() =>
                    {
                        component.Location = new Point(newX, targetY);
                    }));
                    await Task.Delay(10, cancellationToken);

                    if (component.Location == targetPosition)
                    {
                        isCompleted = true;
                        break;
                    }
                }
                catch (OperationCanceledException)
                {
                    isCompleted = false;
                    break;
                }
            }

            if (isCompleted)
            {
                component.Invoke((MethodInvoker)(() =>
                {
                    component.Visible = false;
                }));
            }

            return isCompleted;
        }

    }
}
