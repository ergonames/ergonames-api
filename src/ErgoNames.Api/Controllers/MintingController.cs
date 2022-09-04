using System.Text.Json;
using Amazon.SQS;
using ErgoNames.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ErgoNames.Api.Controllers;

[Route("api/[controller]")]
public class MintingController : ControllerBase
{
    private readonly IConfiguration config;
    private readonly IAmazonSQS sqsClient;

    public MintingController(IConfiguration config, IAmazonSQS sqsClient)
    {
        this.config = config;
        this.sqsClient = sqsClient;
    }

    /// <summary>
    /// Pushes message with minting request box id to the minting queue
    /// </summary>
    [HttpPost("enqueueRequest")]
    public async Task<IActionResult> EnqueueRequest([FromBody]ProcessMintingRequest payload)
    {
        var mintingQueueUrl = config["MintingQueueUrl"];
        var serializerOptions = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        var message = JsonSerializer.Serialize(payload, serializerOptions);

        try
        {
            Console.WriteLine($"Sending message [{message}] to queue [{mintingQueueUrl}]");
            var response = await sqsClient.SendMessageAsync(mintingQueueUrl, message);
            return Ok(new { messageId = response.MessageId });
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}