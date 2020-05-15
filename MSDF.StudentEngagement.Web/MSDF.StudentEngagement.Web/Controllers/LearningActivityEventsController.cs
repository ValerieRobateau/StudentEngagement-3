﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MSDF.StudentEngagement.Resources.Services.Encryption;
using MSDF.StudentEngagement.Resources.Services.LearningActivityEvents;

namespace MSDF.StudentEngagement.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LearningActivityEventsController : ControllerBase
    {
        private readonly ILogger<LearningActivityEventsController> _logger;
        private readonly IEncryptionService _encryptionService;
        private readonly IConfiguration _configuration;
        private readonly ILearningActivityEventsService _learningActivityEventsService;

        public LearningActivityEventsController(ILogger<LearningActivityEventsController> logger
            , ILearningActivityEventsService learningActivityEventsService
            , IEncryptionService encryptionService
            , IConfiguration configuration)
        {
            this._logger = logger;
            this._encryptionService = encryptionService;
            this._configuration = configuration;
            this._learningActivityEventsService = learningActivityEventsService;
        }

        [HttpGet]
        public async Task<ActionResult> Get() { return Ok("Here"); }

        [HttpGet]
        public async Task<ActionResult> GetById(int id) { return Ok("Resource"); }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]EncryptionModel encryptionModel)
        {
            //TODO: Validate encryptedPayload by trying to decrypt payload into final request model.
            var decryptedData = _encryptionService.Decrypt(encryptionModel, _configuration["encryptionExportedKey"]);
            if (decryptedData == null)
            {
                return BadRequest("Invalid string");
            }
            IList<LearningActivityEventModel> learningActivityEventModelsList = 
                Newtonsoft.Json.JsonConvert.DeserializeObject<IList<LearningActivityEventModel>>(decryptedData);

            var model = new LearningActivityEventModel {
                IdentityElectronicMailAddress = "doug@gmail.com",
                LeaningAppUrl = "https://www.learningapp.com/",
                UTCStartDateTime = DateTime.Now,
                UTCEndDateTime = DateTime.Now.AddSeconds(20)
            };
            // Save to log.
            await _learningActivityEventsService.SaveLearningActivityEventAsync(model);

            return NoContent();
            //return CreatedAtAction(nameof(GetById), new { id = product.Id }, product); ;
        }

    }
}
