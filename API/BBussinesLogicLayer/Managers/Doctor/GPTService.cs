using OpenAI_API.Chat;
using OpenAI_API.Models;
using System.Threading.Tasks;

namespace SaleemGPT_Trial
{
    public class GPTService
    {
        public Conversation Chat { get; private set; }

        public GPTService()
        {
            InitializeAsync().GetAwaiter().GetResult();
        }

        private async Task InitializeAsync()
        {
            OpenAI_API.APIAuthentication.Default = new OpenAI_API.APIAuthentication("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");
            var api = new OpenAI_API.OpenAIAPI();

            Chat = api.Chat.CreateConversation(new ChatRequest()
            {
                Model = Model.ChatGPTTurbo,
                Temperature = 0.1,
                TopP = 0.1,
                MaxTokens = 256,
            });

            Chat.AppendSystemMessage("You are a doctor assistant who only responds to medical questions and your name is Saleem. All users are doctors. You should help the user identify issues. You will be provided with the past patient's issues. Based on these issues, you should help the doctor know what. Respond with technical answers since the user is a professional doctor");

            Console.WriteLine("service used");

            //await GetData();

            //await FindFile();


        }



        public async Task GetData()
        {
            var api = new OpenAI_API.OpenAIAPI();
            var response = await api.Files.UploadFileAsync("fine-tuning-data.jsonl");
            Thread.Sleep(10000);
            Console.WriteLine("Data received");
        }


        public async Task FindFile()
        {
            var api = new OpenAI_API.OpenAIAPI();
            var response = await api.Files.GetFilesAsync();
            foreach (var file in response)
            {
                string id = file.Id;
                if (file.Name == "fine-tuning-data.jsonl")
                {
                    var fileContent = await api.Files.GetFileContentAsStringAsync(id);
                    Console.WriteLine(fileContent);
                }
            }
        }

    }
}
