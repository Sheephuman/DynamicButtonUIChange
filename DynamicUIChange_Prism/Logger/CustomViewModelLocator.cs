using Prism.Ioc;
using Prism.Logging;

using System;

namespace DynamicUIChange_Livet
{
    public class CustomViewModelLocator
    {
        private readonly ILogger _logger;
        private readonly IContainerProvider _container;

        public CustomViewModelLocator(ILogger logger, IContainerProvider container)
        {
            _logger = logger;
            _container = container;
        }

        public void ConfigureViewModelLocator(IContainerRegistry containerRegistry)
        {

        }

        public object ResolveViewModelForView(object view, Type viewModelType)
        {


            return _container.Resolve(viewModelType);
        }
    }
}