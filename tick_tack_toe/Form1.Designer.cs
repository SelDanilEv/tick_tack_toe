namespace tick_tack_toe
{
    partial class Menu1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_start = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.butsettings = new System.Windows.Forms.Button();
            this.howToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_start
            // 
            this.but_start.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_start.Font = new System.Drawing.Font("Kristen ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_start.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.but_start.Location = new System.Drawing.Point(136, 28);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(189, 70);
            this.but_start.TabIndex = 0;
            this.but_start.Text = "START";
            this.but_start.UseVisualStyleBackColor = false;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_exit.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_exit.ForeColor = System.Drawing.Color.Crimson;
            this.but_exit.Location = new System.Drawing.Point(136, 203);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(189, 70);
            this.but_exit.TabIndex = 1;
            this.but_exit.Text = "EXIT";
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // butsettings
            // 
            this.butsettings.BackColor = System.Drawing.Color.LightSkyBlue;
            this.butsettings.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsettings.ForeColor = System.Drawing.Color.Indigo;
            this.butsettings.Location = new System.Drawing.Point(136, 115);
            this.butsettings.Name = "butsettings";
            this.butsettings.Size = new System.Drawing.Size(189, 70);
            this.butsettings.TabIndex = 2;
            this.butsettings.Text = "SETTINGS";
            this.butsettings.UseVisualStyleBackColor = false;
            this.butsettings.Click += new System.EventHandler(this.butsettings_Click);
            // 
            // howToPlay
            // 
            this.howToPlay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.howToPlay.Font = new System.Drawing.Font("Kristen ITC", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlay.ForeColor = System.Drawing.SystemColors.MenuText;
            this.howToPlay.Location = new System.Drawing.Point(354, 34);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(116, 64);
            this.howToPlay.TabIndex = 3;
            this.howToPlay.Text = "HOW TO PLAY?";
            this.howToPlay.UseVisualStyleBackColor = false;
            this.howToPlay.Click += new System.EventHandler(this.howToPlay_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.ControlBox = false;
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.butsettings);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_start);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Menu1";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Button butsettings;
        private System.Windows.Forms.Button howToPlay;
    }
}

