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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("08h-09h");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("09h-10h");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("10h-11h");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("11h-12h");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("12h-13h");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("13h-14h");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("14h-15h");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("15h-16h");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("16h-17h");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("17h-18h");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("18h-19h");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("19h-20h");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrouverRDV));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.H = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 38);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 0;
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.H,
            this.Client});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
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
            this.listView1.Location = new System.Drawing.Point(258, 38);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(242, 232);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(390, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(258, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TrouverRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 325);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader H;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}