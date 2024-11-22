namespace VerifyRepro;

public partial class UnitTest1
{
  [Fact]
  public Task Test2_WhenThat_ExpectsThis() => Verify(new { Name = "Clément", Age = 22 });
}
