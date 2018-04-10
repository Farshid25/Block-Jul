//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Diagnostics;
//using System.Net;
//using System.Net.Http;

//namespace TheJulius.Controllers {
//    [Produces("application/json")]
//    [Route("api/Upload")]
//    public class UploadController : Controller {

//        public async Task<HttpResponseMessage> PostFormData() {
//            // Check if the request contains multipart/form-data.
//            if (!Request.ContentType.IsMimeMultipartContent()) {
//                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
//            }

//            string root = HttpContext.Current.Server.MapPath("~/App_Data");
//            var provider = new MultipartFormDataStreamProvider(root);

//            try {
//                // Read the form data.
//                await Request.Content.ReadAsMultipartAsync(provider);

//                // This illustrates how to get the file names.
//                foreach (MultipartFileData file in provider.FileData) {
//                    Trace.WriteLine(file.Headers.ContentDisposition.FileName);
//                    Trace.WriteLine("Server file path: " + file.LocalFileName);
//                }
//                return Request.CreateResponse(HttpStatusCode.OK);
//            }
//            catch (System.Exception e) {
//                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
//            }
//        }
//    }
//}