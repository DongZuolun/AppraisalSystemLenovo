using Appraisal_System.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal_System.Model {
        public  class UserAppraisalCoefficient {
                public int Id { get; set; }
                public int UserId { get; set; }
                public int CoefficientId { get; set; }
                public int Count { get; set; }
                public int AssessmentYear { get; set; }
                public string AppraisalType{ get; set; }
                public double AppraisalCoefficient { get; set; }
                public int CaculationMethod { get; set; }

                public bool IsDel { get; set; }

                public static List<UserAppraisalBase> GetAll() {
                        List<UserAppraisalBase> uab = new();
                        DataTable dt = SqlHelper.ExecuteQuery("SELECT u.Id,u.Name,u.Sex,u.BaseTypeId,ab.BaseType,ab.AppraisalBase,u.IsDel FROM Users u LEFT JOIN AppraisalBases ab ON u.BaseTypeId=ab.Id;");
                        foreach (DataRow dr in dt.Rows) {
                                uab.Add(dr.DataRowToModel<UserAppraisalBase>());
                        }
                        return uab;
                }
        }
}
