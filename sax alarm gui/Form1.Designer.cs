namespace sax_alarm_gui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hourbox = new System.Windows.Forms.TextBox();
            this.minutebox = new System.Windows.Forms.TextBox();
            this.secondbox = new System.Windows.Forms.TextBox();
            this.daybox = new System.Windows.Forms.TextBox();
            this.monthbox = new System.Windows.Forms.TextBox();
            this.tabbox = new System.Windows.Forms.TextBox();
            this.Alarmset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currenttime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourbox
            // 
            this.hourbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hourbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourbox.Location = new System.Drawing.Point(83, 73);
            this.hourbox.Name = "hourbox";
            this.hourbox.Size = new System.Drawing.Size(100, 23);
            this.hourbox.TabIndex = 0;
            this.hourbox.Text = "hour";
            this.hourbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minutebox
            // 
            this.minutebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minutebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutebox.Location = new System.Drawing.Point(317, 73);
            this.minutebox.Name = "minutebox";
            this.minutebox.Size = new System.Drawing.Size(100, 23);
            this.minutebox.TabIndex = 1;
            this.minutebox.Text = "minute";
            this.minutebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondbox
            // 
            this.secondbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secondbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondbox.Location = new System.Drawing.Point(562, 72);
            this.secondbox.Name = "secondbox";
            this.secondbox.Size = new System.Drawing.Size(100, 23);
            this.secondbox.TabIndex = 2;
            this.secondbox.Text = "second";
            this.secondbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daybox
            // 
            this.daybox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.daybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daybox.Location = new System.Drawing.Point(83, 144);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(100, 23);
            this.daybox.TabIndex = 3;
            this.daybox.Text = "day";
            this.daybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthbox
            // 
            this.monthbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthbox.Location = new System.Drawing.Point(317, 144);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(100, 23);
            this.monthbox.TabIndex = 5;
            this.monthbox.Text = "months";
            this.monthbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabbox
            // 
            this.tabbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabbox.Location = new System.Drawing.Point(562, 144);
            this.tabbox.Name = "tabbox";
            this.tabbox.Size = new System.Drawing.Size(100, 23);
            this.tabbox.TabIndex = 7;
            this.tabbox.Text = "tabs";
            this.tabbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Alarmset
            // 
            this.Alarmset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Alarmset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarmset.Location = new System.Drawing.Point(317, 222);
            this.Alarmset.Name = "Alarmset";
            this.Alarmset.Size = new System.Drawing.Size(100, 23);
            this.Alarmset.TabIndex = 8;
            this.Alarmset.Text = "&Set alarm";
            this.Alarmset.UseVisualStyleBackColor = true;
            this.Alarmset.Click += new System.EventHandler(this.Alarmset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "remember to format it in 24hr time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currenttime
            // 
            this.currenttime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currenttime.AutoSize = true;
            this.currenttime.BackColor = System.Drawing.Color.Transparent;
            this.currenttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenttime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currenttime.Location = new System.Drawing.Point(301, 297);
            this.currenttime.Name = "currenttime";
            this.currenttime.Size = new System.Drawing.Size(175, 29);
            this.currenttime.TabIndex = 10;
            this.currenttime.Tag = "DateTime.Now";
            this.currenttime.Text = "DateTime.Now";
            this.currenttime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currenttime.Click += new System.EventHandler(this.currenttime_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Alarmset;
            this.AccessibleDescription = "gandalf alarm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currenttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alarmset);
            this.Controls.Add(this.tabbox);
            this.Controls.Add(this.monthbox);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.secondbox);
            this.Controls.Add(this.minutebox);
            this.Controls.Add(this.hourbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "gandalf alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hourbox;
        private System.Windows.Forms.TextBox minutebox;
        private System.Windows.Forms.TextBox secondbox;
        private System.Windows.Forms.TextBox daybox;
        private System.Windows.Forms.TextBox monthbox;
        private System.Windows.Forms.TextBox tabbox;
        private System.Windows.Forms.Button Alarmset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currenttime;
    }
}

