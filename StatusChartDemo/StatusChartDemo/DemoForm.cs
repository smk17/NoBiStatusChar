using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatusChartDemo
{
    public partial class DemoForm : Form
    {
        private Random r;

        public DemoForm()
        {
            InitializeComponent();
            r = new Random();
        }

        private void rdoRefreshFast1_CheckedChanged(object sender, EventArgs e)
        {
            nsc1.Interval = 500;
        }

        private void rdoRefreshNormal1_CheckedChanged(object sender, EventArgs e)
        {
            nsc1.Interval = 2000;
        }

        private void rdoRefreshSlow1_CheckedChanged(object sender, EventArgs e)
        {
            nsc1.Interval = 4000;
        }

        private void tmrRandom_Tick(object sender, EventArgs e)
        {
            nsc1.Value = r.Next(100);
            nsc2.Value = r.Next(100);

            nscDemo1.Value = r.Next(10);
            nscDemo2.Value = r.Next(10);
            nscDemo3.Value = r.Next(10);
        }

        private void rdoEditAbove_CheckedChanged(object sender, EventArgs e)
        {
            pgdSC.SelectedObject = nsc1;
        }

        private void rdoEditBelow_CheckedChanged(object sender, EventArgs e)
        {
            pgdSC.SelectedObject = nsc2;
        }

        private void rdoRefreshFast2_CheckedChanged(object sender, EventArgs e)
        {
            nsc2.Interval = 500;
        }

        private void rdoRefreshNormal2_CheckedChanged(object sender, EventArgs e)
        {
            nsc2.Interval = 2000;
        }

        private void rdoRefreshSlow2_CheckedChanged(object sender, EventArgs e)
        {
            nsc2.Interval = 4000;
        }
    }
}