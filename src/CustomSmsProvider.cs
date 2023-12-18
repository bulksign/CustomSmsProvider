using Bulksign.Extensibility;

namespace CustomSmsProvider
{
	public class MyCustomSmsProvider : ISMSProvider
	{
		public string ProviderName => "CustomSmsProvider";
		
		public SMSResult Send(string text, string phoneNumber)
		{
			try
			{

				Log(LogLevel.Info, null, $"Started sending SMS using provider {ProviderName} ");

				//add code to send sms using the provider/gateway you want 


				//successful result
				return new SMSResult()
				{
					//set the identifier here which is received from the SMS gateway.
					SmsIdentifier = Guid.NewGuid().ToString(),
					ErrorMessage = string.Empty,
					IsSuccess = true
				};

			}
			catch (Exception ex)
			{
				Log(LogLevel.Error, ex);

				//failed
				return new SMSResult()
				{
					SmsIdentifier = string.Empty,
					ErrorMessage = ex.Message,
					IsSuccess = false
				};
			}
		}

		public Dictionary<string, string> Settings
		{
			get;
			set;
		}

	

		public HttpClient HttpClient
		{
			get;
			set;
		}
		
		public IJsonSerializer   JsonSerializer { get; set; }
		public event LogDelegate Log;

	}
}