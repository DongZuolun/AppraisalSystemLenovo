using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Model {
    public class AppraisalCoefficients {
        public int Id { get; set; }
        public string? AppraisalType { get; set; }
        public double AppraisalCoefficient { get; set; }
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
        public static int Insert(AppraisalCoefficients appraisalCoefficient) {
            return SqlHelper.ExecuteNonQuery("INSERT INTO AppraisalCoefficients (IsDel,AppraisalType,AppraisalCoefficient,CaculationMethod)VALUES(@IsDel,@AppraisalType,AppraisalCoefficient,CaculationMethod)",
                new SqlParameter("@IsDel", appraisalCoefficient.IsDel),
                new SqlParameter("@AppraisalType", appraisalCoefficient.AppraisalType),
                new SqlParameter("@AppraisalCoefficient", appraisalCoefficient.AppraisalCoefficient),
                new SqlParameter("@CaculationMethod", appraisalCoefficient.CaculationMethod));
        }
        public static int Edit(AppraisalCoefficients users) {
            return SqlHelper.ExecuteNonQuery("UPDATE AppraisalCoefficients SET  Name=@Name,IsDel=@IsDel,AppraisalType=@AppraisalType,AppraisalCoefficient=@AppraisalCoefficient,CaculationMethod=@CaculationMethod WHERE Id=@Id ",
                new SqlParameter("@IsDel", users.IsDel),
                new SqlParameter("@AppraisalType", users.AppraisalType),
                new SqlParameter("@AppraisalCoefficient", users.AppraisalCoefficient),
                new SqlParameter("@CaculationMethod", users.CaculationMethod));
        }
        public static int Delete(int Id, string appraisalType) {
            return SqlHelper.ExecuteNonQuery("DELETE FROM AppraisalCoefficients WHERE  Id=@Id AND AppraisalType=@AppraisalType;",
                new SqlParameter("@Id", Id),
                new SqlParameter("@AppraisalType", appraisalType));
        }
    }
}
