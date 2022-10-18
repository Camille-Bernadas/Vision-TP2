using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    Transform player;
    void Start(){
        player = GameObject.FindGameObjectsWithTag("Player")[0].transform;
    }
    void Update(){
        if((player.position-transform.position).sqrMagnitude < 9f){
            int i = SceneManager.GetActiveScene().buildIndex;
            i++;
            if(i >= SceneManager.sceneCountInBuildSettings){
                i = 0;
            }
            SceneManager.LoadScene(i);
        }
        
    }
}
