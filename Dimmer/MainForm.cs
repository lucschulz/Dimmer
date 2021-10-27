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

        private void Tbar_Scroll(object sender, System.EventArgs e)
        {
            BrightnessController.MonitorArray[0].SetBrightness((int)tbarMonitorOne.Value);
            BrightnessController.MonitorArray[1].SetBrightness((int)tbarMonitorOne.Value);
        }
    }
}


