namespace FontsPD2
{
    partial class FontsPD2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontsPD2));
            this.Savebtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Openbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Enabled = false;
            this.Savebtn.Location = new System.Drawing.Point(209, 25);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "3. Save!";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Enabled = false;
            this.Loadbtn.Location = new System.Drawing.Point(105, 25);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(98, 23);
            this.Loadbtn.TabIndex = 9;
            this.Loadbtn.Text = "2. Load(.fnt)";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Openbtn
            // 
            this.Openbtn.Location = new System.Drawing.Point(12, 25);
            this.Openbtn.Name = "Openbtn";
            this.Openbtn.Size = new System.Drawing.Size(87, 23);
            this.Openbtn.TabIndex = 0;
            this.Openbtn.Text = "1. Open(.font)";
            this.Openbtn.UseVisualStyleBackColor = true;
            this.Openbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontsPD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 73);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Openbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 112);
            this.MinimumSize = new System.Drawing.Size(314, 112);
            this.Name = "FontsPD2";
            this.Text = "PD2 Font Tool v1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Openbtn;
    }
}

