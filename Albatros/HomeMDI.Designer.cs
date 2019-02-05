namespace Albatros
{
    partial class HomeMDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.flightSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.openScheduleBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reroutageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AFR = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.config = new System.Windows.Forms.ToolStripMenuItem();
            this.volsSegmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurEtSystèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelNaviguantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aircraftFlightRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControlOldy = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.sizeMod = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Label();
            this.uiMessageBox1 = new Albatros.UIMessageBox();
            this.menuStrip.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightSchedule,
            this.crewSchedule,
            this.AFR,
            this.config,
            this.statistiquesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            this.menuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseUp);
            // 
            // flightSchedule
            // 
            this.flightSchedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openScheduleBtn,
            this.listeToolStripMenuItem,
            this.reroutageToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.flightSchedule.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightSchedule.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.flightSchedule.Name = "flightSchedule";
            this.flightSchedule.Size = new System.Drawing.Size(115, 24);
            this.flightSchedule.Text = "&Flight Schedule";
            // 
            // openScheduleBtn
            // 
            this.openScheduleBtn.Name = "openScheduleBtn";
            this.openScheduleBtn.Size = new System.Drawing.Size(159, 26);
            this.openScheduleBtn.Text = "Ouvrir";
            this.openScheduleBtn.Click += new System.EventHandler(this.openScheduleBtn_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // reroutageToolStripMenuItem
            // 
            this.reroutageToolStripMenuItem.Name = "reroutageToolStripMenuItem";
            this.reroutageToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.reroutageToolStripMenuItem.Text = "Reroutage";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // crewSchedule
            // 
            this.crewSchedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem1,
            this.listeToolStripMenuItem1,
            this.modifierToolStripMenuItem});
            this.crewSchedule.Font = new System.Drawing.Font("Calibri", 9F);
            this.crewSchedule.Name = "crewSchedule";
            this.crewSchedule.Size = new System.Drawing.Size(112, 24);
            this.crewSchedule.Text = "&Crew Schedule";
            // 
            // nouveauToolStripMenuItem1
            // 
            this.nouveauToolStripMenuItem1.Name = "nouveauToolStripMenuItem1";
            this.nouveauToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.nouveauToolStripMenuItem1.Text = "Ouvrir";
            this.nouveauToolStripMenuItem1.Click += new System.EventHandler(this.nouveauToolStripMenuItem1_Click);
            // 
            // listeToolStripMenuItem1
            // 
            this.listeToolStripMenuItem1.Name = "listeToolStripMenuItem1";
            this.listeToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.listeToolStripMenuItem1.Text = "Liste";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // AFR
            // 
            this.AFR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeToolStripMenuItem2,
            this.listeToolStripMenuItem3,
            this.modificationToolStripMenuItem1});
            this.AFR.Font = new System.Drawing.Font("Calibri", 9F);
            this.AFR.Name = "AFR";
            this.AFR.Size = new System.Drawing.Size(107, 24);
            this.AFR.Text = "&Flight Records";
            // 
            // listeToolStripMenuItem2
            // 
            this.listeToolStripMenuItem2.Name = "listeToolStripMenuItem2";
            this.listeToolStripMenuItem2.Size = new System.Drawing.Size(159, 26);
            this.listeToolStripMenuItem2.Text = "Ouvrir";
            this.listeToolStripMenuItem2.Click += new System.EventHandler(this.listeToolStripMenuItem2_Click);
            // 
            // listeToolStripMenuItem3
            // 
            this.listeToolStripMenuItem3.Name = "listeToolStripMenuItem3";
            this.listeToolStripMenuItem3.Size = new System.Drawing.Size(159, 26);
            this.listeToolStripMenuItem3.Text = "Liste";
            // 
            // modificationToolStripMenuItem1
            // 
            this.modificationToolStripMenuItem1.Name = "modificationToolStripMenuItem1";
            this.modificationToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.modificationToolStripMenuItem1.Text = "Modification";
            // 
            // config
            // 
            this.config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volsSegmentsToolStripMenuItem,
            this.utilisateurEtSystèmeToolStripMenuItem,
            this.stationsToolStripMenuItem,
            this.avionsToolStripMenuItem,
            this.personnelNaviguantToolStripMenuItem});
            this.config.Font = new System.Drawing.Font("Calibri", 9F);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(109, 24);
            this.config.Text = "&Configurations";
            // 
            // volsSegmentsToolStripMenuItem
            // 
            this.volsSegmentsToolStripMenuItem.Name = "volsSegmentsToolStripMenuItem";
            this.volsSegmentsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.volsSegmentsToolStripMenuItem.Text = "Vols & segments";
            // 
            // utilisateurEtSystèmeToolStripMenuItem
            // 
            this.utilisateurEtSystèmeToolStripMenuItem.Name = "utilisateurEtSystèmeToolStripMenuItem";
            this.utilisateurEtSystèmeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.utilisateurEtSystèmeToolStripMenuItem.Text = "Utilisateur et Système";
            // 
            // stationsToolStripMenuItem
            // 
            this.stationsToolStripMenuItem.Name = "stationsToolStripMenuItem";
            this.stationsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.stationsToolStripMenuItem.Text = "Stations";
            // 
            // avionsToolStripMenuItem
            // 
            this.avionsToolStripMenuItem.Name = "avionsToolStripMenuItem";
            this.avionsToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.avionsToolStripMenuItem.Text = "Avions";
            // 
            // personnelNaviguantToolStripMenuItem
            // 
            this.personnelNaviguantToolStripMenuItem.Name = "personnelNaviguantToolStripMenuItem";
            this.personnelNaviguantToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.personnelNaviguantToolStripMenuItem.Text = "Personnel Naviguant";
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightScheduleToolStripMenuItem,
            this.crewScheduleToolStripMenuItem,
            this.aircraftFlightRecordsToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F);
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // flightScheduleToolStripMenuItem
            // 
            this.flightScheduleToolStripMenuItem.Name = "flightScheduleToolStripMenuItem";
            this.flightScheduleToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.flightScheduleToolStripMenuItem.Text = "Flight Schedule";
            this.flightScheduleToolStripMenuItem.Click += new System.EventHandler(this.flightScheduleToolStripMenuItem_Click);
            // 
            // crewScheduleToolStripMenuItem
            // 
            this.crewScheduleToolStripMenuItem.Name = "crewScheduleToolStripMenuItem";
            this.crewScheduleToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.crewScheduleToolStripMenuItem.Text = "Crew Schedule";
            // 
            // aircraftFlightRecordsToolStripMenuItem
            // 
            this.aircraftFlightRecordsToolStripMenuItem.Name = "aircraftFlightRecordsToolStripMenuItem";
            this.aircraftFlightRecordsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.aircraftFlightRecordsToolStripMenuItem.Text = "Aircraft Flight Records";
            // 
            // bunifuDragControlOldy
            // 
            this.bunifuDragControlOldy.Fixed = true;
            this.bunifuDragControlOldy.Horizontal = true;
            this.bunifuDragControlOldy.TargetControl = this.controlPanel;
            this.bunifuDragControlOldy.Vertical = true;
            // 
            // sizeMod
            // 
            this.sizeMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeMod.AutoSize = true;
            this.sizeMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(93)))), ((int)(((byte)(16)))));
            this.sizeMod.Location = new System.Drawing.Point(1011, 565);
            this.sizeMod.Name = "sizeMod";
            this.sizeMod.Size = new System.Drawing.Size(23, 17);
            this.sizeMod.TabIndex = 2;
            this.sizeMod.Text = "     ";
            this.sizeMod.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sizeMod_MouseDown);
            this.sizeMod.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sizeMod_MouseMove);
            this.sizeMod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sizeMod_MouseUp);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.White;
            this.controlPanel.Controls.Add(this.settingBtn);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Location = new System.Drawing.Point(555, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(476, 26);
            this.controlPanel.TabIndex = 4;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            this.controlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(428, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quitter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // settingBtn
            // 
            this.settingBtn.AutoSize = true;
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingBtn.Location = new System.Drawing.Point(354, 0);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(74, 17);
            this.settingBtn.TabIndex = 0;
            this.settingBtn.Text = "Paramètres";
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // uiMessageBox1
            // 
            this.uiMessageBox1.BackColor = System.Drawing.Color.Black;
            this.uiMessageBox1.Location = new System.Drawing.Point(279, 206);
            this.uiMessageBox1.Name = "uiMessageBox1";
            this.uiMessageBox1.Size = new System.Drawing.Size(469, 185);
            this.uiMessageBox1.TabIndex = 5;
            this.uiMessageBox1.Load += new System.EventHandler(this.uiMessageBox1_Load);
            // 
            // HomeMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 581);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.uiMessageBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.sizeMod);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1030, 581);
            this.Name = "HomeMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeMDI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeMDI_FormClosing);
            this.Load += new System.EventHandler(this.HomeMDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem flightSchedule;
        private System.Windows.Forms.ToolStripMenuItem crewSchedule;
        private System.Windows.Forms.ToolStripMenuItem AFR;
        private System.Windows.Forms.ToolStripMenuItem config;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlOldy;
        private System.Windows.Forms.ToolStripMenuItem openScheduleBtn;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reroutageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aircraftFlightRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volsSegmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurEtSystèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelNaviguantToolStripMenuItem;
        private System.Windows.Forms.Label sizeMod;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label settingBtn;
        private UIMessageBox uiMessageBox1;
    }
}



