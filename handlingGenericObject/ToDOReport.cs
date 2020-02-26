using handlingGenericObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handlingGenericObject
{
    class ToDOReport : IEntryManager<ToDOEntry>
    {
        private List<ToDOEntry> _toDOReports;

        public ToDOReport()
        {
            _toDOReports = new List<ToDOEntry>();
        }

        public void AddEnty(ToDOEntry entry) => _toDOReports.Add(entry);

        public void RemoveEntry(int index) => _toDOReports.RemoveAt(index);

        public override string ToString() => string.Join(Environment.NewLine, _toDOReports.Select(x => $"task with id {x.id}"));
    }
}
