namespace tick_tack_toe
{
    partial class Settings
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
            this.checkmaxscore = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textmaxscore = new System.Windows.Forms.TextBox();
            this.butsettingsok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkmaxscore
            // 
            this.checkmaxscore.AutoSize = true;
            this.checkmaxscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkmaxscore.Location = new System.Drawing.Point(460, 85);
            this.checkmaxscore.Name = "checkmaxscore";
            this.checkmaxscore.Size = new System.Drawing.Size(147, 50);
            this.checkmaxscore.TabIndex = 0;
            this.checkmaxscore.Text = "USE?";
            this.checkmaxscore.UseVisualStyleBackColor = true;
            this.checkmaxscore.CheckedChanged += new System.EventHandler(this.checkmaxscore_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum score(1-9)";
            // 
            // textmaxscore
            // 
            this.textmaxscore.BackColor = System.Drawing.Color.Gainsboro;
            this.textmaxscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textmaxscore.Location = new System.Drawing.Point(282, 118);
            this.textmaxscore.Name = "textmaxscore";
            this.textmaxscore.Size = new System.Drawing.Size(100, 45);
            this.textmaxscore.TabIndex = 2;
            this.textmaxscore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textmaxscore_KeyPress);
            // 
            // butsettingsok
            // 
            this.butsettingsok.BackColor = System.Drawing.Color.SkyBlue;
            this.butsettingsok.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butsettingsok.ForeColor = System.Drawing.Color.Black;
            this.butsettingsok.Location = new System.Drawing.Point(460, 300);
            this.butsettingsok.Name = "butsettingsok";
            this.butsettingsok.Size = new System.Drawing.Size(152, 72);
            this.butsettingsok.TabIndex = 3;
            this.butsettingsok.Text = "OK";
            this.butsettingsok.UseVisualStyleBackColor = false;
            this.butsettingsok.Click += new System.EventHandler(this.butsettingsok_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(643, 397);
            this.ControlBox = false;
            this.Controls.Add(this.butsettingsok);
            this.Controls.Add(this.textmaxscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkmaxscore);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkmaxscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textmaxscore;
        private System.Windows.Forms.Button butsettingsok;
    }
}