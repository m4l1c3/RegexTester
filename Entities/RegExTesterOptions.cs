using RegexTester.Enum;
using RegexTester.Interfaces;

namespace RegexTester.Entities
{
  public class RegexTesterOptions
  {
    public TypesToValidate TypesToValidate { get; set; } = TypesToValidate.XSS;
    public IPayload PayloadsToTest { get; set; }
  }
}
