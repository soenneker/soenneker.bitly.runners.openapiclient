using Soenneker.Bitly.Runners.OpenApiClient.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Bitly.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class BitlyOpenApiClientRunnerTests : FixturedUnitTest
{
    private readonly IBitlyOpenApiClientRunner _openapirunner;

    public BitlyOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _openapirunner = Resolve<IBitlyOpenApiClientRunner>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
