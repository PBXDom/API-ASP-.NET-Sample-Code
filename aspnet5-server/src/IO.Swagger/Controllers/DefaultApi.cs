using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DefaultApiController : Controller
    { 

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets &#x60;Calls&#x60; info. </remarks>
        /// <param name="rptType">Report type. (0 report, 1 widget, 2 chart).</param>
        /// <param name="rptId">Report id.</param>
        /// <param name="start">Start offset.</param>
        /// <param name="limit">Number of results to return. Max 10K.</param>
        /// <param name="sortBy">Sort column.</param>
        /// <param name="sortType">Sort mode asc/desc.</param>
        /// <param name="fromDate">Start date time.</param>
        /// <param name="toDate">End date time.</param>
        /// <param name="duration">Duration range.</param>
        /// <param name="phone">List of caller phone.</param>
        /// <param name="phone1">List of dialled phones.</param>
        /// <param name="co">List of trunk/co.</param>
        /// <param name="ext">list of extensions.</param>
        /// <param name="pbxId">list of PBX Ids.</param>
        /// <param name="callSource">list of callsource.</param>
        /// <param name="callType">list of call type signatures.(5 Unanswered Calls, 7 Transfered Calls, 8 Forwarded Calls)</param>
        /// <param name="direction">list of direction.(0 incoming, 1 outgoing, 2 internal)</param>
        /// <param name="callerName">list of caller name.</param>
        /// <param name="did">list of did.</param>
        /// <param name="dnis">list of dnis.</param>
        /// <param name="acc">list of account code.</param>
        /// <param name="ring">Ring range.Seconds unit.</param>
        /// <param name="cost">Cost range.</param>
        /// <param name="group">Department/Group id.</param>
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("/Calls")]
        [SwaggerOperation("CallsGet")]
        [SwaggerResponse(200, type: typeof(List<InlineResponse200>))]
        public IActionResult CallsGet([FromQuery]double? rptType, [FromQuery]double? rptId, [FromQuery]decimal? start, [FromQuery]decimal? limit, [FromQuery]string sortBy, [FromQuery]string sortType, [FromQuery]string fromDate, [FromQuery]string toDate, [FromQuery]decimal? duration, [FromQuery]string phone, [FromQuery]string phone1, [FromQuery]string co, [FromQuery]string ext, [FromQuery]decimal? pbxId, [FromQuery]decimal? callSource, [FromQuery]decimal? callType, [FromQuery]decimal? direction, [FromQuery]string callerName, [FromQuery]string did, [FromQuery]string dnis, [FromQuery]string acc, [FromQuery]decimal? ring, [FromQuery]decimal? cost, [FromQuery]decimal? group)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InlineResponse200>>(exampleJson)
            : default(List<InlineResponse200>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets &#x60;Charts&#x60; list. </remarks>
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("/Features/charts")]
        [SwaggerOperation("FeaturesChartsGet")]
        [SwaggerResponse(200, type: typeof(List<InlineResponse200>))]
        public IActionResult FeaturesChartsGet()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InlineResponse200>>(exampleJson)
            : default(List<InlineResponse200>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets &#x60;Reports&#x60; list. </remarks>
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("/Features/reports")]
        [SwaggerOperation("FeaturesReportsGet")]
        [SwaggerResponse(200, type: typeof(List<InlineResponse200>))]
        public IActionResult FeaturesReportsGet()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InlineResponse200>>(exampleJson)
            : default(List<InlineResponse200>);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Gets &#x60;Widgets&#x60; list. </remarks>
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("/Features/widget")]
        [SwaggerOperation("FeaturesWidgetGet")]
        [SwaggerResponse(200, type: typeof(List<InlineResponse200>))]
        public IActionResult FeaturesWidgetGet()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InlineResponse200>>(exampleJson)
            : default(List<InlineResponse200>);
            return new ObjectResult(example);
        }
    }
}
