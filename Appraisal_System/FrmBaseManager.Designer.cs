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
                        dataGridView1 = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        BaseType = new DataGridViewTextBoxColumn();
                        AppraisalBase = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewTextBoxColumn();
                        groupBox1 = new GroupBox();
                        btnSearch = new Button();
                        btnBaseUpdate = new Button();
                        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
                        groupBox1.SuspendLayout();
                        SuspendLayout();
                        // 
                        // dataGridView1
                        // 
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, BaseType, AppraisalBase, IsDel });
                        dataGridView1.Location = new Point(12, 82);
                        dataGridView1.Name = "dataGridView1";
                        dataGridView1.RowTemplate.Height = 25;
                        dataGridView1.Size = new Size(763, 365);
                        dataGridView1.TabIndex = 0;
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
                        // 
                        // groupBox1
                        // 
                        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        groupBox1.Controls.Add(btnBaseUpdate);
                        groupBox1.Controls.Add(btnSearch);
                        groupBox1.Location = new Point(12, 12);
                        groupBox1.Name = "groupBox1";
                        groupBox1.Size = new Size(763, 64);
                        groupBox1.TabIndex = 2;
                        groupBox1.TabStop = false;
                        groupBox1.Text = "身份管理";
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
                        // FrmBaseManager
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(787, 459);
                        Controls.Add(groupBox1);
                        Controls.Add(dataGridView1);
                        Name = "FrmBaseManager";
                        Text = "FrmBaseManager";
                        WindowState = FormWindowState.Maximized;
                        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
                        groupBox1.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private DataGridView dataGridView1;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn BaseType;
                private DataGridViewTextBoxColumn AppraisalBase;
                private DataGridViewTextBoxColumn IsDel;
                private GroupBox groupBox1;
                private Button btnSearch;
                private Button btnBaseUpdate;
        }
}