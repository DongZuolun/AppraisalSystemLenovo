using AppraisalSystem.Model;
using Microsoft.VisualBasic.ApplicationServices;

namespace Appraisal_System {
    public partial class FrmSetUser : Form {
        private DelBindDGV? _bindDGV;
        private Users? _user;
        public FrmSetUser(DelBindDGV delBindDGV) {
            InitializeComponent();
            _bindDGV = delBindDGV;
        }
        public FrmSetUser(DelBindDGV delBindDGV, int userId) : this(delBindDGV) {
            _user = Users.GetAll().Find(x => x.Id == userId);
        }

        private void FrmSetUser_Load(object sender, EventArgs e) {
            List<AppraisalBases> appraisalBases = AppraisalBases.GetAll();
            cbxBaseType.DataSource = appraisalBases;
            cbxBaseType.DisplayMember = "BaseType";
            cbxBaseType.ValueMember = "Id";
            if (_user != null) {
                txtUserName.Text = _user.Name;
                cbxBaseType.SelectedValue = _user.BaseTypeId;
                txtSex.Text = _user.Sex;
                chkIsStop.Checked = _user.IsDel;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string name = txtUserName.Text.Trim();
            string sex = txtSex.Text.Trim();
            int basetypeId = (int)cbxBaseType.SelectedValue;
            bool isStop = chkIsStop.Checked;
            if (_user == null) {
                Users user = new() {
                    Name = name,
                    Sex = sex,
                    Password = "111",
                    BaseTypeId = basetypeId,
                    IsDel = isStop
                };
                Users.Insert(user);
                MessageBox.Show("用户添加成功！");
            }
            else {
                _user.Name = txtUserName.Text;
                _user.Password = "111";
                _user.Sex = txtSex.Text;
                _user.BaseTypeId = (int)cbxBaseType.SelectedValue;
                _user.IsDel = chkIsStop.Checked;
                Users.Edit(_user);
                MessageBox.Show("用户修改成功！");
                this.Close();
            }
            _bindDGV();
        }
    }
}
