using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCheckListBox
{
    public partial class frmDCLB : Form
    {
        public frmDCLB()
        {
            InitializeComponent();
        }

        private void Demo_CheckListBox_Load(object sender, EventArgs e)
        {

        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            for(int i = 0; i < clbMonHoc.Items.Count; i++)
                if(this.clbMonHoc.GetItemChecked(i) == true)
                    s += this.clbMonHoc.Items[i].ToString()+",";
            MessageBox.Show("Danh Sach Mon Hoc:" + s);
        }
    }
}
