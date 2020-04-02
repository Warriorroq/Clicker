using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Diamond : MonoBehaviour {

    public float Speed;
    public Sprite image;
    void Update () {
        GetComponent<Image>().sprite = image;
        transform.position = new Vector3(transform.position.x,transform.position.y + Time.deltaTime * Speed,transform.position.z);
	}
}
