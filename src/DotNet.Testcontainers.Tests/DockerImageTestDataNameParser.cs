namespace DotNet.Testcontainers.Tests
{
  using DotNet.Testcontainers.Core.Images;
  using Xunit;

  public class DockerImageTestDataNameParser : TheoryData<IDockerImage, string>
  {
    public DockerImageTestDataNameParser()
    {
      this.Add(new TestcontainersImage("foo", "bar", "1.0.0"), "foo/bar:1.0.0");
      this.Add(new TestcontainersImage("foo", "bar", string.Empty), "foo/bar:latest");
      this.Add(new TestcontainersImage(string.Empty, "bar", "1.0.0"), "bar:1.0.0");
      this.Add(new TestcontainersImage(string.Empty, "bar", string.Empty), "bar:latest");
    }
  }
}