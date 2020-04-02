<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddMOneyText : MonoBehaviour {

	void Update () {
        GetComponent<Text>().text = "Money per click:" + Camera.main.GetComponent<Money>().currentAddMoney;
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddMOneyText : MonoBehaviour {

	void Update () {
        GetComponent<Text>().text = "Money per click:" + Camera.main.GetComponent<Money>().currentAddMoney;
    }
}
>>>>>>> 1d0af6a8f2cf66ed03cfd9c0061dafcb5cdec704
