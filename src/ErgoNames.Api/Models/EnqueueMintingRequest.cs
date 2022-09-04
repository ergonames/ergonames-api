namespace ErgoNames.Api.Models;

public class EnqueueMintingRequest
{
    /// <summary>
    /// The ID of the transaction that submitted payment to the minting contract
    /// </summary>
    public int PaymentTxId { get; set; }
    
    /// <summary>
    /// The ID of the minting request box
    /// </summary>
    public int MintingRequestBoxId { get; set; }
}