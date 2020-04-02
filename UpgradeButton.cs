using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeButton : MonoBehaviour {

    Money balance;
    public Text text;
	void Start () {
        balance = Camera.main.GetComponent<Money>();
	}

    void Update () {
        text.text = "Next Update cost:" + balance.levelUpCost[balance.currentLevel + 1];
        if (balance.currentLevel == balance.maxLevel - 1)
            Destroy(this.gameObject);
	}
    public void LevelUp()
    {
        if(balance.money >= balance.levelUpCost[balance.currentLevel + 1] && balance.currentLevel < balance.maxLevel)
        {
            balance.money -= balance.levelUpCost[balance.currentLevel + 1];
            balance.currentLevel++;
            balance.currentAddMoney += balance.currentLevel;
        }
    }
}
