using UnityEngine;

[System.Serializable]
public class Soldier
{
    public int exp;
    public int lv;

    /// <summary>
    /// 設定經驗值，計算經驗值為：等級 乘 10上
    /// </summary>
    /// <returns>傳回計算後的經驗值</returns>
    public int GetExp()
    {
        exp = lv * 10;
        return exp;
    }

    /// <summary>
    /// 設定經驗值
    /// </summary>
    /// <returns name="getEx[">取得的經驗值</returns>
    public void SetExp(int getExp)
    {
        exp = getExp;
    }
}
