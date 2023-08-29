using Appraisal_System.Utility;
using System.Data;
using System.Data.SqlClient;

namespace Appraisal_System.Model {
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
        public static int Insert(AppraisalBases appraisalBases) {
            return SqlHelper.ExecuteNonQuery("INSERT INTO AppraisalBases (IsDel,BaseType,AppraisalBase) VALUES (@IsDel,@BaseType,@AppraisalBase)",
                new SqlParameter("@IsDel", appraisalBases.IsDel),
                new SqlParameter("@BaseType", appraisalBases.BaseType),
                new SqlParameter("@AppraisalBase", appraisalBases.AppraisalBase));
        }
        public static int Edit(AppraisalBases appraisalBases) {
            return SqlHelper.ExecuteNonQuery("UPDATE AppraisalBases SET Name=@Name, IsDel=@IsDel,BaseType=@BaseType,AppraisalBase=@AppraisalBase WHERE Id=@Id ",
                new SqlParameter("@IsDel", appraisalBases.IsDel),
                new SqlParameter("@BaseType", appraisalBases.BaseType),
                new SqlParameter("@AppraisalBase", appraisalBases.AppraisalBase));
        }
        public static int Delete(int Id, string baseType) {
            return SqlHelper.ExecuteNonQuery("DELETE FROM AppraisalBases WHERE  Id=@Id AND BaseType=@baseType;",
                new SqlParameter("@Id", Id),
                new SqlParameter("@BaseType", baseType));
        }
    }
}
