using eCommerce.Model.Domain;
using eCommerce.Model.Responses;
using eCommerce.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eCommerce.Web.Controllers.Api
{
    [RoutePrefix("api/users")]
    public class UserApiController : ApiController
    {
        private UserService _userService;

        public UserApiController()
        {
            _userService = new UserService();
        }

        [Route(), HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                ItemsResponse<Users> resp = new ItemsResponse<Users>();
                resp.items = _userService.SelectAll();
                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}