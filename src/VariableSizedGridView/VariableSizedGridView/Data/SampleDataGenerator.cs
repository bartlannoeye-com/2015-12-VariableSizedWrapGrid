using System.Collections.Generic;
using System.Linq;

namespace VariableSizedWrapGrid.Data
{
    internal class SampleDataGenerator
    {
        private static List<SampleData> _data;

        public static List<SampleDataGroup> GetGroupedData()
        {
            if(_data == null)
                GenerateData();

            return _data.GroupBy(d => d.Title.Split(' ')[0],
                (key, items) => new SampleDataGroup() {Name = key, Items = items.ToList()}).ToList();
        }

        public static List<SampleData> GetData()
        {
            if (_data == null)
                GenerateData();
            return _data;
        }

        private static void GenerateData()
        {
            _data = new List<SampleData>();
            _data.Add(new SampleData("Group1 01", 2));
            _data.Add(new SampleData("Group1 02"));
            _data.Add(new SampleData("Group1 03"));
            _data.Add(new SampleData("Group1 04", 2));
            _data.Add(new SampleData("Group1 05"));
            _data.Add(new SampleData("Group1 06"));
            _data.Add(new SampleData("Group1 07"));

            _data.Add(new SampleData("Group2 01"));
            _data.Add(new SampleData("Group2 02"));
            _data.Add(new SampleData("Group2 03"));
            _data.Add(new SampleData("Group2 04"));

            _data.Add(new SampleData("Group3 01", 2, 2));
            _data.Add(new SampleData("Group3 02"));
            _data.Add(new SampleData("Group3 03"));
            _data.Add(new SampleData("Group3 04", 2, 2));
            _data.Add(new SampleData("Group3 05"));
            _data.Add(new SampleData("Group3 06"));

            _data.Add(new SampleData("Group4 01"));
            _data.Add(new SampleData("Group4 02"));
            _data.Add(new SampleData("Group4 03", 2, 2));
            _data.Add(new SampleData("Group4 04"));
            _data.Add(new SampleData("Group4 05"));
            _data.Add(new SampleData("Group4 06"));
            _data.Add(new SampleData("Group4 07"));

            _data.Add(new SampleData("Group5 01"));
            _data.Add(new SampleData("Group5 02"));
            _data.Add(new SampleData("Group5 03"));
        }
    }
}
