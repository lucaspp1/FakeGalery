using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using galery.model;
using System;

namespace galery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhotoController : ControllerBase
    {
        private readonly ILogger<PhotoController> _logger;

        public PhotoController(ILogger<PhotoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{name}")]
        public IEnumerable<Photo> Get(string name)
        {
            return new List<Photo>() {
                new Photo(
                    id: 1,
                    postDate: new DateTime(),
                    url: "https://i.ytimg.com/vi/a5lxRI_WoK0/maxresdefault.jpg",
                    description: "naruto",
                    allowComments: false,
                    likes: 0,
                    comments: 0,
                    userId: 1
                )
            };
        }
    }
}
