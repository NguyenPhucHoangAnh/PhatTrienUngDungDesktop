﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoComboBox
{
    public partial class frmDCB : Form
    {
        public frmDCB()
        {
            InitializeComponent();
        }

        private void DemoComboBox_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Nhật", "Tiếng Pháp" };
            this.cboNgoaiNgu.DataSource = datas;
        }

        private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
        }
    }
}
