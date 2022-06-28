using System;
using System.Collections.Generic;
using System.Text;

namespace eHouseManager.Services.Helpers
{
    public class PropertyCopier<TParent, TChild> where TParent : class
                                            where TChild : class
    {
        public static void Copy(TParent parent, TChild child)
        {
            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();

            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                      
                        if (parentProperty.PropertyType == typeof(string))
                        {
                            if (string.IsNullOrEmpty( (string) parentProperty.GetValue(parent)))
                            {
                                break;
                            }
                        }

/*                        if (parentProperty.PropertyType == typeof(bool) && )
                        {
                            break;
                        }
*/

                        if (parentProperty.PropertyType == typeof(int) && (int)parentProperty.GetValue(parent) == 0)
                        {
                            break;
                        }
                        childProperty.SetValue(child, parentProperty.GetValue(parent));
                        break;
                    }
                }
            }
        }
    }
}
