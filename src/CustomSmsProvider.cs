using System;
using Bulksign.Extensibility;

namespace CustomSmsProvider
{
    public class MyCustomSmsProvider : ISMSProvider
    {
        public event LogDelegate Log;

        public SMSResult Send(string text, string phoneNumber)
        {

            try
            {

                //add code to send sms




                //successful result
                return new SMSResult()
                {
                    SMSIdentifier = Guid.NewGuid().ToString(),
                    ErrorMessage = string.Empty,
                    IsSuccess = true
                };

            }
            catch (Exception ex)
            {
                //failed
                return new SMSResult()
                {
                    SMSIdentifier = string.Empty,
                    ErrorMessage = ex.Message,
                    IsSuccess = false
                };

            }

        }

        public string ProviderName => "CustomSmsProvider";
    }
}