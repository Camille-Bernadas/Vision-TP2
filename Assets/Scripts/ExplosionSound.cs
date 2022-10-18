using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource aus = GetComponent<AudioSource>();
        if (aus) {
            aus.Play();
        }
        Destroy(gameObject, 3f);
    }
}
