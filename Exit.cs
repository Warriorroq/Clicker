<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> 1d0af6a8f2cf66ed03cfd9c0061dafcb5cdec704
