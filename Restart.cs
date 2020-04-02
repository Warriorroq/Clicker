using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    public void ReturnToZero()
    {
        PlayerPrefs.SetInt("Gold", 0);
        PlayerPrefs.SetInt("Level",0);
        PlayerPrefs.SetInt("EarnMoney", 0);
        Money money = Camera.main.GetComponent<Money>();
        money.currentLevel = 0;
        money.currentAddMoney = 1;
        money.money = 0;
    }
}
