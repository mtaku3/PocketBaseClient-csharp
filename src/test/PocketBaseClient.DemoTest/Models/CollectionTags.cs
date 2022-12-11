
// This file was generated automatically for the PocketBase Application demo-test (https://orm-csharp-test.pockethost.io)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient.Orm;
using PocketBaseClient.Orm.Filters;
using PocketBaseClient.Services;

namespace PocketBaseClient.DemoTest.Models
{
    public partial class CollectionTags : CollectionBase<Tag>
    {
        public override string Id => "8zo94eumxnj7ghx";
        public override string Name => "tags";
        public override bool System => false;

        public CollectionTags(DataServiceBase context) : base(context) { }


        public CollectionQuery<CollectionTags, Tag> Filter(string filterString)
             => new CollectionQuery<CollectionTags, Tag>(this, FilterQuery.Create(filterString));

        public CollectionQuery<CollectionTags, Tag> Filter(Func<Tag.Filters, FilterQuery> filter)
            => new CollectionQuery<CollectionTags, Tag>(this, filter(new Tag.Filters()));

    }
}