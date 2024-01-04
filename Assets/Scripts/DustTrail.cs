using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowParticle;
     void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Level"){
            snowParticle.Play();
        }   
    }
     void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Level"){
            snowParticle.Stop();
        }
    }
}
