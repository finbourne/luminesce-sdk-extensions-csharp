using NUnit.Framework;

namespace Finbourne.Luminesce.Sdk.Extensions.IntegrationTests
{
    [TestFixture]
    public class TokenProviderConfigurationTest
    {
        //Test requires [assembly: InternalsVisibleTo("namespace Finbourne.Luminesce.Sdk.Extensions.IntegrationTests")] in ClientCredentialsFlowTokenProvider
        [Test]
        public void Construct_AccessToken_NonNull()
        {
            var config = new TokenProviderConfiguration(new ClientCredentialsFlowTokenProvider(ApiConfigurationBuilder.Build("secrets.json")));
            Assert.IsNotNull(config.AccessToken);
        }
    }
}
