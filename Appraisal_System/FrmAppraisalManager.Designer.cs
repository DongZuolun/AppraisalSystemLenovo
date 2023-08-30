namespace Appraisal_System {
        partial class FrmAppraisalManager {
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
                        btnAppraisalUpdate = new Button();
                        btnUpdate = new Button();
                        btnSearch = new Button();
                        dgvAppraisalManager = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        AppraisalType = new DataGridViewTextBoxColumn();
                        AppraisalCoefficient = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewCheckBoxColumn();
                        groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)dgvAppraisalManager).BeginInit();
                        SuspendLayout();
                        // 
                        // groupBox1
                        // 
                        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        groupBox1.Controls.Add(btnAppraisalUpdate);
                        groupBox1.Controls.Add(btnUpdate);
                        groupBox1.Controls.Add(btnSearch);
                        groupBox1.Location = new Point(12, 8);
                        groupBox1.Name = "groupBox1";
                        groupBox1.Size = new Size(770, 64);
                        groupBox1.TabIndex = 4;
                        groupBox1.TabStop = false;
                        groupBox1.Text = "绩效管理";
                        // 
                        // btnAppraisalUpdate
                        // 
                        btnAppraisalUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnAppraisalUpdate.Location = new Point(660, 22);
                        btnAppraisalUpdate.Name = "btnAppraisalUpdate";
                        btnAppraisalUpdate.Size = new Size(75, 23);
                        btnAppraisalUpdate.TabIndex = 9;
                        btnAppraisalUpdate.Text = "刷新";
                        btnAppraisalUpdate.UseVisualStyleBackColor = true;
                        // 
                        // btnUpdate
                        // 
                        btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnUpdate.Location = new Point(1252, 22);
                        btnUpdate.Name = "btnUpdate";
                        btnUpdate.Size = new Size(75, 23);
                        btnUpdate.TabIndex = 8;
                        btnUpdate.Text = "刷新";
                        btnUpdate.UseVisualStyleBackColor = true;
                        // 
                        // btnSearch
                        // 
                        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnSearch.Location = new Point(1776, 31);
                        btnSearch.Name = "btnSearch";
                        btnSearch.Size = new Size(75, 23);
                        btnSearch.TabIndex = 7;
                        btnSearch.Text = "查询";
                        btnSearch.UseVisualStyleBackColor = true;
                        // 
                        // dgvAppraisalManager
                        // 
                        dgvAppraisalManager.AllowUserToAddRows = false;
                        dgvAppraisalManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvAppraisalManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvAppraisalManager.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                        dgvAppraisalManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvAppraisalManager.Columns.AddRange(new DataGridViewColumn[] { Id, AppraisalType, AppraisalCoefficient, IsDel });
                        dgvAppraisalManager.Location = new Point(12, 78);
                        dgvAppraisalManager.Name = "dgvAppraisalManager";
                        dgvAppraisalManager.RowTemplate.Height = 25;
                        dgvAppraisalManager.Size = new Size(770, 365);
                        dgvAppraisalManager.TabIndex = 3;
                        // 
                        // Id
                        // 
                        Id.DataPropertyName = "Id";
                        Id.HeaderText = "编号";
                        Id.Name = "Id";
                        // 
                        // AppraisalType
                        // 
                        AppraisalType.DataPropertyName = "AppraisalType";
                        AppraisalType.HeaderText = "名称";
                        AppraisalType.Name = "AppraisalType";
                        // 
                        // AppraisalCoefficient
                        // 
                        AppraisalCoefficient.DataPropertyName = "AppraisalCoefficient";
                        AppraisalCoefficient.HeaderText = "系数";
                        AppraisalCoefficient.Name = "AppraisalCoefficient";
                        // 
                        // IsDel
                        // 
                        IsDel.DataPropertyName = "IsDel";
                        IsDel.HeaderText = "删除";
                        IsDel.Name = "IsDel";
                        IsDel.Resizable = DataGridViewTriState.True;
                        IsDel.SortMode = DataGridViewColumnSortMode.Automatic;
                        // 
                        // FrmAppraisalManager
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(800, 450);
                        Controls.Add(groupBox1);
                        Controls.Add(dgvAppraisalManager);
                        FormBorderStyle = FormBorderStyle.None;
                        Name = "FrmAppraisalManager";
                        Text = "FrmAppraisalManager";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmAppraisalManager_Load;
                        groupBox1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)dgvAppraisalManager).EndInit();
                        ResumeLayout(false);
                }

                #endregion

                private GroupBox groupBox1;
                private Button btnUpdate;
                private Button btnSearch;
                private DataGridView dgvAppraisalManager;
                private Button btnAppraisalUpdate;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn AppraisalType;
                private DataGridViewTextBoxColumn AppraisalCoefficient;
                private DataGridViewCheckBoxColumn IsDel;
        }
}