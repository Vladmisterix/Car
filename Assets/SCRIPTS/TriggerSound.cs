using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            audio3.Stop();
            audio1.Stop();
            audio2.Play();
        }
    }
}
