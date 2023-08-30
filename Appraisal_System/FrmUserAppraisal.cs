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
                                        ColumnName = ac.AppraisalType + ac.Id
                                }); ;
                        }
                        dgvUserAppraisal.AutoGenerateColumns = false;
                        dgvUserAppraisal.DataSource= dt;
                }

                private void AddCol() {
                        List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.GetAll();
                        List<DataGridViewTextBoxColumn> dgvColumn = new();
                        foreach (var ac in appraisalCoefficients) {
                                dgvColumn.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = ac.AppraisalType,
                                        DataPropertyName = ac.AppraisalType + ac.Id,
                                        Name = ac.AppraisalType + ac.Id,
                                        ReadOnly = true,
                                        Width = 88,
                                });
                                dgvColumn.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = "系数",
                                        DataPropertyName = ac.AppraisalCoefficient.ToString() + ac.Id,
                                        Name = ac.AppraisalCoefficient.ToString() + ac.Id,
                                        ReadOnly = true,
                                        Width = 88,
                                        Visible = false,
                                });
                                dgvColumn.Add(new DataGridViewTextBoxColumn {
                                        HeaderText = "计算方式" ,
                                        DataPropertyName = ac.CaculationMethod.ToString() + ac.Id,
                                        Name = ac.CaculationMethod.ToString() + ac.Id,
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
