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
                        groupBox1 = new GroupBox();
                        btnUserAppraisalSearch = new Button();
                        txtUserName = new TextBox();
                        label1 = new Label();
                        btnUpdate = new Button();
                        btnSearch = new Button();
                        dataGridView1 = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        UserName = new DataGridViewTextBoxColumn();
                        Sex = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewCheckBoxColumn();
                        groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
                        SuspendLayout();
                        // 
                        // groupBox1
                        // 
                        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        groupBox1.Controls.Add(btnUserAppraisalSearch);
                        groupBox1.Controls.Add(txtUserName);
                        groupBox1.Controls.Add(label1);
                        groupBox1.Controls.Add(btnUpdate);
                        groupBox1.Controls.Add(btnSearch);
                        groupBox1.Location = new Point(19, 8);
                        groupBox1.Name = "groupBox1";
                        groupBox1.Size = new Size(763, 64);
                        groupBox1.TabIndex = 4;
                        groupBox1.TabStop = false;
                        groupBox1.Text = "用户绩效";
                        // 
                        // btnUserAppraisalSearch
                        // 
                        btnUserAppraisalSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnUserAppraisalSearch.Location = new Point(646, 20);
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
                        btnUpdate.Location = new Point(1245, 22);
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.Size = new Size(75, 23);
                        btnUpdate.TabIndex = 8;
                        btnUpdate.Text = "刷新";
                        btnUpdate.UseVisualStyleBackColor = true;
                        // 
                        // btnSearch
                        // 
                        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnSearch.Location = new Point(1769, 31);
                        btnSearch.Name = "btnSearch";
                        btnSearch.Size = new Size(75, 23);
                        btnSearch.TabIndex = 7;
                        btnSearch.Text = "查询";
                        btnSearch.UseVisualStyleBackColor = true;
                        // 
                        // dataGridView1
                        // 
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, Sex, BaseType, AppraisalBase, IsDel });
                        dataGridView1.Location = new Point(19, 78);
                        dataGridView1.Name = "dataGridView1";
                        dataGridView1.RowTemplate.Height = 25;
                        dataGridView1.Size = new Size(763, 365);
                        dataGridView1.TabIndex = 3;
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
                        IsDel.HeaderText = "离职";
                        IsDel.Name = "IsDel";
                        // 
                        // FrmUserAppraisal
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(800, 450);
                        Controls.Add(groupBox1);
                        Controls.Add(dataGridView1);
                        Name = "FrmUserAppraisal";
                        Text = "FrmUserAppraisal";
                        WindowState = FormWindowState.Maximized;
                        groupBox1.ResumeLayout(false);
                        groupBox1.PerformLayout();
                        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
                        ResumeLayout(false);
                }

                #endregion

                private GroupBox groupBox1;
                private Button btnUpdate;
                private Button btnSearch;
                private DataGridView dataGridView1;
                private Button btnUserAppraisalSearch;
                private TextBox txtUserName;
                private Label label1;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn UserName;
                private DataGridViewTextBoxColumn Sex;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
                private DataGridViewCheckBoxColumn IsDel;
        }
}