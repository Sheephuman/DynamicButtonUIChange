using DynamicChange_Prism.Views;
using DynamicUIChange_Livet.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DynamicUIChange_Livet.Module
{
    [Module(ModuleName = "MyModule")]
    public class ModuleInit : IModule
    {

        private readonly IRegionManager _regionManager;

        public ModuleInit(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //_regionManager.RegisterViewWithRegion("MainRegion", typeof(View1));
            //_regionManager.RegisterViewWithRegion("MainRegion", typeof(View2));
            //_regionManager.RegisterViewWithRegion("MainRegion", typeof(View3));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Viewの登録（RequestNavigate用）
            containerRegistry.RegisterForNavigation<View1>();
            containerRegistry.RegisterForNavigation<View2>();
            containerRegistry.RegisterForNavigation<View3>();
        }
    }
}
