namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.redButton2 = new System.Windows.Forms.Button();
            this.greenButton2 = new System.Windows.Forms.Button();
            this.blueButton2 = new System.Windows.Forms.Button();
            this.yellowButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.Location = new System.Drawing.Point(40, 149);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(110, 110);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton.Location = new System.Drawing.Point(152, 149);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(110, 110);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.DarkRed;
            this.redButton.Location = new System.Drawing.Point(152, 37);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(110, 110);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton.Location = new System.Drawing.Point(40, 37);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(110, 110);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // redButton2
            // 
            this.redButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.redButton2.Location = new System.Drawing.Point(152, 37);
            this.redButton2.Name = "redButton2";
            this.redButton2.Size = new System.Drawing.Size(110, 110);
            this.redButton2.TabIndex = 4;
            this.redButton2.UseVisualStyleBackColor = false;
            this.redButton2.Click += new System.EventHandler(this.redButton2_Click);
            // 
            // greenButton2
            // 
            this.greenButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.greenButton2.Location = new System.Drawing.Point(40, 37);
            this.greenButton2.Name = "greenButton2";
            this.greenButton2.Size = new System.Drawing.Size(110, 110);
            this.greenButton2.TabIndex = 5;
            this.greenButton2.UseVisualStyleBackColor = false;
            this.greenButton2.Click += new System.EventHandler(this.greenButton2_Click);
            // 
            // blueButton2
            // 
            this.blueButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blueButton2.Location = new System.Drawing.Point(152, 149);
            this.blueButton2.Name = "blueButton2";
            this.blueButton2.Size = new System.Drawing.Size(110, 110);
            this.blueButton2.TabIndex = 6;
            this.blueButton2.UseVisualStyleBackColor = false;
            this.blueButton2.Click += new System.EventHandler(this.blueButton2_Click);
            // 
            // yellowButton2
            // 
            this.yellowButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yellowButton2.Location = new System.Drawing.Point(40, 149);
            this.yellowButton2.Name = "yellowButton2";
            this.yellowButton2.Size = new System.Drawing.Size(110, 110);
            this.yellowButton2.TabIndex = 7;
            this.yellowButton2.UseVisualStyleBackColor = false;
            this.yellowButton2.Click += new System.EventHandler(this.yellowButton2_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.greenButton2);
            this.Controls.Add(this.redButton2);
            this.Controls.Add(this.blueButton2);
            this.Controls.Add(this.yellowButton2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button redButton2;
        private System.Windows.Forms.Button greenButton2;
        private System.Windows.Forms.Button blueButton2;
        private System.Windows.Forms.Button yellowButton2;
    }
}
