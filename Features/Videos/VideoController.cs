using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreJavaScriptServicesGettingStarted.Features.Videos
{
    [Route("api/[controller]")]
    public class VideoController: Controller
    {
        [HttpGet]
        [Route("get")]
        public IEnumerable<dynamic> Get()
        {
            return new dynamic[] { new {
                YouTubeVideoId = "id"
            } };
        }
    }
}
