﻿using System.Threading.Tasks;
using PainlessHttp.Http;
using PainlessHttp.Http.Contracts;

namespace PainlessHttp.Client.Contracts
{
	interface IHttpClient
	{
		IHttpResponse<T> Get<T>(string url, object query = null) where T : class;
		Task<IHttpResponse<T>> GetAsync<T>(string url, object query = null) where T : class;
	}
}
