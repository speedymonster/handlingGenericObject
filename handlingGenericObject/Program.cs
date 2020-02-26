using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handlingGenericObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var workReport = new WorkReport();
            workReport.AddEnty(new WorkReportEntry { ProjectCode = "1", ProjectName = "Programming", SpentHout = 12});
            workReport.AddEnty(new WorkReportEntry { ProjectCode = "2", ProjectName = "Programming in Java", SpentHout = 2 });

            var saver = new FileSaver();
            saver.SaveToFile<WorkReportEntry>(@"Reports", "summary.txt", workReport);
        }
    }
}
