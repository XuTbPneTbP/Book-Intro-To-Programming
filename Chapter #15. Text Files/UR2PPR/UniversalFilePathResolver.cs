using System;
using System.IO;
using System.Reflection;
using System.Web;
using System.Threading.Tasks;

namespace UR2PPR
{
    public class UniversalFilePathResolver
    {
        public static string CatchThePath(string anyPathGiven)
        {
            if (anyPathGiven == null || !anyPathGiven.StartsWith("~"))
            {
                throw new ArgumentException("The path '" + anyPathGiven + "' should be relative path and should start with '~'");
            }

            HttpContext httpContext = HttpContext.Current;

            if (httpContext != null)
            {
                // We are in a Web application --> use Server.MapPath to get the physical path
                string fullPath = httpContext.Server.MapPath(anyPathGiven);
                return fullPath;
            }
            else
            {
                // We are in a console / Windows desktop application -->
                // use currently executing assembly directory to find the full path
                Assembly assembly = Assembly.GetExecutingAssembly();
                string assemblyDirectory = assembly.CodeBase;

                assemblyDirectory = assemblyDirectory.Replace("file:///", "");
                assemblyDirectory = Path.GetDirectoryName(assemblyDirectory);

                // Remove "bin\debug" and "bin\release" directories from the path
                string applicationDir = RemoveStringAtEnd(@"\bin\debug", assemblyDirectory);
                applicationDir = RemoveStringAtEnd(@"\bin\release", applicationDir);

                string fullPath = anyPathGiven.Replace("~", applicationDir);
                return fullPath;

            }


        }

        private static string RemoveStringAtEnd(string searchString, string targetString)
        {
            if (targetString.ToLower().EndsWith(searchString.ToLower()))
            {
                string result = targetString.Substring(0, targetString.Length - searchString.Length);
                return result;
            }
            return targetString;
        }
    }
}

