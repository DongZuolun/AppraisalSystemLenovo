using AppraisalSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalSystem.Model {
    public class AppraisalBases {
        public int Id { get; set; }
        public string? BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool IsDel { get; set; }

        public static List<AppraisalBases> GetAll() {
            List<AppraisalBases> appraisalBases = new();
            DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM AppraisalBases;");
            foreach (DataRow dr in dt.Rows) {
                appraisalBases.Add(dr.DataRowToModel<AppraisalBases>());
            }
            return appraisalBases;
        }
    }
}
