using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handlingGenericObject
{
    class WorkReport : IEntryManager<WorkReportEntry>
    {
        private List<WorkReportEntry> _workReportEntries;
        public WorkReport()
        {
            _workReportEntries = new List<WorkReportEntry>();
        }

        public void AddEnty(WorkReportEntry entry) => _workReportEntries.Add(entry);

        public void RemoveEntry(int index) => _workReportEntries.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, _workReportEntries.Select(x => $"Project with code {x.ProjectCode} and name {x.ProjectName}"));
    }
}
