using Microsoft.AspNetCore.Mvc;

namespace ErgoNames.Api.Controllers;

[Route("api/[controller]")]
public class ValidationController : ControllerBase
{

    public ValidationController()
    {
    }

    /// <summary>
    /// Checks if we have already minted the given ergo name
    /// </summary>
    [HttpGet("isAvailable")]
    public async Task<bool> IsAvailable([FromQuery]string ergoName)
    {
        // TODO: Check underlying data store to see if this ergo name has already been minted
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks if the given ergo name is in line to be minted
    /// </summary>
    [HttpGet("isReserved")]
    public async Task<bool> IsReserved([FromQuery]string ergoName)
    {
        // TODO: Check underlying data store to see if this ergo name has been added to the reservation list
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks if the given ergo name passes our validation rules 
    /// </summary>
    [HttpGet("isValid")]
    public async Task<bool> IsValid([FromQuery]string ergoName)
    {
        // TODO: Check if this ergo name passes our validation rules
        // TODO: Define validation rules🙃
        throw new NotImplementedException();
    }
}