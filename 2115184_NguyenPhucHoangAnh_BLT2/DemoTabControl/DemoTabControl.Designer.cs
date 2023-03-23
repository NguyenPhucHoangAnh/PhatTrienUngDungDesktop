namespace DemoTabControl
{
    partial class DemoTabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSV = new System.Windows.Forms.TabPage();
            this.tabGV = new System.Windows.Forms.TabPage();
            this.tabMH = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSV.SuspendLayout();
            this.tabGV.SuspendLayout();
            this.tabMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSV);
            this.tabControl1.Controls.Add(this.tabGV);
            this.tabControl1.Controls.Add(this.tabMH);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(257, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSV
            // 
            this.tabSV.Controls.Add(this.textBox1);
            this.tabSV.Controls.Add(this.label1);
            this.tabSV.Location = new System.Drawing.Point(4, 22);
            this.tabSV.Name = "tabSV";
            this.tabSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabSV.Size = new System.Drawing.Size(249, 74);
            this.tabSV.TabIndex = 0;
            this.tabSV.Text = "Sinh viên";
            this.tabSV.UseVisualStyleBackColor = true;
            // 
            // tabGV
            // 
            this.tabGV.Controls.Add(this.label2);
            this.tabGV.Controls.Add(this.textBox2);
            this.tabGV.Location = new System.Drawing.Point(4, 22);
            this.tabGV.Name = "tabGV";
            this.tabGV.Padding = new System.Windows.Forms.Padding(3);
            this.tabGV.Size = new System.Drawing.Size(249, 74);
            this.tabGV.TabIndex = 1;
            this.tabGV.Text = "Giáo viên";
            this.tabGV.UseVisualStyleBackColor = true;
            // 
            // tabMH
            // 
            this.tabMH.Controls.Add(this.label3);
            this.tabMH.Controls.Add(this.textBox3);
            this.tabMH.Location = new System.Drawing.Point(4, 22);
            this.tabMH.Name = "tabMH";
            this.tabMH.Size = new System.Drawing.Size(249, 74);
            this.tabMH.TabIndex = 2;
            this.tabMH.Text = "Môn học";
            this.tabMH.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên SV";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên GV";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên môn học";
            // 
            // DemoTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DemoTabControl";
            this.Text = "Demo TabControl";
            this.Load += new System.EventHandler(this.DemoTabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSV.ResumeLayout(false);
            this.tabSV.PerformLayout();
            this.tabGV.ResumeLayout(false);
            this.tabGV.PerformLayout();
            this.tabMH.ResumeLayout(false);
            this.tabMH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

