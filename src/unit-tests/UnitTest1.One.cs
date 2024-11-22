namespace VerifyRepro;

public partial class UnitTest1
{
  [Fact]
  public Task Test1_WhenThis_ExpectsThat() => Verify(new { Name = "Martin", Age = 53 });
}
