using Microsoft.AspNetCore.Mvc;
using MySimpleAPI.Controllers;

namespace SimpleAPIUnitTest
{
    public class Tests
    {
        private StatusController _controller;
        [SetUp]
        public void Setup()
        {
            _controller = new StatusController();
        }

        [Test]
        public async Task GetStatusByAPICall_ShouldReturnOk()
        {
            var result = await _controller.GetStatus();

            Assert.IsInstanceOf<OkResult>(result);
        }
    }
}