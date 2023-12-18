using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {

        private Leds l;
        public Form1()
        {
            InitializeComponent();
            l = new Leds(129);
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            label1.Text = l.getEstado().ToString();
            label2.Text = Convert.ToString(l.getEstado(), 2);
            btnLed1.Text = (l.getEstado(1) ? "OFF" : "ON");
            pn_led1.BackgroundImage = (l.getEstado(1) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed2.Text = (l.getEstado(2) ? "OFF" : "ON");
            pn_led2.BackgroundImage = (l.getEstado(2) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed3.Text = (l.getEstado(3) ? "OFF" : "ON");
            pn_led3.BackgroundImage = (l.getEstado(3) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed4.Text = (l.getEstado(4) ? "OFF" : "ON");
            pn_led4.BackgroundImage = (l.getEstado(4) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed5.Text = (l.getEstado(5) ? "OFF" : "ON");
            pn_led5.BackgroundImage = (l.getEstado(5) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed6.Text = (l.getEstado(6) ? "OFF" : "ON");
            pn_led6.BackgroundImage = (l.getEstado(6) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed7.Text = (l.getEstado(7) ? "OFF" : "ON");
            pn_led7.BackgroundImage = (l.getEstado(7) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);
            btnLed8.Text = (l.getEstado(8) ? "OFF" : "ON");
            pn_led8.BackgroundImage = (l.getEstado(8) ? Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail : Properties.Resources.png_transparent_led_led_lamps_light_red_thumbnail__1_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qualLed;

            qualLed = int.Parse(((Button)sender).Tag.ToString());

            if (l.getEstado(qualLed))
                l.apagar(qualLed);

            else
                l.acender(qualLed);
            atualizaInterface();
        }

    }
}
