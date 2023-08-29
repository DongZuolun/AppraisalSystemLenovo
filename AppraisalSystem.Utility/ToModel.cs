using System.Data;

namespace Appraisal_System.Utility {
    public static class ToModel {
        public static T DataRowToModel<T>(this DataRow dr) {
            Type type = typeof(T);
            T model = (T)Activator.CreateInstance(type);
            foreach (var prop in type.GetProperties()) {
                prop.SetValue(model, dr[prop.Name]);
            }
            return model;
        }
    }
}
