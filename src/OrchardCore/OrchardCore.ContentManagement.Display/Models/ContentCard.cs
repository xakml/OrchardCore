using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.ModelBinding;

namespace OrchardCore.ContentManagement.Display.Models
{
    // TODO Find a good name for this model
    // TODO Find a good project to place this in.
    // Perhaps a OrchardCore.Widgets.Core project
    // TODO move many of these properties to a ContentCardViewModel

    public abstract class ContentCard
    {
        public dynamic CollectionShape { get; set; }

        // TODO should be Type <TCollection>
        public string CollectionShapeType { get; set; }
                //Shape Specific
                // This should be named ContentItem not Widget (maybe)
        public ContentItem Widget { get; set; }
        // TODO this should go and
        public string ContentType { get; set; }

        // TODO Why do we have this property?
        public bool BuildEditor { get; set; }
        public string ParentContentType { get; set; }
        public string CollectionPartName { get; set; }

        // TODO possibly being speciic to flow parts this should not be contained in this model.
        public int ColumnSize { get; set; }

        //Card Specific Properties
        public string TargetId { get; set; }
        public bool Inline { get; set; }
        public bool CanMove { get; set; }
        public bool CanDelete { get; set; }
        public bool CanInsert { get; set; }
        // TODO Remove if possible.
        public IUpdateModel Updater { get; set; }

        //Input hidden
        //Prefixes
        // TODO we can rationalize this widtg content item property now that we are maintaining across ids
        // This was left for backwards compatability.
        public string PrefixValue { get; set; }
        public string HtmlFieldPrefix { get; set; }

        //TODO as IShape
        public dynamic ContentEditor { get; set; }

        public string PrefixesId { get; set; }
        public string PrefixesName { get; set; }
        //Content Types
        public string ContentTypesId { get; set; }
        public string ContentTypesName { get; set; }
    }
}
