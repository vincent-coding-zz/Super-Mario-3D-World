using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Super_Mario_3D_World.Properties;
using System.Diagnostics;
using System.Net;

namespace Super_Mario_3D_World
{
    public partial class Form1 : Form
    {
        private TCPGecko Gecko;

        private bool connected;

        private string versions = "1.0";

        public Form1()
        {
            InitializeComponent();
        }

        private void ipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void disconnectionBtn_Click(object sender, EventArgs e)
        {
            Gecko.Disconnect();
            connectionBtn.Enabled = true;
            disconnectionBtn.Enabled = false;
            mainGroup.Enabled = false;
            MessageBox.Show("Successful disconnection!", "Super Mario 3D World - "+versions);
        }

        private void connectionBtn_Click(object sender, EventArgs e)
        {
            try
            {

                Gecko = new TCPGecko(ipTextBox.Text, 7331);

                connected = Gecko.Connect();

                if (connected)
                {

                    MessageBox.Show("Successfully connection!", "Super Mario 3D World - "+versions);
                    connectionBtn.Enabled = false;
                    disconnectionBtn.Enabled = true;
                    mainGroup.Enabled = true;

                }
            }
            catch (ETCPGeckoException ex)
            {
                connected = false;

                MessageBox.Show(ex.Message);
            }
            catch (System.Net.Sockets.SocketException)
            {
                connected = false;

                MessageBox.Show("You've entered a wrong IP!", "Super Mario 3D World - "+versions);
            }
        }

        private void lifeBtn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D91D0, 0x0000FFFF);
            Gecko.poke32(0x3DB06C54, 0x0000FFFF);
        }

        private void coinsBtn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D91D4, 0x000003E7);
            Gecko.poke32(0x378D91D4, 0x000003E7);
        }

        private void coins2Btn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D91D4, 0x3B9AC9FF);
            Gecko.poke32(0x378D91D4, 0x3B9AC9FF);
        }

        private void PointsBtn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D92DC, 0x000F423F);
        }

        private void timerBtn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D926C, 0x0000FFFF);
        }

        private void star3Btn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D929C, 0x00000007);
        }

        private void star5Btn_Click(object sender, EventArgs e)
        {
            Gecko.poke32(0x378D929C, 0x0000001F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            versionsLabel.Text = "Version : " + versions;
            this.Text = "Super Mario 3D World V" + versions + " - by vincent-coding";
        }
    }
}
