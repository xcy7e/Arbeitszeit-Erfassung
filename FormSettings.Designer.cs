namespace ArbeitszeitErfassung
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtLogpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numWorktime = new System.Windows.Forms.NumericUpDown();
            this.cbRound15 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWorktime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(232, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogpath
            // 
            this.txtLogpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogpath.Location = new System.Drawing.Point(22, 67);
            this.txtLogpath.Name = "txtLogpath";
            this.txtLogpath.Size = new System.Drawing.Size(285, 20);
            this.txtLogpath.TabIndex = 2;
            this.txtLogpath.Leave += new System.EventHandler(this.txtLogpath_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pfad für Zeiterfassungs-Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arbeitszeit (h)";
            // 
            // numWorktime
            // 
            this.numWorktime.Location = new System.Drawing.Point(22, 113);
            this.numWorktime.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numWorktime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWorktime.Name = "numWorktime";
            this.numWorktime.Size = new System.Drawing.Size(40, 20);
            this.numWorktime.TabIndex = 5;
            this.numWorktime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbRound15
            // 
            this.cbRound15.AutoSize = true;
            this.cbRound15.Location = new System.Drawing.Point(22, 22);
            this.cbRound15.Name = "cbRound15";
            this.cbRound15.Size = new System.Drawing.Size(200, 17);
            this.cbRound15.TabIndex = 6;
            this.cbRound15.Text = "15-Minuten Rundung (Experimentell!)";
            this.cbRound15.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 166);
            this.Controls.Add(this.cbRound15);
            this.Controls.Add(this.numWorktime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogpath);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWorktime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLogpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numWorktime;
        private System.Windows.Forms.CheckBox cbRound15;
    }
}