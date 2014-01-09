﻿using System;

namespace SevenDigital.Api.Wrapper.Http
{
	public enum HttpMethod
	{
		Unknown = 0,
		Get,
		Post,
		Put,
		Delete
	}

	public static class HttpMethodHelpers
	{
		public static HttpMethod Parse(string methodName)
		{
			return(HttpMethod)Enum.Parse(typeof (HttpMethod), methodName, true);
		}
	}
}
