using Soenneker.Tests.HostedUnit;

namespace Soenneker.Bitly.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class BitlyOpenApiClientRunnerTests : HostedUnitTest
{
    public BitlyOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
