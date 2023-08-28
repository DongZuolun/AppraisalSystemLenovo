namespace Appraisal_System {
    partial class FrmSetUser {
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
            label1 = new Label();
            txtUserName = new TextBox();
            groupBox1 = new GroupBox();
            chkIsStop = new CheckBox();
            txtSex = new TextBox();
            label3 = new Label();
            cbxBaseType = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(53, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(132, 23);
            txtUserName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsStop);
            groupBox1.Controls.Add(txtSex);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxBaseType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 134);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "填写信息";
            // 
            // chkIsStop
            // 
            chkIsStop.AutoSize = true;
            chkIsStop.Location = new Point(399, 84);
            chkIsStop.Name = "chkIsStop";
            chkIsStop.Size = new Size(75, 21);
            chkIsStop.TabIndex = 6;
            chkIsStop.Text = "是否离职";
            chkIsStop.UseVisualStyleBackColor = true;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(53, 81);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(132, 23);
            txtSex.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 84);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 4;
            label3.Text = "性别";
            // 
            // cbxBaseType
            // 
            cbxBaseType.FormattingEnabled = true;
            cbxBaseType.Location = new Point(271, 21);
            cbxBaseType.Name = "cbxBaseType";
            cbxBaseType.Size = new Size(203, 25);
            cbxBaseType.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 25);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 2;
            label2.Text = "身份";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Location = new Point(12, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 59);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(399, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FrmSetUser
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 223);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmSetUser";
            Text = "FrmSetUser";
            Load += FrmSetUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private GroupBox groupBox1;
        private CheckBox chkIsStop;
        private TextBox txtSex;
        private Label label3;
        private ComboBox cbxBaseType;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnSave;
    }
}