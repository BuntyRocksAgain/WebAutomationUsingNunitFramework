using AutoFramework.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace WebAutomationNunitFramework.Library
{
    public class ExtentReport
    {
        public static ExtentReports? extent;
        public static ExtentTest? test;
        public static string? ReportPath = null;
        public static string? fullpath = null;
        public static string? ModuleName = null;
        public static string? check;
        public static string? time;
        public static string? path;

        public static void CExtentReport()
        {

            try
            {
                if (check == null)
                {
                    time = GenericMethods.GetDateTimeRelpaceSlashWithUnderscore();
                    path = GenericMethods.DirectoryPat() + "\\Output\\ExtentReports\\";

                    ReportPath = path + "Results " + time;
                    Directory.CreateDirectory(ReportPath);
                }

                fullpath = ReportPath + "\\" + time + ".html";
                //var htmlReporter = new ExtentSparkReporter(fullpath);
                //var htmlReporter = new ExtentHtmlReporter();
                extent = new ExtentReports();
                var spark = new ExtentSparkReporter(fullpath);
                extent.AttachReporter(spark);
                extent.AddSystemInfo("Host Name", "Automation Practice");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("Application", "Swag Labs");
                extent.AddSystemInfo("Owner", "Automation Team");

                check = "Created";

            }
            catch (Exception e)
            {
                Assert.Fail("problem in setting extent report" + e);

            }
            // return extent;


        }
        //public static void ExtentFail(String details)
        //{
        //    try
        //    {
        //        test.Log(Status.Fail, details, MediaEntityBuilder.CreateScreenCaptureFromPath(Screenshot(TestBase.driver, "HomePage")).Build());
        //        //Logger.log.Info(details);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //public static void ExtentWarn(String details)
        //{
        //    try
        //    {
        //        test.Log(Status.Warning, details, MediaEntityBuilder.CreateScreenCaptureFromPath(Screenshot(TestBase.driver, "HomePage")).Build());
        //        //Logger.log.Info(details);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        public static void ExtentPass(String details)
        {
            try
            {
                test!.Log(Status.Pass, details);
                //Logger.log.Info(details);

            }
            catch (Exception)
            {

            }
        }

        public static void ExtentModuleName(String module)
        {
            ModuleName = module;
        }
    }
}
