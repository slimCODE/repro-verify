namespace VerifyRepro;

public abstract class BaseTest
{
  [Fact]
  public Task CheckVerify() => VerifyChecks.Run();

  public Task DoSomethingAndVerify<T>(T item)
  {
    // Some other checks...
    return Verify(item);
  }
}
