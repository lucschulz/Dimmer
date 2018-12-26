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
            BrightnessController.MonitorArray[0].SetBrightness(125);
        }
    }
}


