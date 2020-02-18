using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JB
{
    [EnableCors("*", "*", "*")]

    public class UserController : ApiController
    {
        private UserLogic userLogic = new UserLogic();

        [HttpGet]
        [Route("api/users/{groupNumber}")]
        public HttpResponseMessage GetUsers(int groupNumber)
        {
            try
            {
                List<UserDTO> users = userLogic.GetUsers(groupNumber);
                return Request.CreateResponse(HttpStatusCode.OK, users);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.InternalServerError,
                        ErrorsManager.GetInnerMessage(ex));
            }
        }
    }
}
