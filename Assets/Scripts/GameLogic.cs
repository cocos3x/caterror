using UnityEngine;
public static class GameLogic
{
    // Methods
    public static int CalcStageCoin(int stage)
    {
        return 1;
    }
    public static int CalcResultCoin(int stage)
    {
        return UnityEngine.Mathf.Min(a:  50, b:  5);
    }
    public static int CalcGachaCost(int ownCount)
    {
        ownCount = 30 + ((ownCount * ownCount) * ((ownCount > 4) ? 40 : 30));
        return (int)ownCount;
    }
    public static int GachaAdReward(int adCount, int gachaCount)
    {
        gachaCount = gachaCount - 2;
        int val_1 = System.Math.Max(val1:  1, val2:  gachaCount);
        int val_2 = val_1 * val_1;
        val_2 = val_2 * ((val_1 > 4) ? 40 : 30);
        val_2 = val_2 + (adCount * 20);
        gachaCount = val_2 + 40;
        return System.Math.Min(val1:  44, val2:  gachaCount);
    }

}
