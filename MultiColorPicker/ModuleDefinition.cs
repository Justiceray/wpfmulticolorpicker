using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using MultiColorPicker.Views;
namespace MultiColorPicker
{
    public class ModuleDefinition : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("ContentRegion", typeof(MulitColorPickerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
