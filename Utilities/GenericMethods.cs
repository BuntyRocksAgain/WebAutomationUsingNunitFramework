using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoFramework.Utilities
{
    public class GenericMethods
    {
        public static string DirectoryPat()
        {
            try
            {
                string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!.ToString();

                //string[] spl = currentDirectory.Split('\\');
                //string temppath = "";
                //for (int split = 0; split <= spl.Length - 4; split++)
                //{
                //    temppath = temppath + spl[split] + "\\";
                //}
                return currentDirectory;

            }
            catch (Exception e)
            {
                Assert.Fail("Problem in getting Directory path" + e);
                return "";
            }

        }

        public static void uploadFile(IWebElement element, String path)
        {
            try
            {
                String filePath = GenericMethods.DirectoryPat() + path;
                element.SendKeys(filePath);

            }
            catch (Exception e)
            {
                Assert.Fail("Problem in getting Directory path" + e);

            }

        }

        public static string GetDateTimeRelpaceSlashWithUnderscore()
        {
            try
            {
                return Convert.ToString(DateTime.Now).Replace("/", "_").Replace(":", "_").Replace(" ", "_");

            }
            catch (Exception e)
            {
                Assert.Fail("Problem in getting Date time " + e);
                return "";
            }

        }

    }
}
