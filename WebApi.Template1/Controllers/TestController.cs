using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApi.Template1.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()    
        {
            //var file = System.Web.Hosting.HostingEnvironment.MapPath("~/a.mp4");
            //var arr = File.ReadAllBytes(file);
            //return Ok(arr);

            var path = System.Web.Hosting.HostingEnvironment.MapPath("~/a.mp4");
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType =
                new MediaTypeHeaderValue("application/octet-stream");
            return result;
        }
    }
}
