namespace Steak
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SteakTitleLabel = new System.Windows.Forms.Label();
            this.SpaceBarLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.scoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scoreNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.RestartLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SteakTitleLabel
            // 
            this.SteakTitleLabel.AutoSize = true;
            this.SteakTitleLabel.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteakTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SteakTitleLabel.Location = new System.Drawing.Point(59, 33);
            this.SteakTitleLabel.Name = "SteakTitleLabel";
            this.SteakTitleLabel.Size = new System.Drawing.Size(164, 55);
            this.SteakTitleLabel.TabIndex = 0;
            this.SteakTitleLabel.Text = "Steak";
            // 
            // SpaceBarLabel
            // 
            this.SpaceBarLabel.AutoSize = true;
            this.SpaceBarLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceBarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SpaceBarLabel.Location = new System.Drawing.Point(28, 238);
            this.SpaceBarLabel.Name = "SpaceBarLabel";
            this.SpaceBarLabel.Size = new System.Drawing.Size(232, 21);
            this.SpaceBarLabel.TabIndex = 1;
            this.SpaceBarLabel.Text = "Press the space bar to begin";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreLabel,
            this.scoreNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(286, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(39, 17);
            this.scoreLabel.Text = "Score:";
            // 
            // scoreNumber
            // 
            this.scoreNumber.BackColor = System.Drawing.SystemColors.Control;
            this.scoreNumber.Name = "scoreNumber";
            this.scoreNumber.Size = new System.Drawing.Size(13, 17);
            this.scoreNumber.Text = "0";
            this.scoreNumber.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // RestartLabel
            // 
            this.RestartLabel.AutoSize = true;
            this.RestartLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RestartLabel.Location = new System.Drawing.Point(28, 238);
            this.RestartLabel.Name = "RestartLabel";
            this.RestartLabel.Size = new System.Drawing.Size(240, 21);
            this.RestartLabel.TabIndex = 4;
            this.RestartLabel.Text = "Press the space bar to restart";
            this.RestartLabel.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(286, 317);
            this.Controls.Add(this.RestartLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SpaceBarLabel);
            this.Controls.Add(this.SteakTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steak";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SteakTitleLabel;
        private System.Windows.Forms.Label SpaceBarLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel scoreLabel;
        private System.Windows.Forms.ToolStripStatusLabel scoreNumber;
        private System.Windows.Forms.Label RestartLabel;
    }
}

