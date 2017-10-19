using RegexTester.Interfaces;
using System.Collections.Generic;

namespace RegexTester.Entities
{
  public class XSSPayload : IPayload
  {
    public string Payload { get; set; }
  }
}
