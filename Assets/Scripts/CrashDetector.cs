using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float crashDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool effectsPlayed = false;
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && !effectsPlayed){
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            effectsPlayed = true;
            Invoke("ReloadScene", crashDelay);
            
        }
    
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
     }
}
