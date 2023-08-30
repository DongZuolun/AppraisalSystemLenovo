namespace Appraisal_System {
        partial class FrmBaseManager {
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
                        dgvBaseManager = new DataGridView();
                        gbBase = new GroupBox();
                        btnBaseUpdate = new Button();
                        btnSearch = new Button();
                        Id = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewCheckBoxColumn();
                        ((System.ComponentModel.ISupportInitialize)dgvBaseManager).BeginInit();
                        gbBase.SuspendLayout();
                        SuspendLayout();
                        // 
                        // dgvBaseManager
                        // 
                        dgvBaseManager.AllowUserToAddRows = false;
                        dgvBaseManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        dgvBaseManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvBaseManager.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                        dgvBaseManager.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgvBaseManager.Columns.AddRange(new DataGridViewColumn[] { Id, BaseType, AppraisalBase, IsDel });
                        dgvBaseManager.Location = new Point(12, 82);
                        dgvBaseManager.Name = "dgvBaseManager";
                        dgvBaseManager.RowTemplate.Height = 25;
                        dgvBaseManager.Size = new Size(763, 365);
                        dgvBaseManager.TabIndex = 0;
                        // 
                        // gbBase
                        // 
                        gbBase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        gbBase.Controls.Add(btnBaseUpdate);
                        gbBase.Controls.Add(btnSearch);
                        gbBase.Location = new Point(12, 12);
                        gbBase.Name = "gbBase";
                        gbBase.Size = new Size(763, 64);
                        gbBase.TabIndex = 2;
                        gbBase.TabStop = false;
                        gbBase.Text = "身份管理";
                        // 
                        // btnBaseUpdate
                        // 
                        btnBaseUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnBaseUpdate.Location = new Point(648, 22);
                        btnBaseUpdate.Name = "btnBaseUpdate";
                        btnBaseUpdate.Size = new Size(75, 23);
                        btnBaseUpdate.TabIndex = 8;
                        btnBaseUpdate.Text = "刷新";
                        btnBaseUpdate.UseVisualStyleBackColor = true;
                        // 
                        // btnSearch
                        // 
                        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnSearch.Location = new Point(1206, 31);
                        btnSearch.Name = "btnSearch";
                        btnSearch.Size = new Size(75, 23);
                        btnSearch.TabIndex = 7;
                        btnSearch.Text = "查询";
                        btnSearch.UseVisualStyleBackColor = true;
                        // 
                        // Id
                        // 
                        Id.DataPropertyName = "Id";
                        Id.HeaderText = "编号";
                        Id.Name = "Id";
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
                        IsDel.HeaderText = "删除";
                        IsDel.Name = "IsDel";
                        IsDel.Resizable = DataGridViewTriState.True;
                        IsDel.SortMode = DataGridViewColumnSortMode.Automatic;
                        // 
                        // FrmBaseManager
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(787, 459);
                        Controls.Add(gbBase);
                        Controls.Add(dgvBaseManager);
                        FormBorderStyle = FormBorderStyle.None;
                        Name = "FrmBaseManager";
                        Text = "FrmBaseManager";
                        WindowState = FormWindowState.Maximized;
                        Load += FrmBaseManager_Load;
                        ((System.ComponentModel.ISupportInitialize)dgvBaseManager).EndInit();
                        gbBase.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private DataGridView dgvBaseManager;
                private GroupBox gbBase;
                private Button btnSearch;
                private Button btnBaseUpdate;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
                private DataGridViewCheckBoxColumn IsDel;
        }
}