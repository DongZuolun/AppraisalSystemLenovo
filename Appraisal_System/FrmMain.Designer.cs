namespace Appraisal_System {
        partial class FrmMain {
                /// <summary>
                ///  Required designer variable.
                /// </summary>
                private System.ComponentModel.IContainer components = null;

                /// <summary>
                ///  Clean up any resources being used.
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
                ///  Required method for Designer support - do not modify
                ///  the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent() {
                        TreeNode treeNode1 = new TreeNode("用户管理");
                        TreeNode treeNode2 = new TreeNode("基数管理");
                        TreeNode treeNode3 = new TreeNode("系数管理");
                        TreeNode treeNode4 = new TreeNode("人员绩效");
                        label1 = new Label();
                        spcMain = new SplitContainer();
                        trvMenu = new TreeView();
                        ((System.ComponentModel.ISupportInitialize)spcMain).BeginInit();
                        spcMain.Panel1.SuspendLayout();
                        spcMain.SuspendLayout();
                        SuspendLayout();
                        // 
                        // label1
                        // 
                        label1.AutoSize = true;
                        label1.Dock = DockStyle.Bottom;
                        label1.Location = new Point(0, 617);
                        label1.Name = "label1";
                        label1.Size = new Size(248, 17);
                        label1.TabIndex = 0;
                        label1.Text = "© 2023 DongZuolun，All rights reserved.";
                        // 
                        // spcMain
                        // 
                        spcMain.Dock = DockStyle.Fill;
                        spcMain.Location = new Point(0, 0);
                        spcMain.Name = "spcMain";
                        // 
                        // spcMain.Panel1
                        // 
                        spcMain.Panel1.Controls.Add(trvMenu);
                        spcMain.Size = new Size(1141, 617);
                        spcMain.SplitterDistance = 233;
                        spcMain.TabIndex = 1;
                        // 
                        // trvMenu
                        // 
                        trvMenu.Dock = DockStyle.Fill;
                        trvMenu.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                        trvMenu.FullRowSelect = true;
                        trvMenu.ItemHeight = 40;
                        trvMenu.Location = new Point(0, 0);
                        trvMenu.Name = "trvMenu";
                        treeNode1.Name = "tnUserManager";
                        treeNode1.Tag = "FrmUserManager";
                        treeNode1.Text = "用户管理";
                        treeNode2.Name = "tnBaseManager";
                        treeNode2.Tag = "FrmBaseManager";
                        treeNode2.Text = "基数管理";
                        treeNode3.Name = "tnAppraisalManager";
                        treeNode3.Tag = "FrmAppraisalManager";
                        treeNode3.Text = "系数管理";
                        treeNode4.Name = "tnUserAppraisal";
                        treeNode4.Tag = "FrmUserAppraisal";
                        treeNode4.Text = "人员绩效";
                        trvMenu.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
                        trvMenu.ShowLines = false;
                        trvMenu.Size = new Size(233, 617);
                        trvMenu.TabIndex = 0;
                        trvMenu.AfterSelect += trvMenu_AfterSelect;
                        // 
                        // FrmMain
                        // 
                        AutoScaleDimensions = new SizeF(7F, 17F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(1141, 634);
                        Controls.Add(spcMain);
                        Controls.Add(label1);
                        IsMdiContainer = true;
                        Name = "FrmMain";
                        Text = "考勤管理";
                        Load += FrmMain_Load;
                        spcMain.Panel1.ResumeLayout(false);
                        ((System.ComponentModel.ISupportInitialize)spcMain).EndInit();
                        spcMain.ResumeLayout(false);
                        ResumeLayout(false);
                        PerformLayout();
                }

                #endregion

                private Label label1;
                private SplitContainer spcMain;
                private TreeView trvMenu;
        }
}