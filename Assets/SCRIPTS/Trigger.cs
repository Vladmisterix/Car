using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Trigger : MonoBehaviour
{
    private GameObject[] obj;
    private void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Effects");
        foreach(GameObject go in obj)
        {
            go.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach(GameObject go in obj)
        {
            go.SetActive(true);
        }
        }
    }

}
