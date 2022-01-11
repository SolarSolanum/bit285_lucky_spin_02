using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        // : Receive a LuckyNumber object as a parameter called "Lucky" from DIJ
        // : Modify the Index Action to return Lucky.Output as the Content


        public IActionResult Index(LuckyNumber Lucky, int luck)
        {
            //: Receive the Routing id as a parameter called "luck"
            //TODO: Set LuckyNumber object's Luck property to the value of "luck" before returning the ContentResult
            Lucky.Luck.Equals(luck);
            return new ContentResult { Content = Lucky.Output, ContentType = "text/html" };
        }
    }
}
