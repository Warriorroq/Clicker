using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyText : MonoBehaviour {

	void Update () {
        GetComponent<Text>().text = "Money:" + Camera.main.GetComponent<Money>().money;		
	}
}
