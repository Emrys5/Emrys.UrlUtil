using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Routing;

namespace Emrys.UrlUtil
{
    public class UrlUtil
    {
        /// <summary>
        /// URL组合，包含路径与参数
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pathParts"></param>
        /// <returns></returns>
        public static string BuildUrl(string path, params object[] pathParts)
        {
            path = HttpUtility.UrlPathEncode(path);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < pathParts.Length; i++)
            {
                object obj = pathParts[i];
                if (obj.GetType() == typeof(string))
                {
                    string str = Convert.ToString(obj);
                    path = (path + "/" + HttpUtility.UrlPathEncode(str)).Replace("///", "/").Replace("//", "/");
                }
                else
                {
                    foreach (var current in obj as Dictionary<string, string>)
                    {
                        // 判断之前是否包含参数
                        if (stringBuilder.Length == 0 && path.IndexOf("?") == -1)
                        {
                            stringBuilder.Append('?');
                        }
                        else
                        {
                            stringBuilder.Append('&');
                        }
                        string str2 = Convert.ToString(current.Value);
                        stringBuilder.Append(HttpUtility.UrlEncode(current.Key)).Append('=').Append(HttpUtility.UrlEncode(str2));
                    }
                }
            }
            return path + stringBuilder;
        }
    }
}
