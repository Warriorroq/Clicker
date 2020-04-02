using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
    
    public void EndGame()
    {
        Money mon = Camera.main.GetComponent<Money>();
        PlayerPrefs.SetInt("Gold",mon.money);
        PlayerPrefs.SetInt("Level", mon.currentLevel);
        PlayerPrefs.SetInt("EarnMoney", mon.currentAddMoney);
        Application.Quit();
    }
}
