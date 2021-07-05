using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int LEFTUP = 0x00004;  
        private const int LEFTDOWN = 0x00002;  


        public Form1()
        {
            InitializeComponent();

            KeyboardHook.RegisterHotKey("Alt + S", () => toggleClickerViaHotKey());
        }

        private void toggleClickerViaHotKey()
        {
            if (autoClickToggleBtn.Text.Contains("Off"))
            {
                clicktimer.Start();
                autoClickToggleBtn.Text = "On";
                autoClickToggleBtn.BackColor = Color.Green;
            }
            else
            {
                clicktimer.Stop();
                autoClickToggleBtn.Text = "Off";
                autoClickToggleBtn.BackColor = Color.Red;
            }
        }

        private void clicktimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int maxCps = (int)Math.Round(1000.0 / (trackBar1.Value + trackBar2.Value * 0.2));
            int minCps = (int)Math.Round(1000.0 / (trackBar1.Value + trackBar2.Value * 0.4));
            try
            {
                clicktimer.Interval = rnd.Next(minCps, maxCps);
            } catch
            {
                //ING
            }

            bool mouseDown = MouseButtons == MouseButtons.Left;
            if (true)
            {
                mouse_event(LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(rnd.Next(1,6));
                mouse_event(LEFTDOWN, 0, 0, 0, 0);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            maximumCpsLabel.Text = $"Maximum Cps: {trackBar1.Value}";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            minimumCpsLabel.Text = $"Minimum Cps: {trackBar2.Value}";
        }

        private void autoClickToggleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
