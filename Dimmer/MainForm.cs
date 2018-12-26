using System.Windows.Forms;
using MonitorDimmer;

namespace Dimmer
{
    public partial class Dimmer : Form
    {
        public Dimmer()
        {
            InitializeComponent();

            BrightnessController brightness = new BrightnessController();
        }

        private void wheel_ValueChanged(object sender, System.EventArgs e)
        {
            BrightnessController.MonitorArray[0].SetBrightness((int)wheel.Value);
            BrightnessController.MonitorArray[1].SetBrightness((int)wheel.Value);
        }
    }
}


