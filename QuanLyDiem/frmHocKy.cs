﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmHocKy : Form
    {
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        void clear()
        {
            txtMaHocKy.Text = "";
            txtTenHocKy.Text = "";
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
        }
    }
}
