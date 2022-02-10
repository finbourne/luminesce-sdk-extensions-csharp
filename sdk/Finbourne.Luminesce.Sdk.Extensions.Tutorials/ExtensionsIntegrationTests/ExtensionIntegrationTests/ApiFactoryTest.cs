using Finbourne.Luminesce.Sdk.Api;
using Finbourne.Luminesce.Sdk.Client;
using Finbourne.Luminesce.Sdk.Model;
using NUnit.Framework;
using System;

namespace Finbourne.Luminesce.Sdk.Extensions.Tutorials
{
    public class ApiFactoryTest
    {
        private IApiFactory _factory;

        [OneTimeSetUp]
        public void SetUp()
        {
            _factory = IntegrationTestApiFactoryBuilder.CreateApiFactory("secrets.json");
        }

        [Test]
        public void Create_ApplicationMetadataApi()
        {
            var api = _factory.Api<ApplicationMetadataApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<ApplicationMetadataApi>());
        }

        [Test]
        public void Create_CurrentTableFieldCatalogApi()
        {
            var api = _factory.Api<CurrentTableFieldCatalogApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<CurrentTableFieldCatalogApi>());
        }

        [Test]
        public void Create_HistoricallyExecutedQueriesApi()
        {
            var api = _factory.Api<HistoricallyExecutedQueriesApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<HistoricallyExecutedQueriesApi>());
        }

        [Test]
        public void Create_MultiQueryExecutionApi()
        {
            var api = _factory.Api<MultiQueryExecutionApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<MultiQueryExecutionApi>());
        }

        [Test]
        public void Create_SqlBackgroundExecutionApi()
        {
            var api = _factory.Api<SqlBackgroundExecutionApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<SqlBackgroundExecutionApi>());
        }

        [Test]
        public void Create_SqlExecutionApi()
        {
            var api = _factory.Api<SqlExecutionApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<SqlExecutionApi>());
        }

        [Test]
        public void Api_From_Interface()
        {
            var api = _factory.Api<ISqlExecutionApi>();

            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<SqlExecutionApi>());
        }

        [Test]
        public void Invalid_Requested_Api_Throws()
        {
            Assert.That(() => _factory.Api<InvalidApi>(), Throws.TypeOf<InvalidOperationException>());
        }

        class InvalidApi : IApiAccessor
        {
            public IReadableConfiguration Configuration { get; set; }
            public string GetBasePath()
            {
                throw new NotImplementedException();
            }

            public ExceptionFactory ExceptionFactory { get; set; }
        }
    }
}
