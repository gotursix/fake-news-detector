﻿using System;
using EntityFramework;
using EntityFramework.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewsResultController : ControllerBase
    {
        private readonly ILogger<NewsResult> _logger;

        public NewsResultController(ILogger<NewsResult> logger)
        {
            _logger = logger;
        }
        
        [EnableCors]
        [HttpPost]
        public NewsResult Post([FromBody] EntityFramework.Models.UrlModel url)
        {
            WebParser.Website webParser = new WebParser.InfoWarsParser(url.Url);
            //Take the parsed data and use it on MLPrediction
            MLPrediction.MLModel1.ModelInput sampleData = new MLPrediction.MLModel1.ModelInput()
            {
                Title = @webParser.Title,
                Text = @webParser.Content,
                Subject = @webParser.Subject,
                Date = @webParser.Date.ToString(),
            };
            var predictionResult = MLPrediction.MLModel1.Predict(sampleData);
            var result = new NewsResult(){Id = Guid.NewGuid(), Decision = predictionResult.Prediction, SearchDate = webParser.Date, StatisticsId = Guid.NewGuid(), Link = url.Url};
            using var ctx = new AppDbContext();
            ctx.ResultsHistory.Add(result);
            ctx.SaveChanges();
            return result;
        }
    }
}