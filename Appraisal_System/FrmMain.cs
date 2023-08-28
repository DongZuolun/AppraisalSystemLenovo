namespace Appraisal_System {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            FrmUserManager frmUserManager = new();
            frmUserManager.MdiParent = this;
            frmUserManager.Parent = spcMain.Panel2;
            frmUserManager.Show();
        }

        private void trvMenu_AfterSelect(object sender, TreeViewEventArgs e) {
            foreach (TreeNode node in trvMenu.Nodes) {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;

        }
    }
}