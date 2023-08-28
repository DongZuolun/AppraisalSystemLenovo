using AppraisalSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalSystem.Model {
    public class AppraisalCoefficients {
        public int Id { get; set; }
        public string? AppraisalType { get; set; }
        public int AppraisalCoefficient { get; set; }
        public int CaculationMethod { get; set; }
        public bool IsDel { get; set; }
        public static List<AppraisalCoefficients> GetAll() {
            List<AppraisalCoefficients> ac = new();
            DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM AppraisalCoefficients;");
            foreach (DataRow dr in dt.Rows) {
                ac.Add(dr.DataRowToModel<AppraisalCoefficients>());
            }
            return ac;
        }
    }
}
