using Appraisal_System.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appraisal_System {
    public delegate void DelBindDGV();
    public partial class FrmUserManager : Form {
        private DelBindDGV? _delBindDGV;
        public FrmUserManager() {
            InitializeComponent();
        }

        private void FrmUserManager_Load(object sender, EventArgs e) {
            BindCBX();
            BindDGV();
            _delBindDGV = BindDGV;
        }

        private void BindDGV() {
            string userName = txtUserName.Text.Trim();
            int baseTypeId = (int)cbxBaseType.SelectedValue;
            bool isStop = chkIsStop.Checked;
            dgvUserAppraisalBase.AutoGenerateColumns = false;
            if (baseTypeId == 0) {
                dgvUserAppraisalBase.DataSource = UserAppraisalBase.GetAll().FindAll(x => x.Name.Contains(userName) && x.IsDel == isStop);
            }
            else {
                dgvUserAppraisalBase.DataSource = UserAppraisalBase.GetAll().FindAll(x => x.Name.Contains(userName) && x.BaseTypeId == baseTypeId && x.IsDel == isStop);
            }
        }

        private void BindCBX() {
            List<AppraisalBases> appraisalBases = AppraisalBases.GetAll();
            appraisalBases.Insert(0, new AppraisalBases {
                Id = 0,
                BaseType = "—查询所有—",
                AppraisalBase = 0,
                IsDel = false
            });
            foreach (var ab in appraisalBases) {
                cbxBaseType.Items.Add(ab.BaseType);
            }
            cbxBaseType.DataSource = appraisalBases;
            cbxBaseType.DisplayMember = "BaseType";
            cbxBaseType.ValueMember = "Id";
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            BindDGV();
        }

        private void dgvUserAppraisalBase_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                tsmNew.Visible = true;
                tsmEdit.Visible = false;
                tsmStart.Visible = false;
                tsmStop.Visible = false;
            }
        }

        private void dgvUserAppraisalBase_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                if (e.RowIndex > -1) {
                    dgvUserAppraisalBase.Rows[e.RowIndex].Selected = true;
                    tsmNew.Visible = true;
                    tsmEdit.Visible = true;
                    bool isStop = (bool)dgvUserAppraisalBase.SelectedRows[0].Cells["IsDel"].Value;
                    if (isStop) {
                        tsmStart.Visible = true;
                    }
                    else {
                        tsmStop.Visible = true;
                    }
                }
            }
        }

        private void tsmNew_Click(object sender, EventArgs e) {
            FrmSetUser frmSetUser = new(_delBindDGV);
            frmSetUser.ShowDialog();
        }

        private void tsmEdit_Click(object sender, EventArgs e) {
            int userId = (int)dgvUserAppraisalBase.SelectedRows[0].Cells["Id"].Value;
            FrmSetUser frmSetUser = new(_delBindDGV, userId);
            frmSetUser.ShowDialog();
        }

        private void tsmStart_Click(object sender, EventArgs e) {
            int userId = (int)dgvUserAppraisalBase.SelectedRows[0].Cells["Id"].Value;
            Users user = Users.GetAll().Find(x => x.Id == userId);
            user.IsDel = false;
            Users.Edit(user);
            MessageBox.Show("用户启用成功！");
            BindDGV();
        }

        private void tsmStop_Click(object sender, EventArgs e) {
            int userId = (int)dgvUserAppraisalBase.SelectedRows[0].Cells["Id"].Value;
            Users user = Users.GetAll().Find(x => x.Id == userId);
            user.IsDel = true;
            Users.Edit(user);
            MessageBox.Show("用户停用成功！");
            BindDGV();
        }
    }
}
