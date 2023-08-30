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
                        dataGridView1 = new DataGridView();
                        Id = new DataGridViewTextBoxColumn();
                        AppraisalType = new DataGridViewTextBoxColumn();
                        AppraisalCoefficient = new DataGridViewTextBoxColumn();
                        IsDel = new DataGridViewTextBoxColumn();
                        groupBox1.SuspendLayout();
                        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
                        SuspendLayout();
                        // 
                        // groupBox1
                        // 
                        groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        groupBox1.Controls.Add(btnAppraisalUpdate);
                        groupBox1.Controls.Add(btnUpdate);
                        groupBox1.Controls.Add(btnSearch);
                        groupBox1.Location = new Point(19, 8);
                        groupBox1.Name = "groupBox1";
                        groupBox1.Size = new Size(763, 64);
                        groupBox1.TabIndex = 4;
                        groupBox1.TabStop = false;
                        groupBox1.Text = "绩效管理";
                        // 
                        // btnAppraisalUpdate
                        // 
                        btnAppraisalUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        btnAppraisalUpdate.Location = new Point(653, 22);
                        btnAppraisalUpdate.Name = "btnAppraisalUpdate";
                        btnAppraisalUpdate.Size = new Size(75, 23);
                        btnAppraisalUpdate.TabIndex = 9;
                        btnAppraisalUpdate.Text = "刷新";
                        btnAppraisalUpdate.UseVisualStyleBackColor = true;
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
                        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, AppraisalType, AppraisalCoefficient, IsDel });
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
                        // 
                        // FrmAppraisalManager
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(800, 450);
                        Controls.Add(groupBox1);
                        Controls.Add(dataGridView1);
                        Name = "FrmAppraisalManager";
                        Text = "FrmAppraisalManager";
                        WindowState = FormWindowState.Maximized;
                        groupBox1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
                        ResumeLayout(false);
                }

                #endregion

                private GroupBox groupBox1;
                private Button btnUpdate;
                private Button btnSearch;
                private DataGridView dataGridView1;
                private Button btnAppraisalUpdate;
                private DataGridViewTextBoxColumn Id;
                private DataGridViewTextBoxColumn AppraisalType;
                private DataGridViewTextBoxColumn AppraisalCoefficient;
                private DataGridViewTextBoxColumn IsDel;
        }
}