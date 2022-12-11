
// This file was generated automatically for the PocketBase Application demo-test (https://orm-csharp-test.pockethost.io)
//    See CodeGenerationSummary.txt for more details
//
// PocketBaseClient-csharp project: https://github.com/iluvadev/PocketBaseClient-csharp
// Issues: https://github.com/iluvadev/PocketBaseClient-csharp/issues
// License (MIT): https://github.com/iluvadev/PocketBaseClient-csharp/blob/main/LICENSE
//
// pocketbase-csharp-sdk project: https://github.com/PRCV1/pocketbase-csharp-sdk 
// pocketbase project: https://github.com/pocketbase/pocketbase

using PocketBaseClient;
using PocketBaseClient.Services;
using PocketBaseClient.DemoTest.Models;

namespace PocketBaseClient.DemoTest.Services
{
    public partial class DemoTestDataService : DataServiceBase
    {
        #region Collections
        public CollectionUsers UsersCollection { get; }
        public CollectionTestForTypes TestForTypesCollection { get; }
        public CollectionTestForRelated TestForRelatedCollection { get; }
        public CollectionPosts PostsCollection { get; }
        public CollectionAuthors AuthorsCollection { get; }
        public CollectionCategories CategoriesCollection { get; }
        public CollectionTags TagsCollection { get; }

        protected override void RegisterCollections()
        {
            RegisterCollection(typeof(User), UsersCollection);
            RegisterCollection(typeof(TestForTypes), TestForTypesCollection);
            RegisterCollection(typeof(TestForRelated), TestForRelatedCollection);
            RegisterCollection(typeof(Post), PostsCollection);
            RegisterCollection(typeof(Author), AuthorsCollection);
            RegisterCollection(typeof(Category), CategoriesCollection);
            RegisterCollection(typeof(Tag), TagsCollection);
        }
        #endregion Collections

        #region Constructor
        public DemoTestDataService(PocketBaseClientApplication app) : base(app)
        {
            // Collections
            UsersCollection = new CollectionUsers(this);
            TestForTypesCollection = new CollectionTestForTypes(this);
            TestForRelatedCollection = new CollectionTestForRelated(this);
            PostsCollection = new CollectionPosts(this);
            AuthorsCollection = new CollectionAuthors(this);
            CategoriesCollection = new CollectionCategories(this);
            TagsCollection = new CollectionTags(this);

            RegisterCollections();
        }
        #endregion Constructor
    }
}