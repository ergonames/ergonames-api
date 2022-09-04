using Microsoft.AspNetCore.Mvc;

namespace ErgoNames.Api.Controllers;

[Route("api/[controller]")]
public class PricingController : ControllerBase
{

    public PricingController()
    {
    }

    /// <summary>
    /// Gives price for a given ergo name based on pricing rules
    /// </summary>
    [HttpGet("getPrice")]
    public async Task<long> GetPrice([FromQuery]string ergoName)
    {
        // TODO: Determine price in nanoergs based on character length
        throw new NotImplementedException();
    }
}