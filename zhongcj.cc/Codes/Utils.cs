using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace zhongcj.cc
{
    public class Utils
    {
        /// <summary>
        /// 获取连接字符串某项的值
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="itemName">项目</param>
        /// <returns>项目值</returns>
        public static string GetItemValueFromConnectionString(string connectionString, string itemName)
        {
            if (!connectionString.EndsWith(";"))
                connectionString += ";";

            // \s* 匹配0个或多个空白字符
            // .*? 匹配0个或多个除 "\n" 之外的任何字符(?指尽可能少重复)
            string regexStr = itemName + @"\s*=\s*(?<key>.*?);";
            Regex r = new Regex(regexStr, RegexOptions.IgnoreCase);
            Match mc = r.Match(connectionString);
            return mc.Groups["key"].Value;
        }
    }
}