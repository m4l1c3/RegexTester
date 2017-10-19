using RegexTester.Enum;
using System.Collections.Generic;

namespace RegexTester.Interfaces
{
    public interface IPayloadContainer
    {
        IDictionary<TypesToValidate, IList<IPayload>> Payloads {get;set;}
    }
}