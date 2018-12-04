using Alexa.NET.Request;
using Alexa.NET.Response;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AskPoppaSkill
{
    public class Function
    {

        public SkillResponse FunctionHandler(SkillRequest request)
        {
            return new SkillResponse()
            {
                Version = "0.1.0",
                Response = new ResponseBody()
                {
                    OutputSpeech = new PlainTextOutputSpeech()
                    {
                        Text = "N�"
                    }
                }
            };
        }
    }
}
