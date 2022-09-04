namespace ErgoNames.Api.Models;

public class ProcessMintingRequest
{
    /// <summary>
    /// The ID of the transaction that submitted payment to the minting contract
    /// </summary>
    public string PaymentTxId { get; set; }
    
    /// <summary>
    /// The ID of the minting request box
    /// </summary>
    public string MintingRequestBoxId { get; set; }
}