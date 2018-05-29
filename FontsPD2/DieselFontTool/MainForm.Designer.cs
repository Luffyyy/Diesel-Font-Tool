namespace DieselFontTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoadFont = new System.Windows.Forms.Button();
            this.SaveFont = new System.Windows.Forms.Button();
            this.largeModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoadFont
            // 
            this.LoadFont.Location = new System.Drawing.Point(12, 12);
            this.LoadFont.Name = "LoadFont";
            this.LoadFont.Size = new System.Drawing.Size(260, 23);
            this.LoadFont.TabIndex = 0;
            this.LoadFont.Text = "Load(BM Font)";
            this.LoadFont.UseVisualStyleBackColor = true;
            this.LoadFont.Click += new System.EventHandler(this.LoadFont_Click);
            // 
            // SaveFont
            // 
            this.SaveFont.Enabled = false;
            this.SaveFont.Location = new System.Drawing.Point(12, 41);
            this.SaveFont.Name = "SaveFont";
            this.SaveFont.Size = new System.Drawing.Size(260, 23);
            this.SaveFont.TabIndex = 1;
            this.SaveFont.Text = "Save(Diesel Font)";
            this.SaveFont.UseVisualStyleBackColor = true;
            this.SaveFont.Click += new System.EventHandler(this.SaveFont_Click);
            // 
            // largeModeCheckBox
            // 
            this.largeModeCheckBox.AccessibleDescription = "";
            this.largeModeCheckBox.AutoSize = true;
            this.largeModeCheckBox.Location = new System.Drawing.Point(12, 70);
            this.largeModeCheckBox.Name = "largeModeCheckBox";
            this.largeModeCheckBox.Size = new System.Drawing.Size(115, 17);
            this.largeModeCheckBox.TabIndex = 2;
            this.largeModeCheckBox.Text = "Larger(Raid WW2)";
            this.largeModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 96);
            this.Controls.Add(this.largeModeCheckBox);
            this.Controls.Add(this.SaveFont);
            this.Controls.Add(this.LoadFont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(305, 135);
            this.MinimumSize = new System.Drawing.Size(305, 135);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diesel Font Tool V2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFont;
        private System.Windows.Forms.Button SaveFont;
        private System.Windows.Forms.CheckBox largeModeCheckBox;
    }
}

