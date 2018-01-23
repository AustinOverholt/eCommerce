using eCommerce.Model.Domain;
using eCommerce.Model.Responses;
using eCommerce.Services;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eCommerce.Web.Controllers.Api
{
    [RoutePrefix("api/configuration")]
    public class ConfigurationApiController : ApiController 
    {
        private ConfigurationService _configurationService;

        public ConfigurationApiController()
        {
            _configurationService = new ConfigurationService();
        }

        [Route(), HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                ItemsResponse<Configs> resp = new ItemsResponse<Configs>();
                resp.items = _configurationService.GetConfigString();
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }

    }
}