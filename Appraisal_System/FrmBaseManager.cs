using Appraisal_System.Model;
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
        public partial class FrmBaseManager : Form {
                public FrmBaseManager() {
                        InitializeComponent();
                }

                private void FrmBaseManager_Load(object sender, EventArgs e) {
                        dgvBaseManager.AutoGenerateColumns = false;
                        dgvBaseManager.DataSource = AppraisalBases.GetAll();
                }
        }
}
