using SevenDigital.Api.Wrapper.Http;
using SevenDigital.Api.Wrapper.Requests;
using SevenDigital.Api.Wrapper.Responses;

namespace SevenDigital.Api.Wrapper.Unit.Tests.Http
{
	public class FakeHttpClient : IHttpClient
	{
		private readonly Response _fakeResponse;

		public FakeHttpClient()
		{
		}

		public FakeHttpClient(Response fakeResponse)
		{
			_fakeResponse = fakeResponse;
		}

		public Response Send(Request request)
		{
			SendCount++;
			return _fakeResponse;
		}

		public int SendCount { get; set; }
	}
}