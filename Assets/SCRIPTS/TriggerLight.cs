using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour
{
    public new Light light;
    private void Start()
    {
        light.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            light.gameObject.SetActive(true);
        }
    }
}
