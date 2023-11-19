using Models.Gateway.Constants;
using Models.Gateway.Requests.BaseRequestModels;

namespace Models.Gateway.Requests.Calculator
{
    public class GetCalculatorAdditionaRequest : IPostDataRequest<CalculatorAdditionRequest>
    {
        public string RequestPath { get; } = CalculatorRequestConstants.getCalculatorAdditionPath;
        public CalculatorAdditionRequest RequestData {  get; set; } 
    }
}
