using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal_System.Common {
        public class FormFactory {
                private static List<Form> forms = new();
                private static List<Type> types = new();
                static FormFactory() {
                        Assembly assembly = Assembly.LoadFrom("Appraisal_System");
                        types = assembly.GetTypes().ToList();
                }
                public static Form CreateForm(string formName) {
                        Form form = forms.Find(x => x.Name == formName);
                        if (form == null) {
                                Type type = types.Find(x => x.Name == formName);
                                form = (Form)Activator.CreateInstance(type);
                                forms.Add(form);
                        }
                        HideFormAll();
                        return form;
                }

                public static void HideFormAll() {
                        foreach (Form form in forms) {
                                form.Hide();
                        }
                }
        }
}
