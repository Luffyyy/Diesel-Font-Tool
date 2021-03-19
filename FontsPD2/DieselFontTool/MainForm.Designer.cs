
namespace DieselFontTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFont = new System.Windows.Forms.Button();
            this.LoadFont = new System.Windows.Forms.Button();
            this.largeModeCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SaveFont, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LoadFont, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.largeModeCheckBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 96);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SaveFont
            // 
            this.SaveFont.AutoSize = true;
            this.SaveFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveFont.Location = new System.Drawing.Point(3, 38);
            this.SaveFont.Name = "SaveFont";
            this.SaveFont.Size = new System.Drawing.Size(283, 29);
            this.SaveFont.TabIndex = 6;
            this.SaveFont.Text = "Save (Diesel Font)";
            this.SaveFont.UseVisualStyleBackColor = true;
            this.SaveFont.Click += new System.EventHandler(this.SaveFont_Click);
            // 
            // LoadFont
            // 
            this.LoadFont.AutoSize = true;
            this.LoadFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadFont.Location = new System.Drawing.Point(3, 3);
            this.LoadFont.Name = "LoadFont";
            this.LoadFont.Size = new System.Drawing.Size(283, 29);
            this.LoadFont.TabIndex = 5;
            this.LoadFont.Text = "Load (BM Font)";
            this.LoadFont.UseVisualStyleBackColor = true;
            this.LoadFont.Click += new System.EventHandler(this.LoadFont_Click);
            // 
            // largeModeCheckBox
            // 
            this.largeModeCheckBox.AutoSize = true;
            this.largeModeCheckBox.Location = new System.Drawing.Point(3, 73);
            this.largeModeCheckBox.Name = "largeModeCheckBox";
            this.largeModeCheckBox.Size = new System.Drawing.Size(124, 19);
            this.largeModeCheckBox.TabIndex = 7;
            this.largeModeCheckBox.Text = "Larger (Raid WW2)";
            this.largeModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 96);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(305, 135);
            this.Name = "MainForm";
            this.Text = "Diesel Font Tool V2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveFont;
        private System.Windows.Forms.Button LoadFont;
        private System.Windows.Forms.CheckBox largeModeCheckBox;
    }
}

