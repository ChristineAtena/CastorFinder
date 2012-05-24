namespace Pollux.UserInterface
{
    partial class AgendaAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaAgent));
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonValider = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewJour = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.textBoxNumBien = new System.Windows.Forms.TextBox();
            this.textBoxNomProprio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(267, 2);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(88, 23);
            this.buttonAfficher.TabIndex = 10;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.Width = 186;
            // 
            // buttonValider
            // 
            this.buttonValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonValider.Location = new System.Drawing.Point(328, 274);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(110, 23);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "OK";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(7, 32);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 5;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // H
            // 
            this.H.Text = "Heure";
            this.H.Width = 50;
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
            this.listViewJour.Location = new System.Drawing.Point(256, 32);
            this.listViewJour.MultiSelect = false;
            this.listViewJour.Name = "listViewJour";
            this.listViewJour.Size = new System.Drawing.Size(242, 232);
            this.listViewJour.TabIndex = 8;
            this.listViewJour.UseCompatibleStateImageBehavior = false;
            this.listViewJour.View = System.Windows.Forms.View.Details;
            this.listViewJour.SelectedIndexChanged += new System.EventHandler(this.listViewJour_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Agenda de";
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(81, 4);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(180, 21);
            this.comboBoxAgents.TabIndex = 11;
            // 
            // textBoxNumBien
            // 
            this.textBoxNumBien.Enabled = false;
            this.textBoxNumBien.Location = new System.Drawing.Point(81, 213);
            this.textBoxNumBien.Name = "textBoxNumBien";
            this.textBoxNumBien.Size = new System.Drawing.Size(153, 20);
            this.textBoxNumBien.TabIndex = 12;
            // 
            // textBoxNomProprio
            // 
            this.textBoxNomProprio.Enabled = false;
            this.textBoxNomProprio.Location = new System.Drawing.Point(81, 244);
            this.textBoxNomProprio.Name = "textBoxNomProprio";
            this.textBoxNomProprio.Size = new System.Drawing.Size(153, 20);
            this.textBoxNomProprio.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bien n° :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Propriétaire :";
            // 
            // AgendaAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 309);
            this.Controls.Add(this.textBoxNomProprio);
            this.Controls.Add(this.textBoxNumBien);
            this.Controls.Add(this.comboBoxAgents);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.listViewJour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgendaAgent";
            this.Text = "Agenda d\'un agent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ColumnHeader H;
        private System.Windows.Forms.ListView listViewJour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.TextBox textBoxNumBien;
        private System.Windows.Forms.TextBox textBoxNomProprio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}