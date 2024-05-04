using TwinCAT.Ads;

namespace ADSDemo
{
    public partial class FormMain : Form
    {
        private AdsHelper _adsHelper = new AdsHelper();
        private EventHandler<AdsNotificationExEventArgs> _eventHandler;
        private uint _notificationHandle;

        public FormMain()
        {
            InitializeComponent();
            _eventHandler = new EventHandler<AdsNotificationExEventArgs>(LEDState_NotificationHandler);
        }

        private void LEDState_NotificationHandler(object? sender, AdsNotificationExEventArgs e)
        {
            bool state = (bool)e.Value;
            
            if (state)
            {
                lblLEDState.Text = "On";
                lblLEDState.BackColor = Color.Yellow;
            }
            else
            {
                lblLEDState.Text = "Off";
                lblLEDState.BackColor = SystemColors.Control;
            }

        }

        private void SetUIState()
        {
            bool isConnected = _adsHelper.IsConnected;

            grbOperations.Enabled = isConnected;
            btnConnect.Enabled = !isConnected;
            btnDisconnect.Enabled = isConnected;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _adsHelper.Connect(txtAMSNetID.Text, (int)nudPort.Value);
                _notificationHandle = _adsHelper.SetNotification<bool>("MAIN.bPulse", _eventHandler);

                SetUIState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _adsHelper.UnsetNotification(_notificationHandle, _eventHandler);
            _adsHelper.Disconnect();

            SetUIState();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                nudCounter.Value = _adsHelper.ReadValue<uint>("MAIN.nCounter");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _adsHelper.WriteValue<uint>("MAIN.nCounter", (uint)nudCounter.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkStartStop_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _adsHelper.WriteValue<bool>("MAIN.bStartStop", chkStartStop.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adsHelper.Disconnect();
            _adsHelper.Dispose();
        }
    }
}
