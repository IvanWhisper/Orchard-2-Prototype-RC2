﻿using Orchard.DependencyInjection;
using Orchard.DisplayManagement.Handlers;

namespace Orchard.ContentManagement.Display.ContentDisplay
{
    public interface IContentDisplayDriver : IDisplayDriver<ContentItem>, IDependency
    {
    }
}
