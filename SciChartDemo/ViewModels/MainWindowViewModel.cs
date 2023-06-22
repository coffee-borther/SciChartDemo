using Prism.Regions;
using SciChartDemo.Views;

namespace SciChartDemo.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("MainWindowRegion", typeof(IndexView));
        }
    }
}
