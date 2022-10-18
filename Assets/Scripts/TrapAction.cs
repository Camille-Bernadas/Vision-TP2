using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAction : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            Rigidbody otherRb= other.GetComponent<Rigidbody>();
            otherRb.velocity = Vector3.zero;
            otherRb.angularVelocity = Vector3.zero;
            otherRb.AddForce((other.transform.forward+Vector3.down) * -20f, ForceMode.Impulse);
        }
    
    }
}
