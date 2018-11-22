namespace Esocom
{
    partial class Startmenue
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_start = new System.Windows.Forms.Button();
            this.cB_eso = new System.Windows.Forms.ComboBox();
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_start.FlatAppearance.BorderSize = 0;
            this.bt_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_start.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.ForeColor = System.Drawing.Color.White;
            this.bt_start.Location = new System.Drawing.Point(321, 157);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(194, 106);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "Starte das Projekt!";
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // cB_eso
            // 
            this.cB_eso.BackColor = System.Drawing.SystemColors.MenuText;
            this.cB_eso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_eso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cB_eso.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F);
            this.cB_eso.ForeColor = System.Drawing.Color.White;
            this.cB_eso.FormattingEnabled = true;
            this.cB_eso.Items.AddRange(new object[] {
            "HQ9+",
            "HQ9++",
            "HQ9+-"});
            this.cB_eso.Location = new System.Drawing.Point(79, 170);
            this.cB_eso.Name = "cB_eso";
            this.cB_eso.Size = new System.Drawing.Size(121, 31);
            this.cB_eso.TabIndex = 1;
            // 
            // bt_new
            // 
            this.bt_new.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_new.FlatAppearance.BorderSize = 0;
            this.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F);
            this.bt_new.ForeColor = System.Drawing.Color.White;
            this.bt_new.Location = new System.Drawing.Point(408, 72);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(182, 57);
            this.bt_new.TabIndex = 2;
            this.bt_new.Text = "Neues Projekt";
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_open
            // 
            this.bt_open.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_open.FlatAppearance.BorderSize = 0;
            this.bt_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_open.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_open.ForeColor = System.Drawing.Color.White;
            this.bt_open.Location = new System.Drawing.Point(65, 72);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(182, 57);
            this.bt_open.TabIndex = 3;
            this.bt_open.Text = "Projekt öffnen";
            this.bt_open.UseVisualStyleBackColor = false;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // Startmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.cB_eso);
            this.Controls.Add(this.bt_start);
            this.Name = "Startmenue";
            this.Size = new System.Drawing.Size(684, 382);
            this.SizeChanged += new System.EventHandler(this.Startmenue_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.ComboBox cB_eso;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_open;
    }
}
