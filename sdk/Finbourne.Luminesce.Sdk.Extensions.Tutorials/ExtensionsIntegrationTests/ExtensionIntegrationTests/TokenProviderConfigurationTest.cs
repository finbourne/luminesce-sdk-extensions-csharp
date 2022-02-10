using NUnit.Framework;

namespace Finbourne.Luminesce.Sdk.Extensions.Tutorials
{
    [TestFixture]
    public class TokenProviderConfigurationTest
    {
        //Test requires [assembly: InternalsVisibleTo("namespace Finbourne.Luminesce.Sdk.Extensions.Tutorials")] in ClientCredentialsFlowTokenProvider
        [Test]
        public void Construct_AccessToken_NonNull()
        {
            var config = new TokenProviderConfiguration(new ClientCredentialsFlowTokenProvider(ApiConfigurationBuilder.Build("secrets.json")));
            Assert.IsNotNull(config.AccessToken);
        }
    }
}
