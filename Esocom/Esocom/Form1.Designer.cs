namespace Esocom
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tB_sourcecode = new System.Windows.Forms.RichTextBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.mS = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mS_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mS_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mS_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.mS_close = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_language = new System.Windows.Forms.Label();
            this.lb_saved = new System.Windows.Forms.Label();
            this.mS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_sourcecode
            // 
            this.tB_sourcecode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_sourcecode.BackColor = System.Drawing.SystemColors.MenuText;
            this.tB_sourcecode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_sourcecode.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_sourcecode.ForeColor = System.Drawing.Color.White;
            this.tB_sourcecode.Location = new System.Drawing.Point(12, 129);
            this.tB_sourcecode.Name = "tB_sourcecode";
            this.tB_sourcecode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tB_sourcecode.Size = new System.Drawing.Size(500, 328);
            this.tB_sourcecode.TabIndex = 4;
            this.tB_sourcecode.Text = "";
            this.tB_sourcecode.TextChanged += new System.EventHandler(this.tB_sourcecode_TextChanged);
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // bt_open
            // 
            this.bt_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_open.BackColor = System.Drawing.Color.Transparent;
            this.bt_open.BackgroundImage = global::Esocom.Properties.Resources.Open;
            this.bt_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_open.FlatAppearance.BorderSize = 0;
            this.bt_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_open.Location = new System.Drawing.Point(437, 35);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(75, 76);
            this.bt_open.TabIndex = 8;
            this.bt_open.UseVisualStyleBackColor = false;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.BackColor = System.Drawing.Color.Transparent;
            this.bt_save.BackgroundImage = global::Esocom.Properties.Resources.Save;
            this.bt_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_save.FlatAppearance.BorderSize = 0;
            this.bt_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_save.Location = new System.Drawing.Point(356, 35);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 76);
            this.bt_save.TabIndex = 7;
            this.bt_save.UseVisualStyleBackColor = false;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.BackColor = System.Drawing.Color.Black;
            this.bt_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_stop.BackgroundImage")));
            this.bt_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_stop.Enabled = false;
            this.bt_stop.FlatAppearance.BorderSize = 0;
            this.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_stop.Location = new System.Drawing.Point(105, 35);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 76);
            this.bt_stop.TabIndex = 6;
            this.bt_stop.UseVisualStyleBackColor = false;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_start.BackgroundImage")));
            this.bt_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_start.FlatAppearance.BorderSize = 0;
            this.bt_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_start.Location = new System.Drawing.Point(12, 35);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 76);
            this.bt_start.TabIndex = 5;
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_click);
            // 
            // mS
            // 
            this.mS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.mS.Location = new System.Drawing.Point(0, 0);
            this.mS.Name = "mS";
            this.mS.Size = new System.Drawing.Size(524, 24);
            this.mS.TabIndex = 9;
            this.mS.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mS_new,
            this.mS_open,
            this.mS_save,
            this.mS_save_as,
            this.mS_close});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // mS_new
            // 
            this.mS_new.Name = "mS_new";
            this.mS_new.Size = new System.Drawing.Size(157, 22);
            this.mS_new.Text = "Neu";
            this.mS_new.Click += new System.EventHandler(this.mS_new_Click);
            // 
            // mS_open
            // 
            this.mS_open.Name = "mS_open";
            this.mS_open.Size = new System.Drawing.Size(157, 22);
            this.mS_open.Text = "Öffnen";
            this.mS_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // mS_save
            // 
            this.mS_save.Name = "mS_save";
            this.mS_save.Size = new System.Drawing.Size(157, 22);
            this.mS_save.Text = "Speichern";
            this.mS_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // mS_save_as
            // 
            this.mS_save_as.Name = "mS_save_as";
            this.mS_save_as.Size = new System.Drawing.Size(157, 22);
            this.mS_save_as.Text = "Speichern unter";
            this.mS_save_as.Click += new System.EventHandler(this.mS_save_as_Click);
            // 
            // mS_close
            // 
            this.mS_close.Name = "mS_close";
            this.mS_close.Size = new System.Drawing.Size(157, 22);
            this.mS_close.Text = "Beenden";
            this.mS_close.Click += new System.EventHandler(this.mS_close_Click);
            // 
            // lb_language
            // 
            this.lb_language.AutoSize = true;
            this.lb_language.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_language.Location = new System.Drawing.Point(186, 45);
            this.lb_language.Name = "lb_language";
            this.lb_language.Size = new System.Drawing.Size(71, 17);
            this.lb_language.TabIndex = 10;
            this.lb_language.Text = "sprache";
            // 
            // lb_saved
            // 
            this.lb_saved.AutoSize = true;
            this.lb_saved.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saved.Location = new System.Drawing.Point(186, 73);
            this.lb_saved.Name = "lb_saved";
            this.lb_saved.Size = new System.Drawing.Size(161, 17);
            this.lb_saved.TabIndex = 11;
            this.lb_saved.Text = "gespeichert: nein";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(524, 469);
            this.Controls.Add(this.lb_saved);
            this.Controls.Add(this.lb_language);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.tB_sourcecode);
            this.Controls.Add(this.mS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 400);
            this.Name = "Form1";
            this.Text = "Esocom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mS.ResumeLayout(false);
            this.mS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox tB_sourcecode;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.MenuStrip mS;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mS_open;
        private System.Windows.Forms.ToolStripMenuItem mS_save;
        private System.Windows.Forms.ToolStripMenuItem mS_save_as;
        private System.Windows.Forms.ToolStripMenuItem mS_new;
        private System.Windows.Forms.ToolStripMenuItem mS_close;
        private System.Windows.Forms.Label lb_language;
        private System.Windows.Forms.Label lb_saved;
    }
}

