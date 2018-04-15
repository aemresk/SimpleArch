using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zandeross.Http.Helpers;

namespace Zandeross.Http.Controllers
{
    public class HomeController : BaseController
    {
        Domain.PersonalDataService DataService = new Domain.PersonalDataService();
        [HttpPost]
        public HttpResponseMessage GetPersonalDataList()
        {
            return Request.CreateResponse(HttpStatusCode.OK,DataService.PersonalGetDataList());  
        }

        [HttpGet]
        public HttpResponseMessage GetPersonalList()
        {
            return Request.CreateResponse(HttpStatusCode.OK, DataService.PersonalGetDataList()); 
        }

    }
}
