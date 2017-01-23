namespace Pacemaker
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
            this.data_tb = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.port_name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.transmit_btn = new System.Windows.Forms.Button();
            this.send_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(12, 45);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.data_tb.Size = new System.Drawing.Size(293, 332);
            this.data_tb.TabIndex = 0;
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.send_btn.Location = new System.Drawing.Point(329, 100);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(70, 42);
            this.send_btn.TabIndex = 1;
            this.send_btn.Text = "Connect";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(329, 199);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(70, 48);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save Data";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(329, 148);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(70, 45);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "Disconnect";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // port_name_tb
            // 
            this.port_name_tb.Location = new System.Drawing.Point(329, 23);
            this.port_name_tb.Name = "port_name_tb";
            this.port_name_tb.Size = new System.Drawing.Size(70, 20);
            this.port_name_tb.TabIndex = 4;
            this.port_name_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 10);
            this.progressBar1.TabIndex = 10;
            // 
            // transmit_btn
            // 
            this.transmit_btn.Location = new System.Drawing.Point(329, 332);
            this.transmit_btn.Name = "transmit_btn";
            this.transmit_btn.Size = new System.Drawing.Size(75, 45);
            this.transmit_btn.TabIndex = 11;
            this.transmit_btn.Text = "Send";
            this.transmit_btn.UseVisualStyleBackColor = true;
            this.transmit_btn.Click += new System.EventHandler(this.transmit_btn_Click);
            // 
            // send_txtbox
            // 
            this.send_txtbox.Location = new System.Drawing.Point(329, 306);
            this.send_txtbox.Name = "send_txtbox";
            this.send_txtbox.Size = new System.Drawing.Size(75, 20);
            this.send_txtbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 389);
            this.Controls.Add(this.send_txtbox);
            this.Controls.Add(this.transmit_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.port_name_tb);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.data_tb);
            this.Name = "Form1";
            this.Text = "Pacemaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_tb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.TextBox port_name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button transmit_btn;
        private System.Windows.Forms.TextBox send_txtbox;
    }
}

