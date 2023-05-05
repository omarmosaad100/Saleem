using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenAI_API.Completions;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Models;
using System.Reflection;

namespace SaleemGPT_Trial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GPTController : ControllerBase
    {
        private readonly Conversation chat;
        public GPTController(GPTService gptService)
        {
            chat = gptService.Chat;

            Console.WriteLine("ctor called");

        }

        //empty end point ..create chat
        [HttpGet]
        [Route("CreateChat")]
        public IActionResult CreateChat()
        {
            Console.WriteLine("chat created");

            return Ok();
        }

        [HttpGet]
        [Route("StartNewChat")]
        public IActionResult StartNewChat(string pid, [FromQuery] List<string> issues)
        {

            string issuesString = string.Join(", ", issues);
            chat.AppendUserInput($"patient {pid} has {issuesString}");


            Console.WriteLine("chat created");

            return Ok();
        }



        [HttpGet]
        [Route("GetAllChat")]
        public IActionResult GetAllChat()
        {

            var results = chat.Messages.ToList();    //loop over it, skip first two, get each message object .content.. if even number dark color, else light .. then everytime skip 1

            return Ok(results);
        }

        [HttpGet]
        public IActionResult SaleemGPT([FromQuery] string query)
        {
            chat.AppendUserInput(query);

            var results = chat.GetResponseFromChatbotAsync().Result;

            return Ok(results);
        }



    }

}

//https://platform.openai.com/docs/guides/fine-tuning
