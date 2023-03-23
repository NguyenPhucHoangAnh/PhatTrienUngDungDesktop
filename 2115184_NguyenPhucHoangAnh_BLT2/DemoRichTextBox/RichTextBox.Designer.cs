namespace DemoRichTextBox
{
    partial class RichTextBox
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
            this.rtbFeedBack = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFeedBack
            // 
            this.rtbFeedBack.Location = new System.Drawing.Point(13, 13);
            this.rtbFeedBack.Name = "rtbFeedBack";
            this.rtbFeedBack.Size = new System.Drawing.Size(100, 96);
            this.rtbFeedBack.TabIndex = 0;
            this.rtbFeedBack.Text = "";
            // 
            // RichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFeedBack);
            this.Name = "RichTextBox";
            this.Text = "Demo Rich Text Box";
            this.Load += new System.EventHandler(this.RichTextBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFeedBack;
    }
}

