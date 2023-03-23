using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRichTextBox
{
    public partial class RichTextBox : Form
    {
        public RichTextBox()
        {
            InitializeComponent();
        }

        private void RichTextBox_Load(object sender, EventArgs e)
        {
            this.rtbFeedBack.SelectedText = "This is a sample";
            this.rtbFeedBack.SelectionColor = Color.Red;
            this.rtbFeedBack.SelectedText = "RichTextBox control";
            this.rtbFeedBack.WordWrap = false;
        }
    }
}
