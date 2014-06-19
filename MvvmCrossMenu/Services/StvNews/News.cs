using System;
using RestSharp.Portable;

namespace StvNews
{
	public class News
	{
		IRestClient restClient;

		public News ()
		{
			restClient = new RestClient("http://news.stv.tv");
		}

		public List<Article> GetNews(string category = ""){
			RestRequest restRequest = new RestRequest("/{category}?format=rss");
			restRequest.Parameters = new List<Parameter>(){
				new Parameter(){
					Name = "",
					Value = "",
					ParameterType = ParameterType.UrlSegment
				}
			};
		}
	}
}

