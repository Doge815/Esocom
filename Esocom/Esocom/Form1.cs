using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Todo
//Improve calc.exe call (language, code, (title)) alo
//React to unknown types
//fix new and open alo
//lock mS while running

namespace Esocom
{
    public partial class Form1 : Form
    {
        #region defs
        public static string path = "";
        public static string type = "";

        private List<Button> tolock;
        private List<Color> customcolors = new List<Color> { Color.Red, ColorTranslator.FromHtml("#7f1100"), ColorTranslator.FromHtml("#11d54c"), ColorTranslator.FromHtml("#073f00"), ColorTranslator.FromHtml("#1c1c1c") };
        private Process process = new Process();
        bool end = false;
        bool saved = true;
        bool first = true;
        EventHandler end_defs = new EventHandler(hide_menu);
        #endregion

        public Form1() {
            InitializeComponent();
            bt_stop.BackColor = customcolors[1];
            bt_start.BackColor = customcolors[2];
            tB_sourcecode.BackColor = customcolors[4];
            tolock = new List<Button> { bt_start, bt_stop, bt_save, bt_open};
            mS.Visible = false;
            Startmenue startmenue1 = new Startmenue(true, this);
            startmenue1.Dock = DockStyle.Fill;
            Controls.Add(startmenue1);
            startmenue1.BringToFront();
            startmenue1.VisibleChanged += end_defs;

        }

        #region run
        private void bt_start_click(object sender, EventArgs e) {
            //MessageBox.Show($"{type} {tB_sourcecode.Text} {type}_Compiler");
            process.StartInfo = new ProcessStartInfo("calc.exe", $"{type} {tB_sourcecode.Text} {type}_Compiler");
            process.Start();
            Change(); ;
        }

        private void bt_stop_Click(object sender, EventArgs e) {
            process.Kill();
            Change();
        }

        private void clock_Tick(object sender, EventArgs e) {
            if (process.HasExited) Change();
        }
        #endregion

        #region ms and rep
        private void bt_save_Click(object sender, EventArgs e) => Save(false);

        private void bt_open_Click(object sender, EventArgs e)
        {
            if(Savecall()) goto Cancel;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                string[] filetype = openFileDialog1.FileName.Split('.');
                type = filetype[filetype.Length - 1];
                lb_language.Text = $"Sprache: {type}";
                lb_saved.Text = "gespeichert: nein";
                StreamReader sr = new StreamReader(path);
                tB_sourcecode.Text = sr.ReadToEnd();
                sr.Close();
                saved = true;
            }
            Cancel:;
        }

        private void mS_save_as_Click(object sender, EventArgs e) => Save(true);

        private void mS_new_Click(object sender, EventArgs e)
        {
            if(!(tB_sourcecode.Text == "" || saved))
            {
                DialogResult dialogResult1 = MessageBox.Show("Willst du vor dem Schließen speichern?", "Speichern", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes) Save(false);
            }
            //first = true;
            mS.Visible = false;
            type = "";
            path = "";
            Startmenue startmenue1 = new Startmenue(false, this);
            startmenue1.Dock = DockStyle.Fill;
            Controls.Add(startmenue1);
            startmenue1.BringToFront();
            startmenue1.VisibleChanged += end_defs;
        }


        private void mS_close_Click(object sender, EventArgs e)
        {
            if (end || saved) Application.Exit();
            else
            {
                DialogResult dialogResult1 = MessageBox.Show("Willst du vor dem Schließen speichern?", "Speichern", MessageBoxButtons.YesNoCancel);
                if (dialogResult1 == DialogResult.Yes) Save(false);
                if (dialogResult1 == DialogResult.Cancel) goto Skip;
                end = true;
                Application.Exit();
                Skip:;
            }
        }
        #endregion

        #region close
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (end || saved) Application.Exit();
            else
            {
                DialogResult dialogResult1 = MessageBox.Show("Willst du vor dem Schließen speichern?", "Speichern", MessageBoxButtons.YesNoCancel);
                if (dialogResult1 == DialogResult.Yes) Save(false);
                if (dialogResult1 == DialogResult.Cancel) e.Cancel = true; goto Skip;
                end = true;
                Application.Exit();
                Skip:;
            }
        }

        private static void hide_menu(object sender, EventArgs e)
        {
            Startmenue startmenue = (Startmenue)sender;
            Form1 form1 = startmenue.attachedForm1;
            form1.lb_language.Text = $"Sprache: {type}";
            if (form1.first) form1.first = false;
            else
            {
                form1.mS.Visible = true;
                if (path != "")
                {
                    StreamReader sr = new StreamReader(path);
                    form1.tB_sourcecode.Text = sr.ReadToEnd();
                    sr.Close();
                }
                else form1.tB_sourcecode.Text = "";
                form1.saved = true;
            }
        }
        #endregion

        private void tB_sourcecode_TextChanged(object sender, EventArgs e) { saved = false; lb_saved.Text = "gespeichert: nein"; }

        #region supports
        private bool Savecall()
        {
            if (!(tB_sourcecode.Text == "" || saved)) //Improve
            {
                DialogResult dialogResult1 = MessageBox.Show("Willst du vor dem Schließen speichern?", "Speichern", MessageBoxButtons.YesNoCancel);
                if (dialogResult1 == DialogResult.Yes) Save(false);
                if (dialogResult1 == DialogResult.Cancel) return true;
            }
        }

        private void Save(bool save_as)
        {
            StreamWriter writer;
            if (path != "" && !save_as) writer = new StreamWriter(path, false);

            else
            {
                Dialog:
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "HQ9+ File|*.hq9+";
                saveFileDialog1.Title = "Save an HQ9+ File";
                saveFileDialog1.ShowDialog();
                try { writer = new StreamWriter(saveFileDialog1.FileName, false); }
                catch
                {
                    if (MessageBox.Show("Willst du das Speichern wirklich abbrechen?", "Speichern Abbrechen", MessageBoxButtons.YesNo) == DialogResult.Yes) goto End;
                    else goto Dialog;
                }
                path = saveFileDialog1.FileName;
            }
            writer.Write(tB_sourcecode.Text);
            saved = true;
            lb_saved.Text = "gespeichert: ja";
            writer.Close();
            End:;
        }

        private void Change()
        {
            foreach (Button button in tolock) button.Enabled = !button.Enabled;
            tB_sourcecode.ReadOnly = !tB_sourcecode.ReadOnly;
            clock.Enabled = !clock.Enabled;
            if (bt_start.BackColor == customcolors[2])
            {
                bt_start.BackColor = customcolors[3];
                bt_stop.BackColor = customcolors[0];
            }
            else
            {
                bt_start.BackColor = customcolors[2];
                bt_stop.BackColor = customcolors[1];
            }
        }
        #endregion
    }
}
