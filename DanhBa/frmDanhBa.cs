using DanhBa.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class frmDanhBa : Form
    {
        List<NhomDB> lsNhom;
        List<DanhBaQL> lsDB;
        public frmDanhBa()
        {
            InitializeComponent();
            bdsNhomDB.DataSource = NhomDB.GeNhom();
            dgvNhomDB.DataSource = bdsNhomDB;
            
        }

        private void DgvNhomDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhom = (NhomDB)bdsNhomDB.Current;
            bdsDanhBa.DataSource = DanhBaQL.GeDBtheoMaNhom(nhom.manhomDB);
            dgvDanhBa.DataSource = bdsDanhBa;
        }

        private void DgvDanhBa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var danhba = (DanhBaQL)bdsDanhBa.Current;
            lblTenGoi.Text = danhba.tenDB;
            lblDiaChi.Text = danhba.diachi;
            lblSDT.Text = danhba.sdt;
            lblEmail.Text = danhba.email;
        }

        private void TxtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvDanhBa.Rows.Clear();
            string search = txtTimKiem.Text;
            lsDB = DanhBaQL.GeDB();
            List<DanhBaQL> ls = new List<DanhBaQL>();
            for(int i=0; i<lsDB.Count(); i++)
            {
                if (lsDB[i].tenDB.Trim().ToLower().Contains(search.Trim().ToLower()) 
                    || lsDB[i].sdt.Trim().ToLower().Contains(search.Trim().ToLower()) 
                    || lsDB[i].email.Trim().ToLower().Contains(search.Trim().ToLower()))
                {
                    ls.Add(lsDB[i]);
                }
            }
            bdsDanhBa.DataSource = ls;
            dgvDanhBa.DataSource = bdsDanhBa;
        }

        private void BtnXoaLienLac_Click(object sender, EventArgs e)
        {
            if(bdsDanhBa.Current != null)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa danh bạ này?", "Thông báo!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var nhom = (NhomDB)bdsNhomDB.Current;
                    var danhba = (DanhBaQL)bdsDanhBa.Current;
                    DanhBaQL.RemoveDB(danhba);
                    dgvDanhBa.Rows.Clear();
                    bdsDanhBa.DataSource = DanhBaQL.GeDBtheoMaNhom(nhom.manhomDB);
                    dgvDanhBa.DataSource = bdsDanhBa;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn danh bạ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaNhom_Click(object sender, EventArgs e)
        {
            if (bdsNhomDB.Current != null)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa nhóm danh bạ này?", "Thông báo!", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    var nhom = (NhomDB)bdsNhomDB.Current;
                    lsDB = DanhBaQL.GeDB();
                    for (int i=0; i<lsDB.Count; i++)
                    {
                        if (nhom.manhomDB.Equals(lsDB[i].manhomDB))
                        {
                            DanhBaQL.RemoveDB(lsDB[i]);
                        }
                    }
                    NhomDB.RemoveNhom(nhom);
                    dgvNhomDB.Rows.Clear();
                    bdsNhomDB.DataSource = NhomDB.GeNhom();
                    dgvNhomDB.DataSource = bdsNhomDB;

                    dgvDanhBa.Rows.Clear();
                    bdsDanhBa.DataSource = DanhBaQL.GeDBtheoMaNhom(nhom.manhomDB);
                    dgvDanhBa.DataSource = bdsDanhBa;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhóm danh bạ cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
