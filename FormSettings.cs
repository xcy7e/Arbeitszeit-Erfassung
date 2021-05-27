using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArbeitszeitErfassung
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.RoundTime15Minutes)
            {
                cbRound15.Checked = true;
            }

            txtLogpath.Text = Properties.Settings.Default.LogfilePath;

            numWorktime.Value = Properties.Settings.Default.ArbeitszeitStd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLogpath.Text.Length < 5)
            {
                MessageBox.Show("Ungültiger Pfad für das Zeiterfassungs-Log!");
            } else
            {
                Properties.Settings.Default.RoundTime15Minutes = cbRound15.Checked;
                Properties.Settings.Default.LogfilePath = txtLogpath.Text;
                Properties.Settings.Default.ArbeitszeitStd = (int)numWorktime.Value;
            }
            this.Close();
        }

        private void txtLogpath_Leave(object sender, EventArgs e)
        {
            if (!txtLogpath.Text.EndsWith("\\"))
            {
                txtLogpath.Text += "\\";
            }
        }
    }
}
