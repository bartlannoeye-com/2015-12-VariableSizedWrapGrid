using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.StoreApps;
using VariableSizedWrapGrid.Data;

namespace VariableSizedWrapGrid
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<SampleData>(SampleDataGenerator.GetData());
            Groups = new ObservableCollection<SampleDataGroup>(SampleDataGenerator.GetGroupedData());
        }

        private ObservableCollection<SampleDataGroup> _groups;
        public ObservableCollection<SampleDataGroup> Groups
        {
            get { return _groups; }
            set { SetProperty(ref _groups, value); }
        }

        private ObservableCollection<SampleData> _items; // ungrouped view
        public ObservableCollection<SampleData> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
    }
}
