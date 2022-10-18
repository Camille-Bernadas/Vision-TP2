using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobBehaviour : MonoBehaviour
{
    public GameObject fx;
    public GameObject worldObject;

    void OnEnable() {
        worldObject = GameObject.Find("World");
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            worldObject.SendMessage("AddHit");
            Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
