using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoors : MonoBehaviour
{
    private GameObject[] obj;
    public Light front1;
    public Light front2;
    public Light back1;
    public Light back2;
    private void Start()
    {
        obj = GameObject.FindGameObjectsWithTag("Doors");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            front1.gameObject.SetActive(false);
            front2.gameObject.SetActive(false);
            back1.gameObject.SetActive(false);
            back2.gameObject.SetActive(false);
            foreach(GameObject go in obj)
            {
                go.GetComponent<Rigidbody>().AddForce(0f,0f,-150f);
            }
        }
    }
}
