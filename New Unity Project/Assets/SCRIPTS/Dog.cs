using UnityEngine;

public class Dog
{
    #region 欄位
    public string name;
    public float Weight;
    public string type;
    public string sex;
    public string color;
    public string age;
    #endregion


    #region 方法
    public void Bark()
    {
        Debug.Log(name + "：汪汪!!!");
    }
    #endregion

}