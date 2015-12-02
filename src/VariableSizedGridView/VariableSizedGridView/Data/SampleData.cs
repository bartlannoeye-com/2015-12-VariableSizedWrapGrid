using System.Collections.Generic;

namespace VariableSizedWrapGrid.Data
{
    public class SampleDataGroup
    {
        public string Name { get; set; }
        
        public List<SampleData> Items { get; set; }
    }

    public class SampleData
    {
        public SampleData(string title, int colSpan = 1, int rowSpan = 1)
        {
            Title = title;
            ColSpan = colSpan;
            RowSpan = rowSpan;
        }

        public string Title { get; private set; }
        public int ColSpan { get; set; }
        public int RowSpan { get; set; }
    }
}
