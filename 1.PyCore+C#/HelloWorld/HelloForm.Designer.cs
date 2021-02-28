
namespace HelloWorld
{
    partial class HelloForm
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
            this.backgroundButton = new System.Windows.Forms.Button();
            this.foregroundLabel = new System.Windows.Forms.Label();
            this.foregroundButton = new System.Windows.Forms.Button();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundButton
            // 
            this.backgroundButton.Location = new System.Drawing.Point(12, 12);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(125, 23);
            this.backgroundButton.TabIndex = 2;
            this.backgroundButton.Text = "Run Background";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // foregroundLabel
            // 
            this.foregroundLabel.AutoSize = true;
            this.foregroundLabel.Location = new System.Drawing.Point(143, 38);
            this.foregroundLabel.Name = "foregroundLabel";
            this.foregroundLabel.Size = new System.Drawing.Size(35, 13);
            this.foregroundLabel.TabIndex = 3;
            this.foregroundLabel.Text = "label2";
            // 
            // foregroundButton
            // 
            this.foregroundButton.Location = new System.Drawing.Point(143, 12);
            this.foregroundButton.Name = "foregroundButton";
            this.foregroundButton.Size = new System.Drawing.Size(122, 23);
            this.foregroundButton.TabIndex = 4;
            this.foregroundButton.Text = "Run Foreground";
            this.foregroundButton.UseVisualStyleBackColor = true;
            this.foregroundButton.Click += new System.EventHandler(this.foregroundButton_Click);
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(9, 38);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(35, 13);
            this.backgroundLabel.TabIndex = 5;
            this.backgroundLabel.Text = "label1";
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Controls.Add(this.backgroundLabel);
            this.Controls.Add(this.foregroundButton);
            this.Controls.Add(this.foregroundLabel);
            this.Controls.Add(this.backgroundButton);
            this.Name = "HelloForm";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.Label foregroundLabel;
        private System.Windows.Forms.Button foregroundButton;
        private System.Windows.Forms.Label backgroundLabel;
    }
}

