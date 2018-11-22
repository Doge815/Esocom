using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esocom
{
    public partial class Startmenue : UserControl
    {
        public Form1 attachedForm1;

        public Startmenue(bool show_open, Form1 parent)
        {
            InitializeComponent();
            cB_eso.Text = "HQ9+";
            attachedForm1 = parent;
            if (show_open) { bt_start.Visible = false; cB_eso.Visible = false; }
            else { bt_new.Visible = false; bt_open.Visible = false; }
            bt_open.Top = Convert.ToInt32(Height * 0.5 - bt_open.Height / 2);
            bt_open.Left = Convert.ToInt32(Width * 0.25 - bt_open.Width / 2);
            bt_new.Top = Convert.ToInt32(Height * 0.5 - bt_new.Height / 2);
            bt_new.Left = Convert.ToInt32(Width * 0.75 - bt_new.Width / 2);
            cB_eso.Top = Convert.ToInt32(Height * 0.5 - cB_eso.Height / 2);
            cB_eso.Left = Convert.ToInt32(Width * 0.25 - cB_eso.Width / 2);
            bt_start.Top = Convert.ToInt32(Height * 0.5 - bt_start.Height / 2);
            bt_start.Left = Convert.ToInt32(Width * 0.75 - bt_start.Width / 2);
        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            bt_start.Visible = true; cB_eso.Visible = true; bt_open.Visible = false; bt_new.Visible = false;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            Esocom.Form1.type = cB_eso.Text;
            this.Visible = false;
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Esocom.Form1.path = openFileDialog1.FileName;
                string[] filetype = openFileDialog1.FileName.Split('.');
                Esocom.Form1.type = filetype[filetype.Length - 1];
                this.Visible = false;
            }
        }

        private void Startmenue_SizeChanged(object sender, EventArgs e)
        {
            bt_open.Top = Convert.ToInt32(Height * 0.5 - bt_open.Height / 2);
            bt_open.Left = Convert.ToInt32(Width * 0.25 - bt_open.Width / 2);
            bt_new.Top = Convert.ToInt32(Height * 0.5 - bt_new.Height / 2);
            bt_new.Left = Convert.ToInt32(Width * 0.75 - bt_new.Width / 2);
            cB_eso.Top = Convert.ToInt32(Height * 0.5 - cB_eso.Height / 2);
            cB_eso.Left = Convert.ToInt32(Width * 0.25 - cB_eso.Width / 2);
            bt_start.Top = Convert.ToInt32(Height * 0.5 - bt_start.Height / 2);
            bt_start.Left = Convert.ToInt32(Width * 0.75 - bt_start.Width / 2);
        }
    }
}
