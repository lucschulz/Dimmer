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
        }

        private void TbarMonitorOne_Scroll(object sender, System.EventArgs e)
        {
            BrightnessController.MonitorArray[0].SetBrightness((int)tbarMonitorOne.Value);
        }

		private void TbarMonitorTwo_Scroll(object sender, System.EventArgs e)
        {
            BrightnessController.MonitorArray[1].SetBrightness((int)tbarMonitorTwo.Value);
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
	}
}