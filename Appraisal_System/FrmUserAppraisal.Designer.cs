namespace Appraisal_System {
        partial class FrmUserAppraisal {
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
                        gbAppraisal = new GroupBox();
                        btnUserAppraisalSearch = new Button();
                        txtUserName = new TextBox();
                        label1 = new Label();
                        btnUpdate = new Button();
                        btnSearch = new Button();
                        dgvUserAppraisal = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        UserName = new DataGridViewTextBoxColumn();
                        Sex = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        gbAppraisal.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).BeginInit();
                        SuspendLayout();
                        // 
                        // gbAppraisal
                        // 
                        gbAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        gbAppraisal.Controls.Add(btnUserAppraisalSearch);
                        gbAppraisal.Controls.Add(txtUserName);
                        gbAppraisal.Controls.Add(label1);
                        gbAppraisal.Controls.Add(btnUpdate);
                        gbAppraisal.Controls.Add(btnSearch);
                        gbAppraisal.Location = new Point(12, 12);
                        gbAppraisal.Name = "gbAppraisal";
                        gbAppraisal.Size = new Size(776, 60);
                        gbAppraisal.TabIndex = 4;
                        gbAppraisal.TabStop = false;
                        gbAppraisal.Text = "用户绩效";
                        // 
                        // btnUserAppraisalSearch
                        // 
                        btnUserAppraisalSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnUserAppraisalSearch.Location = new Point(659, 20);
                        btnUserAppraisalSearch.Name = "btnUserAppraisalSearch";
                        btnUserAppraisalSearch.Size = new Size(75, 23);
                        btnUserAppraisalSearch.TabIndex = 13;
                        btnUserAppraisalSearch.Text = "查询";
                        btnUserAppraisalSearch.UseVisualStyleBackColor = true;
                        // 
                        // txtUserName
                        // 
                        txtUserName.Location = new Point(80, 21);
                        txtUserName.Name = "txtUserName";
                        txtUserName.Size = new Size(172, 23);
                        txtUserName.TabIndex = 10;
                        // 
                        // label1
                        // 
                        label1.AutoSize = true;
                        label1.Location = new Point(42, 24);
                        label1.Name = "label1";
                        label1.Size = new Size(32, 17);
                        label1.TabIndex = 9;
                        label1.Text = "姓名";
                        // 
                        // btnUpdate
                        // 
                        btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnUpdate.Location = new Point(1258, 22);
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.Size = new Size(75, 23);
                        btnUpdate.TabIndex = 8;
                        btnUpdate.Text = "刷新";
                        btnUpdate.UseVisualStyleBackColor = true;
                        // 
                        // btnSearch
                        // 
                        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnSearch.Location = new Point(1782, 31);
                        btnSearch.Name = "btnSearch";
                        btnSearch.Size = new Size(75, 23);
                        btnSearch.TabIndex = 7;
                        btnSearch.Text = "查询";
                        btnSearch.UseVisualStyleBackColor = true;
                        // 
                        // dgvUserAppraisal
                        // 
                        dgvUserAppraisal.AllowUserToAddRows = false;
                        dgvUserAppraisal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvUserAppraisal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvUserAppraisal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                        dgvUserAppraisal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvUserAppraisal.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Sex, BaseType, AppraisalBase });
                        dgvUserAppraisal.Location = new Point(12, 78);
                        dgvUserAppraisal.Name = "dgvUserAppraisal";
                        dgvUserAppraisal.RowTemplate.Height = 25;
                        dgvUserAppraisal.Size = new Size(776, 360);
                        dgvUserAppraisal.TabIndex = 3;
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
                        // FrmUserAppraisal
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(800, 450);
                        Controls.Add(gbAppraisal);
                        Controls.Add(dgvUserAppraisal);
                        FormBorderStyle = FormBorderStyle.None;
                        Name = "FrmUserAppraisal";
                        Text = "FrmUserAppraisal";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmUserAppraisal_Load;
                        gbAppraisal.ResumeLayout(false);
                        gbAppraisal.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvUserAppraisal).EndInit();
                        ResumeLayout(false);
                }

                #endregion

                private GroupBox gbAppraisal;
                private Button btnUpdate;
                private Button btnSearch;
                private DataGridView dgvUserAppraisal;
                private Button btnUserAppraisalSearch;
                private TextBox txtUserName;
                private Label label1;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn UserName;
                private DataGridViewTextBoxColumn Sex;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
        }
}