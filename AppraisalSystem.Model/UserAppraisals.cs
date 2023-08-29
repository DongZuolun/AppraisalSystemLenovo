using AppraisalSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static int Insert(UserAppraisals userAppraisal) {
            return SqlHelper.ExecuteNonQuery("INSERT INTO UserAppraisals (IsDel,UserId,CoeffientId,Count,AssessmentYear) VALUES (@IsDel,@UserId,@CoeffientId,@Count,@AssessmentYear)",
                new SqlParameter("@IsDel", userAppraisal.IsDel),
                new SqlParameter("@UserId", userAppraisal.UserId),
                new SqlParameter("@CoeffientId", userAppraisal.CoeffientId),
                new SqlParameter("@Count", userAppraisal.Count),
                new SqlParameter("@AssessmentYear", userAppraisal.AssessmentYear));
        }
        public static int Edit(UserAppraisals userAppraisal) {
            return SqlHelper.ExecuteNonQuery("UPDATE UserAppraisals SET  UserId=@UserId,IsDel=@IsDel,,CoeffientId=@CoeffientId,Count=@Count,AssessmentYear=@AssessmentYear WHERE Id=@Id ;",
                new SqlParameter("@Id", userAppraisal.Id),
                new SqlParameter("@UserId", userAppraisal.UserId),
                new SqlParameter("@IsDel", userAppraisal.IsDel),
                new SqlParameter("@CoeffientId", userAppraisal.CoeffientId),
                new SqlParameter("@Count", userAppraisal.Count),
                new SqlParameter("@AssessmentYear", userAppraisal.AssessmentYear));
        }
        public static int Delete(int Id, string userId) {
            return SqlHelper.ExecuteNonQuery("DELETE FROM UserAppraisals WHERE  Id=@Id AND UserId=@UserId;",
                new SqlParameter("@Id", Id),
                new SqlParameter("@UserId", userId));
        }
    }
}
