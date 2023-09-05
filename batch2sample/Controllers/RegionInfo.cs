using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace batch2sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionInfoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<RegionInfo> Get()
        {
           
            var regionData = new List<RegionInfo>
    {
        new RegionInfo
        {
            RegionName = "India",
            Country = "India",
            Continent = "Asia",
            Population = "1,366,416,000",
            Capital = "New Delhi",
            Language = "Hindi, English"
        },
        new RegionInfo
        {
            RegionName = "Saudi Arabia",
            Country = "Saudi Arabia",
            Continent = "Asia",
            Population = "34,813,871",
            Capital = "Riyadh",
            Language = "Arabic"
        },
         new RegionInfo
        {
            RegionName = "United States",
            Country = "United States",
            Continent = "North America",
            Population = "331,915,076",
            Capital = "Washington, D.C.",
            Language = "English"
        },
        new RegionInfo
        {
            RegionName = "Canada",
            Country = "Canada",
            Continent = "North America",
            Population = "37,894,799",
            Capital = "Ottawa",
            Language = "English, French"
        },
        new RegionInfo
        {
            RegionName = "United Kingdom",
            Country = "United Kingdom",
            Continent = "Europe",
            Population = "66,488,991",
            Capital = "London",
            Language = "English"
        },
        new RegionInfo
        {
            RegionName = "Australia",
            Country = "Australia",
            Continent = "Australia",
            Population = "25,874,600",
            Capital = "Canberra",
            Language = "English"
        },
        new RegionInfo
        {
            RegionName = "Brazil",
            Country = "Brazil",
            Continent = "South America",
            Population = "213,993,437",
            Capital = "Brasília",
            Language = "Portuguese"
        },
        new RegionInfo
        {
            RegionName = "China",
            Country = "China",
            Continent = "Asia",
            Population = "1,439,323,776",
            Capital = "Beijing",
            Language = "Mandarin"
        },
        new RegionInfo
        {
            RegionName = "Germany",
            Country = "Germany",
            Continent = "Europe",
            Population = "83,190,556",
            Capital = "Berlin",
            Language = "German"
        },
        new RegionInfo
        {
            RegionName = "Japan",
            Country = "Japan",
            Continent = "Asia",
            Population = "126,050,804",
            Capital = "Tokyo",
            Language = "Japanese"
        }

    };

            return regionData;
        }

    }
}