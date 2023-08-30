using Appraisal_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appraisal_System {
        public partial class FrmUserAppraisal : Form {
                public FrmUserAppraisal() {
                        InitializeComponent();
                }

                private void FrmUserAppraisal_Load(object sender, EventArgs e) {
                        AddCol();
                        SetCol();
                }

                private void SetCol() {
                        DataTable dt = UserAppraisalBase.GetDT();
                        List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.GetAll();
                        foreach (var ac in appraisalCoefficients) {
                                dt.Columns.Add(new DataColumn {
                                        ColumnName = ac.AppraisalType 
                                });
                                dt.Columns.Add(new DataColumn {
                                        ColumnName = ac.AppraisalType+ac.AppraisalCoefficient
                                });
                                dt.Columns.Add(new DataColumn {
                                        ColumnName = ac.AppraisalType + ac.CaculationMethod
                                });
                        }
                        dt.Columns.Add(new DataColumn {
                                ColumnName = "AssessmentYear"
                        });
                        dt.Columns.Add(new DataColumn {
                                ColumnName = "YearBonus"
                        });
                        dgvUserAppraisal.AutoGenerateColumns = false;
                        dgvUserAppraisal.DataSource= dt;
                }

                private void AddCol() {
                        List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.GetAll();
                        List<DataGridViewTextBoxColumn> dgvColumn = new();
                        foreach (var ac in appraisalCoefficients) {
                                dgvColumn.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType,
                                        DataPropertyName = ac.AppraisalType,
                                        Name = ac.AppraisalType,
                                        ReadOnly = true,
                                        Width = 88,
                                });
                                dgvColumn.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType + "系数",
                                        DataPropertyName = ac.AppraisalType + ac.AppraisalCoefficient.ToString() ,
                                        Name = ac.AppraisalType + ac.AppraisalCoefficient.ToString() ,      
                                        ReadOnly = true,
                                        Width = 88,
                                        Visible = false,
                                });
                                dgvColumn.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType + "计算方式" ,
                                        DataPropertyName = ac.AppraisalType + ac.CaculationMethod.ToString() ,
                                        Name = ac.AppraisalType + ac.CaculationMethod.ToString() ,
                                        ReadOnly = true,
                                        Width = 88,
                                        Visible = false,
                                });
                        }
                        dgvColumn.Add(new DataGridViewTextBoxColumn {
                                HeaderText = "考核年度",
                                DataPropertyName = "AssessmentYear",
                                Name = "AssessmentYear",
                                ReadOnly = true,
                                Width = 166,
                        });
                        dgvColumn.Add(new DataGridViewTextBoxColumn {
                                HeaderText = "实发年终奖",
                                DataPropertyName = "YearBonus",
                                Name = "YearBonus",
                                ReadOnly = true,
                                Width = 166,
                        });
                        dgvUserAppraisal.Columns.AddRange(dgvColumn.ToArray());
                }
        }
}
