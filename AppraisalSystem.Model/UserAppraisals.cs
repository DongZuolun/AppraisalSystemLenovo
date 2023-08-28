using AppraisalSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalSystem.Model {
    public class UserAppraisals {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoeffientId { get; set; }
        public int Count { get; set; }
        public int AssessmentYear { get; set; }
        public bool IsDel { get; set; }
        public static List<UserAppraisals> GetAll() {
            List<UserAppraisals> us = new();
            DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM UserAppraisals;");
            foreach (DataRow dr in dt.Rows) {
                us.Add(dr.DataRowToModel<UserAppraisals>());
            }
            return us;
        }
    }
}
