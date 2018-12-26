namespace MacOS_Theme
{
    partial class DarkTheme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxButton = new System.Windows.Forms.PictureBox();
            this.MinButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Location = new System.Drawing.Point(-1, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 431);
            this.panel1.TabIndex = 0;
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxButton.Image = global::MacOS_Theme.Properties.Resources.maximize;
            this.MaxButton.Location = new System.Drawing.Point(752, 9);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(15, 14);
            this.MaxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaxButton.TabIndex = 3;
            this.MaxButton.TabStop = false;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            this.MaxButton.MouseEnter += new System.EventHandler(this.MaxButton_MouseEnter);
            this.MaxButton.MouseLeave += new System.EventHandler(this.MaxButton_MouseLeave);
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinButton.Image = global::MacOS_Theme.Properties.Resources.minnoexit;
            this.MinButton.Location = new System.Drawing.Point(731, 9);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(15, 14);
            this.MinButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinButton.TabIndex = 2;
            this.MinButton.TabStop = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            this.MinButton.MouseEnter += new System.EventHandler(this.MinButton_MouseEnter);
            this.MinButton.MouseLeave += new System.EventHandler(this.MinButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = global::MacOS_Theme.Properties.Resources.redmacnoexit;
            this.ExitButton.Location = new System.Drawing.Point(773, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(15, 14);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // DarkTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DarkTheme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.MaxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox MinButton;
        private System.Windows.Forms.PictureBox MaxButton;
    }
}

