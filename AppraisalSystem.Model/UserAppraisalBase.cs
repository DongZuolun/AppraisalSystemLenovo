using AppraisalSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppraisalSystem.Model {
    public class UserAppraisalBase {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public int BaseTypeId { get; set; }
        public string? BaseType { get; set; }
        public int AppraisalBase { get; set; }
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
