namespace ArbeitszeitErfassung
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
            this.lblTimeBegan = new System.Windows.Forms.Label();
            this.lblBegan = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblPassed = new System.Windows.Forms.Label();
            this.lblTimePassed = new System.Windows.Forms.Label();
            this.lblClock1 = new System.Windows.Forms.Label();
            this.lblClock2 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblBreakTotal = new System.Windows.Forms.Label();
            this.lblPauseSum = new System.Windows.Forms.Label();
            this.timerBreaktime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_TimeLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatus_Bullet_Idle = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_Bullet_Active = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_Bullet_Break = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_Bullet_Error = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.notifyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeBegan
            // 
            this.lblTimeBegan.AutoSize = true;
            this.lblTimeBegan.Location = new System.Drawing.Point(87, 23);
            this.lblTimeBegan.Name = "lblTimeBegan";
            this.lblTimeBegan.Size = new System.Drawing.Size(34, 13);
            this.lblTimeBegan.TabIndex = 0;
            this.lblTimeBegan.Text = "09:00";
            // 
            // lblBegan
            // 
            this.lblBegan.AutoSize = true;
            this.lblBegan.Location = new System.Drawing.Point(22, 23);
            this.lblBegan.Name = "lblBegan";
            this.lblBegan.Size = new System.Drawing.Size(59, 13);
            this.lblBegan.TabIndex = 1;
            this.lblBegan.Text = "Begonnen:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(22, 66);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(63, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "Feierabend:";
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.AutoSize = true;
            this.lblTimeEnd.Location = new System.Drawing.Point(87, 66);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(34, 13);
            this.lblTimeEnd.TabIndex = 3;
            this.lblTimeEnd.Text = "17:00";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(182, 23);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Start";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Location = new System.Drawing.Point(22, 45);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(60, 13);
            this.lblPassed.TabIndex = 5;
            this.lblPassed.Text = "Anwesend:";
            // 
            // lblTimePassed
            // 
            this.lblTimePassed.AutoSize = true;
            this.lblTimePassed.Location = new System.Drawing.Point(87, 45);
            this.lblTimePassed.Name = "lblTimePassed";
            this.lblTimePassed.Size = new System.Drawing.Size(34, 13);
            this.lblTimePassed.TabIndex = 6;
            this.lblTimePassed.Text = "04:49";
            // 
            // lblClock1
            // 
            this.lblClock1.AutoSize = true;
            this.lblClock1.Location = new System.Drawing.Point(118, 23);
            this.lblClock1.Name = "lblClock1";
            this.lblClock1.Size = new System.Drawing.Size(24, 13);
            this.lblClock1.TabIndex = 7;
            this.lblClock1.Text = "Uhr";
            // 
            // lblClock2
            // 
            this.lblClock2.AutoSize = true;
            this.lblClock2.Location = new System.Drawing.Point(118, 66);
            this.lblClock2.Name = "lblClock2";
            this.lblClock2.Size = new System.Drawing.Size(24, 13);
            this.lblClock2.TabIndex = 8;
            this.lblClock2.Text = "Uhr";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(119, 45);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(23, 13);
            this.lblHours.TabIndex = 9;
            this.lblHours.Text = "Std";
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(279, 23);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(75, 23);
            this.btnBreak.TabIndex = 10;
            this.btnBreak.Text = "Pause";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(182, 56);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "Ende";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timerTick
            // 
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Std";
            // 
            // lblBreakTotal
            // 
            this.lblBreakTotal.AutoSize = true;
            this.lblBreakTotal.Location = new System.Drawing.Point(86, 103);
            this.lblBreakTotal.Name = "lblBreakTotal";
            this.lblBreakTotal.Size = new System.Drawing.Size(34, 13);
            this.lblBreakTotal.TabIndex = 14;
            this.lblBreakTotal.Text = "00:00";
            // 
            // lblPauseSum
            // 
            this.lblPauseSum.AutoSize = true;
            this.lblPauseSum.Location = new System.Drawing.Point(21, 103);
            this.lblPauseSum.Name = "lblPauseSum";
            this.lblPauseSum.Size = new System.Drawing.Size(63, 13);
            this.lblPauseSum.TabIndex = 13;
            this.lblPauseSum.Text = "Pause Insg:";
            // 
            // timerBreaktime
            // 
            this.timerBreaktime.Interval = 1000;
            this.timerBreaktime.Tick += new System.EventHandler(this.timerBreaktime_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_Bullet_Idle,
            this.toolStripStatus_Bullet_Active,
            this.toolStripStatus_Bullet_Break,
            this.toolStripStatus_Bullet_Error,
            this.toolStripStatusLabel1,
            this.toolStripStatus_TimeLeft});
            this.statusStrip1.Location = new System.Drawing.Point(0, 135);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(383, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel1.Text = "Idle";
            // 
            // toolStripStatus_TimeLeft
            // 
            this.toolStripStatus_TimeLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatus_TimeLeft.Name = "toolStripStatus_TimeLeft";
            this.toolStripStatus_TimeLeft.Size = new System.Drawing.Size(323, 17);
            this.toolStripStatus_TimeLeft.Spring = true;
            this.toolStripStatus_TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Idle";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyContextMenu
            // 
            this.notifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator1,
            this.einstellungenToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.notifyContextMenu.Name = "notifyContextMenu";
            this.notifyContextMenu.Size = new System.Drawing.Size(159, 104);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pauseToolStripMenuItem.Text = "&Pause beginnen";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.einstellungenToolStripMenuItem.Text = "&Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripStatus_Bullet_Idle
            // 
            this.toolStripStatus_Bullet_Idle.BackgroundImage = global::ArbeitszeitErfassung.Properties.Resources.bullet_gray;
            this.toolStripStatus_Bullet_Idle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStatus_Bullet_Idle.Name = "toolStripStatus_Bullet_Idle";
            this.toolStripStatus_Bullet_Idle.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatus_Bullet_Idle.Text = "    ";
            // 
            // toolStripStatus_Bullet_Active
            // 
            this.toolStripStatus_Bullet_Active.BackgroundImage = global::ArbeitszeitErfassung.Properties.Resources.bullet_green;
            this.toolStripStatus_Bullet_Active.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStatus_Bullet_Active.Name = "toolStripStatus_Bullet_Active";
            this.toolStripStatus_Bullet_Active.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatus_Bullet_Active.Text = "    ";
            this.toolStripStatus_Bullet_Active.Visible = false;
            // 
            // toolStripStatus_Bullet_Break
            // 
            this.toolStripStatus_Bullet_Break.BackgroundImage = global::ArbeitszeitErfassung.Properties.Resources.bullet_yellow;
            this.toolStripStatus_Bullet_Break.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStatus_Bullet_Break.Name = "toolStripStatus_Bullet_Break";
            this.toolStripStatus_Bullet_Break.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatus_Bullet_Break.Text = "    ";
            this.toolStripStatus_Bullet_Break.Visible = false;
            // 
            // toolStripStatus_Bullet_Error
            // 
            this.toolStripStatus_Bullet_Error.BackgroundImage = global::ArbeitszeitErfassung.Properties.Resources.bullet_red;
            this.toolStripStatus_Bullet_Error.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStatus_Bullet_Error.Name = "toolStripStatus_Bullet_Error";
            this.toolStripStatus_Bullet_Error.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatus_Bullet_Error.Text = "    ";
            this.toolStripStatus_Bullet_Error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 157);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBreakTotal);
            this.Controls.Add(this.lblPauseSum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblClock2);
            this.Controls.Add(this.lblClock1);
            this.Controls.Add(this.lblTimePassed);
            this.Controls.Add(this.lblPassed);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBegan);
            this.Controls.Add(this.lblTimeBegan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbeitszeit Erfassung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.notifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeBegan;
        private System.Windows.Forms.Label lblBegan;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label lblTimePassed;
        private System.Windows.Forms.Label lblClock1;
        private System.Windows.Forms.Label lblClock2;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBreakTotal;
        private System.Windows.Forms.Label lblPauseSum;
        private System.Windows.Forms.Timer timerBreaktime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_Bullet_Error;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_Bullet_Idle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_Bullet_Active;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_Bullet_Break;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_TimeLeft;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    }
}

