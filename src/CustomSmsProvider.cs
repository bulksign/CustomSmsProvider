﻿using System;
using System.Collections.Generic;
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

				Log(LogLevel.Info, null, $"Started sending SMS using provider {ProviderName} ");

				//add code to send sms using the provider/gateway you want 



				//successful result
				return new SMSResult()
				{
					Identifier = Guid.NewGuid().ToString(),
					ErrorMessage = string.Empty,
					IsSuccess = true
				};

			}
			catch (Exception ex)
			{
				//failed
				return new SMSResult()
				{
					Identifier = string.Empty,
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

		public string ProviderName => "CustomSmsProvider";
	}
}