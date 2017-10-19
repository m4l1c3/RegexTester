using RegexTester.Interfaces;
using System.Collections.Generic;

namespace RegexTester.Entities
{
  public class XSSPayloads : IPayload
  {
    public IList<string> Payloads { get; set; } = new List<string>();
  }
}
