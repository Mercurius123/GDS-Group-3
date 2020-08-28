using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPickUpSound : MonoBehaviour
{
    public AudioSource playSound;

    
    public void OnCollisionStay(Collision col)
    {
        playSound.Play();
    }
}
