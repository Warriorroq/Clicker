<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyText : MonoBehaviour {

	void Update () {
        GetComponent<Text>().text = "Money:" + Camera.main.GetComponent<Money>().money;		
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyText : MonoBehaviour {

	void Update () {
        GetComponent<Text>().text = "Money:" + Camera.main.GetComponent<Money>().money;		
	}
}
>>>>>>> 1d0af6a8f2cf66ed03cfd9c0061dafcb5cdec704
