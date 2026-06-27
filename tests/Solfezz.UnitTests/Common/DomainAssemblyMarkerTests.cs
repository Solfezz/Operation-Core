using FluentAssertions;
using Solfezz.Domain.Common;

namespace Solfezz.UnitTests.Common;

public sealed class DomainAssemblyMarkerTests
{
    [Fact]
    public void DomainAssemblyMarker_ShouldBelongToDomainAssembly()
    {
        // Arrange
        var markerType = typeof(DomainAssemblyMarker);

        // Act
        var assemblyName = markerType.Assembly.GetName().Name;

        // Assert
        assemblyName.Should().Be("Solfezz.Domain");
    }
}
