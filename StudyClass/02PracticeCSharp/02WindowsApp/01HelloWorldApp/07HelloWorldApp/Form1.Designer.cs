
namespace _07HelloWorldApp
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
            this.HelloButton = new System.Windows.Forms.Button();
            this.hellolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(104, 142);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(100, 23);
            this.HelloButton.TabIndex = 0;
            this.HelloButton.Text = "クリック！！";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButtonClickd);
            // 
            // hellolabel
            // 
            this.hellolabel.Location = new System.Drawing.Point(104, 60);
            this.hellolabel.Name = "hellolabel";
            this.hellolabel.Size = new System.Drawing.Size(100, 23);
            this.hellolabel.TabIndex = 1;
            this.hellolabel.Text = "????";
            this.hellolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 207);
            this.Controls.Add(this.hellolabel);
            this.Controls.Add(this.HelloButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Label hellolabel;
    }
}

