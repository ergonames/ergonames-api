using ErgoNames.Api.Models;

namespace ErgoNames.Api.Services;

public interface IPricingService
{
    long GetPrice(string ergoname);
}

public class PricingService : IPricingService
{
    public long GetPrice(string ergoname)
    {
        var rarity = GetRarity(ergoname);

        switch (rarity)
        {
            case ErgoNameRarity.Rare:
                return 5;
            case ErgoNameRarity.Uncommon:
                return 3;
            case ErgoNameRarity.Common:
                return 1;
            default:
                throw new Exception();
        }
    }

    public ErgoNameRarity GetRarity(string ergoname)
    {
        var length = ergoname.Trim().Length;

        if (length >= 1 && length <= 5)
        {
            return ErgoNameRarity.Rare;
        }
        else if (length >= 6 && length <= 12)
        {
            return ErgoNameRarity.Uncommon;
        }
        else if (length >= 13 && length <= 20)
        {
            return ErgoNameRarity.Common;
        }
        else
        {
            throw new Exception("ergoname length out of bounds");
        }
    }
}