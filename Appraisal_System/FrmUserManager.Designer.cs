namespace Appraisal_System {
    partial class FrmUserManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            dgvUserAppraisalBase = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            BaseType = new DataGridViewTextBoxColumn();
            AppraisalBase = new DataGridViewTextBoxColumn();
            IsDel = new DataGridViewCheckBoxColumn();
            cmsUserManager = new ContextMenuStrip(components);
            tsmNew = new ToolStripMenuItem();
            tsmEdit = new ToolStripMenuItem();
            tsmStart = new ToolStripMenuItem();
            tsmStop = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            cbxBaseType = new ComboBox();
            btnSearch = new Button();
            chkIsStop = new CheckBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserAppraisalBase).BeginInit();
            cmsUserManager.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUserAppraisalBase
            // 
            dgvUserAppraisalBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserAppraisalBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserAppraisalBase.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvUserAppraisalBase.BorderStyle = BorderStyle.None;
            dgvUserAppraisalBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserAppraisalBase.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Sex, BaseType, AppraisalBase, IsDel });
            dgvUserAppraisalBase.ContextMenuStrip = cmsUserManager;
            dgvUserAppraisalBase.Location = new Point(12, 88);
            dgvUserAppraisalBase.MultiSelect = false;
            dgvUserAppraisalBase.Name = "dgvUserAppraisalBase";
            dgvUserAppraisalBase.RowTemplate.Height = 25;
            dgvUserAppraisalBase.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserAppraisalBase.Size = new Size(753, 351);
            dgvUserAppraisalBase.TabIndex = 0;
            dgvUserAppraisalBase.CellMouseDown += dgvUserAppraisalBase_CellMouseDown;
            dgvUserAppraisalBase.MouseDown += dgvUserAppraisalBase_MouseDown;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "编号";
            Id.Name = "Id";
            // 
            // UserName
            // 
            UserName.DataPropertyName = "Name";
            UserName.HeaderText = "姓名";
            UserName.Name = "UserName";
            // 
            // Sex
            // 
            Sex.DataPropertyName = "Sex";
            Sex.HeaderText = "性别";
            Sex.Name = "Sex";
            // 
            // BaseType
            // 
            BaseType.DataPropertyName = "BaseType";
            BaseType.HeaderText = "身份";
            BaseType.Name = "BaseType";
            // 
            // AppraisalBase
            // 
            AppraisalBase.DataPropertyName = "AppraisalBase";
            AppraisalBase.HeaderText = "基数";
            AppraisalBase.Name = "AppraisalBase";
            // 
            // IsDel
            // 
            IsDel.DataPropertyName = "IsDel";
            IsDel.HeaderText = "是否离职";
            IsDel.Name = "IsDel";
            // 
            // cmsUserManager
            // 
            cmsUserManager.Items.AddRange(new ToolStripItem[] { tsmNew, tsmEdit, tsmStart, tsmStop });
            cmsUserManager.Name = "cmsUserManager";
            cmsUserManager.Size = new Size(101, 92);
            // 
            // tsmNew
            // 
            tsmNew.Name = "tsmNew";
            tsmNew.Size = new Size(100, 22);
            tsmNew.Text = "新建";
            tsmNew.Click += tsmNew_Click;
            // 
            // tsmEdit
            // 
            tsmEdit.Name = "tsmEdit";
            tsmEdit.Size = new Size(100, 22);
            tsmEdit.Text = "编辑";
            tsmEdit.Click += tsmEdit_Click;
            // 
            // tsmStart
            // 
            tsmStart.Name = "tsmStart";
            tsmStart.Size = new Size(100, 22);
            tsmStart.Text = "启用";
            tsmStart.Click += tsmStart_Click;
            // 
            // tsmStop
            // 
            tsmStop.Name = "tsmStop";
            tsmStop.Size = new Size(100, 22);
            tsmStop.Text = "停用";
            tsmStop.Click += tsmStop_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cbxBaseType);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(chkIsStop);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(753, 67);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "用户管理";
            // 
            // cbxBaseType
            // 
            cbxBaseType.FormattingEnabled = true;
            cbxBaseType.Location = new Point(313, 31);
            cbxBaseType.Name = "cbxBaseType";
            cbxBaseType.Size = new Size(185, 25);
            cbxBaseType.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(643, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // chkIsStop
            // 
            chkIsStop.AutoSize = true;
            chkIsStop.Location = new Point(537, 33);
            chkIsStop.Name = "chkIsStop";
            chkIsStop.Size = new Size(75, 21);
            chkIsStop.TabIndex = 6;
            chkIsStop.Text = "是否离职";
            chkIsStop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 35);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "身份";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(77, 32);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(172, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            // 
            // FrmUserManager
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 451);
            Controls.Add(dgvUserAppraisalBase);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserManager";
            Text = "FrmUserManager";
            WindowState = FormWindowState.Maximized;
            Load += FrmUserManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserAppraisalBase).EndInit();
            cmsUserManager.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUserAppraisalBase;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtUserName;
        private Label label1;
        private Button btnSearch;
        private CheckBox chkIsStop;
        private ComboBox cbxBaseType;
        private ContextMenuStrip cmsUserManager;
        private ToolStripMenuItem tsmNew;
        private ToolStripMenuItem tsmEdit;
        private ToolStripMenuItem tsmStart;
        private ToolStripMenuItem tsmStop;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn BaseType;
        private DataGridViewTextBoxColumn AppraisalBase;
        private DataGridViewCheckBoxColumn IsDel;
    }
}