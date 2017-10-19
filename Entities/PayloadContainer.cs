using RegexTester.Interfaces;
using RegexTester.Enum;
using System.Collections.Generic;

namespace RegexTester.Entities
{
    public class PayloadContainer : IPayloadContainer
    {
        public IDictionary<TypesToValidate, IList<IPayload>> Payloads {get;set;}
    }
}