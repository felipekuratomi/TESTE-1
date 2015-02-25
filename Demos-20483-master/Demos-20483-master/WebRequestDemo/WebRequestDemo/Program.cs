using System;
using System.IO;
using System.Net;

namespace WebRequestDemo
{
	class Program
	{
		static void Main()
		{
			var request = WebRequest.CreateHttp("http://pazotto.com");
            request.Method = "GET";
            request.ContentType = "Aplication/json";
            request.Accept = "application/json";

            //request.Credentials = new NetworkCredential("ze", "senha");
            request.Credentials = CredentialCache.DefaultCredentials; // Uso interno

			var response = request.GetResponse();
			var responseStream = response.GetResponseStream();
			if (responseStream != null)
			{
				var reader = new StreamReader(responseStream);
				var content = reader.ReadToEnd();
				Console.WriteLine(content);
			}
			Console.Read();
		}
	}
}
