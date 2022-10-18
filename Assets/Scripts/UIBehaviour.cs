using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timerText;
    int nbHeads = 0;
    // Start is called before the first frame update
    void Start()
    {
        headText = GameObject.Find("lblBob").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
        GameVariables.currentTime = GameVariables.allowedTime;
    }

    public void AddHit(){
        nbHeads++;
        headText.text = "BobHeads: " + nbHeads;
    }
    IEnumerator TimerTick() {
        timerText.text = "Time: " + GameVariables.currentTime.ToString();
        while (GameVariables.currentTime > 0) {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time: " + GameVariables.currentTime.ToString();
        }
        // game over
        SceneManager.LoadScene("Level1BobHeads"); // le nom de votre scene
    }
}
