using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Bitly.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class BitlyOpenApiClientRunnerTests : FixturedUnitTest
{
    public BitlyOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
