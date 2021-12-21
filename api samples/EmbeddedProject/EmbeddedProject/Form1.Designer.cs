
namespace EmbeddedProject
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
            this.hour = new System.Windows.Forms.Label();
            this.minute = new System.Windows.Forms.Label();
            this.addhour = new System.Windows.Forms.Label();
            this.addmin = new System.Windows.Forms.Label();
            this.subhour = new System.Windows.Forms.Label();
            this.submin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startbefore = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.BackColor = System.Drawing.SystemColors.Control;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hour.Location = new System.Drawing.Point(66, 120);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(78, 55);
            this.hour.TabIndex = 0;
            this.hour.Text = "12";
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minute.Location = new System.Drawing.Point(193, 120);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(78, 55);
            this.minute.TabIndex = 1;
            this.minute.Text = "00";
            // 
            // addhour
            // 
            this.addhour.AutoSize = true;
            this.addhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addhour.Location = new System.Drawing.Point(82, 65);
            this.addhour.Name = "addhour";
            this.addhour.Size = new System.Drawing.Size(43, 46);
            this.addhour.TabIndex = 2;
            this.addhour.Text = "+";
            this.addhour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addhour_MouseDown);
            this.addhour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // addmin
            // 
            this.addmin.AutoSize = true;
            this.addmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.addmin.Location = new System.Drawing.Point(210, 65);
            this.addmin.Name = "addmin";
            this.addmin.Size = new System.Drawing.Size(43, 46);
            this.addmin.TabIndex = 3;
            this.addmin.Text = "+";
            this.addmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addmin_MouseDown);
            this.addmin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // subhour
            // 
            this.subhour.AutoSize = true;
            this.subhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.subhour.Location = new System.Drawing.Point(88, 175);
            this.subhour.Name = "subhour";
            this.subhour.Size = new System.Drawing.Size(33, 46);
            this.subhour.TabIndex = 4;
            this.subhour.Text = "-";
            this.subhour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.subhour_MouseDown);
            this.subhour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // submin
            // 
            this.submin.AutoSize = true;
            this.submin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.submin.Location = new System.Drawing.Point(216, 175);
            this.submin.Name = "submin";
            this.submin.Size = new System.Drawing.Size(33, 46);
            this.submin.TabIndex = 5;
            this.submin.Text = "-";
            this.submin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.submin_MouseDown);
            this.submin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.Location = new System.Drawing.Point(150, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.5F);
            this.label2.Location = new System.Drawing.Point(12, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "minutes before alarm";
            // 
            // startbefore
            // 
            this.startbefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.startbefore.Location = new System.Drawing.Point(119, 271);
            this.startbefore.Name = "startbefore";
            this.startbefore.Size = new System.Drawing.Size(100, 53);
            this.startbefore.TabIndex = 8;
            this.startbefore.Text = "10";
            this.startbefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.sendbutton.Location = new System.Drawing.Point(0, 411);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(342, 59);
            this.sendbutton.TabIndex = 9;
            this.sendbutton.Text = "Set Alarm";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.close.Location = new System.Drawing.Point(0, 468);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(342, 59);
            this.close.TabIndex = 10;
            this.close.Text = "Close Alarm";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 528);
            this.Controls.Add(this.close);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.startbefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submin);
            this.Controls.Add(this.subhour);
            this.Controls.Add(this.addmin);
            this.Controls.Add(this.addhour);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.hour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.Label addhour;
        private System.Windows.Forms.Label addmin;
        private System.Windows.Forms.Label subhour;
        private System.Windows.Forms.Label submin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startbefore;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button close;
    }
}

