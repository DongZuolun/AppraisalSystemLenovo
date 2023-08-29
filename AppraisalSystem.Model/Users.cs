using AppraisalSystem.Utility;
using System.Data;
using System.Data.SqlClient;

namespace AppraisalSystem.Model {
    public class Users {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string? Password { get; set; }
        public int BaseTypeId { get; set; }
        public bool IsDel { get; set; }

        public static List<Users> GetAll() {
            var list = new List<Users>();
            DataTable dt = SqlHelper.ExecuteQuery("SELECT * FROM Users");
            foreach (DataRow dr in dt.Rows) {
                list.Add(dr.DataRowToModel<Users>());
            }
            return list;
        }
        public static int Insert(Users users) {
            return SqlHelper.ExecuteNonQuery("INSERT INTO Users (IsDel,Name,Sex,Password,BaseTypeId) VALUES (@IsDel,@Name,@Sex,@Password,@BaseTypeId)",
                new SqlParameter("@IsDel", users.IsDel),
                new SqlParameter("@Name", users.Name),
                new SqlParameter("@Sex", users.Sex),
                new SqlParameter("@Password", users.Password),
                new SqlParameter("@BaseTypeId", users.BaseTypeId));
        }
        public static int Edit(Users users) {
            return SqlHelper.ExecuteNonQuery("UPDATE Users SET  Name=@Name,IsDel=@IsDel,Sex=@Sex,Password=@Password,BaseTypeId=@BaseTypeId WHERE Id=@Id ;",
                new SqlParameter("@Id", users.Id),
                new SqlParameter("@Name", users.Name),
                new SqlParameter("@IsDel", users.IsDel),
                new SqlParameter("@Sex", users.Sex),
                new SqlParameter("@Password", users.Password),
                new SqlParameter("@BaseTypeId", users.BaseTypeId));
        }
        public static int Delete(int userId, string userName) {
            return SqlHelper.ExecuteNonQuery("DELETE FROM Users WHERE  Id=@Id AND Name=@Name;",
                new SqlParameter("@Id", userId),
                new SqlParameter("@Name", userName));
        }
    }
}