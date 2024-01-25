using DevExpress.Blazor;
using DevExpress.Blazor.Internal;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ExtendedGridLayout.Data {
    public class GridExtendedLayout {
        public GridPersistentLayout Layout { get; }
        public bool FilterRowVisible { get; }
        public bool GroupPanelVisible { get; }
        public bool SearchBoxVisible { get; }

        public GridExtendedLayout(GridPersistentLayout layout, bool filterRowVisible, bool groupPanelVisible, bool searchBoxVisible) {
            Layout = layout;
            FilterRowVisible = filterRowVisible;
            GroupPanelVisible = groupPanelVisible;
            SearchBoxVisible = searchBoxVisible;
        }
    }
}
