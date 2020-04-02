using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddMOneyText : MonoBehaviour {

	void Update () {
        GetComponent<Text>().text = "Money per click:" + Camera.main.GetComponent<Money>().currentAddMoney;
    }
}
