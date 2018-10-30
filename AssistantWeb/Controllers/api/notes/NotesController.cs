using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssistantWeb.Controllers.api.notes
{
    public class NotesController : ApiController
    {
        public IHttpActionResult GetNotes()
        {
            return Ok("Test successful");
        }
    }
}
