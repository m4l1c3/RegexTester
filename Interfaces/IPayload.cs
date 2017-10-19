using System.Collections.Generic;

namespace RegexTester.Interfaces
{
  public interface IPayload
  {
    IList<string> Payloads { get; set; }
  }
}
