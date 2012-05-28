namespace Pollux.UserInterface
{
    partial class TrouverRDV
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "08h-09h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "09h-10h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "10h-11h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "11h-12h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "12h-13h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "13h-14h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "14h-15h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "15h-16h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "16h-17h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "17h-18h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "18h-19h",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "19h-20h",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrouverRDV));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.listViewJour = new System.Windows.Forms.ListView();
            this.H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 38);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda de ";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(74, 13);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "NOM";
            // 
            // listViewJour
            // 
            this.listViewJour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.H,
            this.Client});
            this.listViewJour.FullRowSelect = true;
            this.listViewJour.GridLines = true;
            this.listViewJour.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listViewJour.Location = new System.Drawing.Point(258, 38);
            this.listViewJour.MultiSelect = false;
            this.listViewJour.Name = "listViewJour";
            this.listViewJour.Size = new System.Drawing.Size(242, 232);
            this.listViewJour.TabIndex = 2;
            this.listViewJour.UseCompatibleStateImageBehavior = false;
            this.listViewJour.View = System.Windows.Forms.View.Details;
            this.listViewJour.SelectedIndexChanged += new System.EventHandler(this.listViewJour_SelectedIndexChanged);
            // 
            // H
            // 
            this.H.Text = "Heure";
            this.H.Width = 50;
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.Width = 186;
            // 
            // buttonValider
            // 
            this.buttonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonValider.Location = new System.Drawing.Point(390, 285);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(110, 23);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(258, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pollux.Properties.Resources.castor;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(9, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 110);
            this.panel1.TabIndex = 4;
            // 
            // TrouverRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.listViewJour);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrouverRDV";
            this.Text = "Réserver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ListView listViewJour;
        private System.Windows.Forms.ColumnHeader H;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
    }
}