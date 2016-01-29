using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XomorodNews.Core;
using DB = XomorodNews.Models.DatabaseConnectionProvider;

namespace XomorodNews.Controllers
{
    public class NewsController : ApiController
    {
        public static int MaxCount = 20;

        //// GET api/news
        //public async Task<IHttpActionResult> Get()
        //{
        //    var portfolios = new List<object>();

        //    await Task.Run(() =>
        //    {
        //        var news = DB.Connection.RssFeeds.OrderByDescending(x => x.PublishDate).ThenByDescending(x => x.Score);
        //        Random rand = new Random();

        //        foreach (var feed in news)
        //        {
        //            dynamic portfolio = new ExpandoObject();

        //            portfolio.ID = feed.ID;
        //            portfolio.Cls = Hover.IHoverModels[rand.Next(0, Hover.IHoverModels.Count)];
        //            portfolio.Url = $@"news.aspx?rss={feed.ID}";
        //            portfolio.ThumbnailUrl = feed.ThumbnailUrl;
        //            portfolio.Category = $"{feed.RssResource.RssCategory.Name}";
        //            portfolio.Title = feed.Title;
        //            portfolio.Author = feed.Author;
        //            portfolio.PublishDate = feed.PublishDate?.ConvertToWebDiffDateTime(CultureInfo.GetCultureInfo("en"));
        //            portfolio.Description = feed.Description;
        //            portfolio.VisitCount = ((double)feed.Score).ConvertToWebFloating();

        //            portfolios.Add(portfolio);
        //        }
        //    });

        //    return Ok(portfolios);
        //}

        //// GET api/news/id
        //[Route("api/News/{id}")]
        //public IHttpActionResult Get(long id)
        //{
        //    var portfolios = new List<object>();

        //    var feed = DB.Connection.RssFeeds.FirstOrDefault(x => x.ID == id);

        //    if (feed == null)
        //    { return BadRequest("The ID is not e"); }

        //    Random rand = new Random();


        //    dynamic portfolio = new ExpandoObject();

        //    portfolio.ID = feed.ID;
        //    portfolio.Cls = Hover.IHoverModels[rand.Next(0, Hover.IHoverModels.Count)];
        //    portfolio.Url = $@"news.aspx?rss={feed.ID}";
        //    portfolio.ThumbnailUrl = feed.ThumbnailUrl;
        //    portfolio.Category = $"{feed.RssResource.RssCategory.Name}";
        //    portfolio.Title = feed.Title;
        //    portfolio.Author = feed.Author;
        //    portfolio.PublishDate = feed.PublishDate?.ConvertToWebDiffDateTime(CultureInfo.GetCultureInfo("en"));
        //    portfolio.Description = feed.Description;
        //    portfolio.VisitCount = ((double)feed.Score).ConvertToWebFloating();

        //    portfolios.Add(portfolio);


        //    return Ok(portfolios);
        //}

        //// GET domain/api/news/[category]/?lang=en
        //[Route("api/News/{category}")]
        //public IHttpActionResult Get(string category, string lang)
        //{

        //    return Ok(new { category, lang });
        //}

        //// GET domain/api/news/Category
        //[Route("api/News/Categories")]
        //public IHttpActionResult GetCategories()
        //{
        //    var categories = DB.Connection.RssCategories.Where(x => x.IsActive).Select(x => new { x.CategoryID, x.Name, x.PersianName, x.Order, x.IsActive });

        //    return Ok(categories);
        //}


        public IHttpActionResult Get()
        {
            var queryParams = this.Request.GetQueryStrings();

            var local = queryParams["lang"] ?? "en";
            var category = queryParams["category"] ?? "all";

            return Ok("");
        }

        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}