using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

    public int money;
    public int currentAddMoney;
    public int[] addMoneyPerLevels;
    public int[] levelUpCost;
    public int currentLevel;
    public int maxLevel;
    public void Awake()
    {
        money = PlayerPrefs.GetInt("Gold");
        currentLevel = PlayerPrefs.GetInt("Level");
        currentAddMoney = PlayerPrefs.GetInt("EarnMoney");
    }
    private void Start()
    {
        if (currentAddMoney == 0)
        { currentAddMoney += addMoneyPerLevels[0];}
    }
    void Update () {
        
        maxLevel = levelUpCost.Length-1;
	}
}
