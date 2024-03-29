﻿using UnityEngine;

[System.Serializable]
public class Dog
{
    #region 欄位
    public string name;
    public float Weight;
    public string type;
    public string color;

    private string sex;
    public int age;
    #endregion

    #region 建構函式
    // 建構函式可以多載
    public Dog()
    {

    }

    public Dog(string sex, int age)
    {
        this.sex = sex;
        this.age = age;
    }
    #endregion
    #region 方法
    public void Bark()
    {
        Debug.Log(name + "：汪汪!!!");
    }

    public int ConvertAge()
    {
        return age * 7;
    }

    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + "：" + food + "，速度：" + speed);
    }



    public void Eat(string food, int count)
    {
        Debug.Log(name + "：" + food + "，份量：" + count);
    }
    #endregion
}