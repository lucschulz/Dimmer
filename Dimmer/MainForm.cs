using System.Windows.Forms;
using MonitorDimmer;

namespace Dimmer
{
    public partial class Dimmer : Form
    {
        BrightnessController brightness;


        public Dimmer()
        {
            InitializeComponent();

            brightness = new BrightnessController();

            BrightnessController.MonitorArray[0].SetBrightness((int)255);
            BrightnessController.MonitorArray[1].SetBrightness((int)255);

            lblMonitorOneValue.Text = ((int)tbarMonitorOne.Value).ToString();
            lblMonitorTwoValue.Text = ((int)tbarMonitorTwo.Value).ToString();

            MinimizeToSystemTray();
        }

        private void TbarMonitorOne_Scroll(object sender, System.EventArgs e)
        {
            BrightnessController.MonitorArray[0].SetBrightness((int)tbarMonitorOne.Value);
            lblMonitorOneValue.Text = ((int)tbarMonitorOne.Value).ToString();
        }

		private void TbarMonitorTwo_Scroll(object sender, System.EventArgs e)
        {
            BrightnessController.MonitorArray[1].SetBrightness((int)tbarMonitorTwo.Value);
            lblMonitorTwoValue.Text = ((int)tbarMonitorTwo.Value).ToString();
        }

		private void BtnReset_Click(object sender, System.EventArgs e)
		{
            ResetDefaultBrightness();
        }

        private void ResetDefaultBrightness()
		{
            BrightnessController.MonitorArray[0].SetBrightness((int)255);
            BrightnessController.MonitorArray[1].SetBrightness((int)255);

            tbarMonitorOne.Value = tbarMonitorOne.Maximum;
            tbarMonitorTwo.Value = tbarMonitorTwo.Maximum;
        }

		private void Dimmer_FormClosing(object sender, FormClosingEventArgs e)
		{
            ResetDefaultBrightness();
		}

		private void BtnDimAll_Click(object sender, System.EventArgs e)
		{
            BrightnessController.MonitorArray[0].SetBrightness((int)0);
            BrightnessController.MonitorArray[1].SetBrightness((int)0);

            tbarMonitorOne.Value = tbarMonitorOne.Minimum;
            tbarMonitorTwo.Value = tbarMonitorTwo.Minimum;
        }

		private void BtnMinOne_Click(object sender, System.EventArgs e)
		{
            BrightnessController.MonitorArray[0].SetBrightness(0);
            tbarMonitorOne.Value = tbarMonitorOne.Minimum;
		}

		private void BtnMaxOne_Click(object sender, System.EventArgs e)
		{
            BrightnessController.MonitorArray[0].SetBrightness((int)255);
            tbarMonitorOne.Value = tbarMonitorOne.Maximum;
        }

		private void BtnMinTwo_Click(object sender, System.EventArgs e)
		{
            BrightnessController.MonitorArray[1].SetBrightness(0);
            tbarMonitorTwo.Value = tbarMonitorTwo.Minimum;
        }

		private void BtnMaxTwo_Click(object sender, System.EventArgs e)
		{
            BrightnessController.MonitorArray[1].SetBrightness((int)255);
            tbarMonitorTwo.Value = tbarMonitorTwo.Maximum;
        }

		private void SysTrayIcon_Click(object sender, System.EventArgs e)
		{
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
			Activate();
		}

		private void Dimmer_Resize(object sender, System.EventArgs e)
		{
            if (WindowState == FormWindowState.Minimized)
            {
                MinimizeToSystemTray();
            }
        }

        private void MinimizeToSystemTray()
		{
            ShowInTaskbar = false;
            sysTrayIcon.Visible = true;
            WindowState = FormWindowState.Minimized;
        }

		private void RightClickExit_Click(object sender, System.EventArgs e)
		{
            Application.Exit();
		}
	}
}