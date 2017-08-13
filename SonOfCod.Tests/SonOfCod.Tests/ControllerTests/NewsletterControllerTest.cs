using Microsoft.AspNetCore.Mvc;
using SonOfCod2.Controllers;
using SonOfCod2.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class NewsletterControllerTest
    {
        private readonly ApplicationDbContext _db;

        [Fact]
        public void Get_ViewResult_Index()
        {
            NewsletterController controller = new NewsletterController(_db);
            IActionResult result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
