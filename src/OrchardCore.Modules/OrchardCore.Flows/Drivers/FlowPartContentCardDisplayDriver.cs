using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.Views;
using OrchardCore.Flows.Models;
using OrchardCore.Flows.ViewModels;

namespace OrchardCore.Flows.Drivers
{

    // This should return specific shapes for the toolbar zones, and other items you want to become part of the ContentCard concept.
    public class FlowPartContentCardDisplayDriver : DisplayDriver<ContentCard, FlowPartContentCard>
    {

        public override IDisplayResult Display(FlowPartContentCard flowPartContentCard)
        {
            return null;
            // return Combine(
            //     // TODO Return other components, like the toolbar zones here.
            //     View("Toolbar", flowPartContentCard).Location("DetailAdmin", "Header")
            // Maybe this could also return an edit shape, i.e. ContentCard-FlowPart.Edit maybe? rather than being morphed in the view
            // That's just an idea...
        }
    }

    // This returns the main ContentCard shape and would be generated for every content card.
    public class ContentCardDisplayDriver : DisplayDriver<ContentCard>
    {

        public override IDisplayResult Display(ContentCard contentCard)
        {
            // This should return Initialize<ContentCardViewModel>
            // and that viewmodel should have the properties like ContentEditor

            return View("ContentCard", contentCard).Location("DetailAdmin", "Content");
        }
    }
}
