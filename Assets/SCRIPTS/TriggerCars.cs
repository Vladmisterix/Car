using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCars : MonoBehaviour
{
    private GameObject[] cars;
    private void Start()
    {
        cars = GameObject.FindGameObjectsWithTag("Other cars");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            foreach(GameObject go in cars)
            {
                ConstantForce constantForce = go.GetComponent<ConstantForce>();
                constantForce.relativeForce = new Vector3(0, 0, 10f);
            }
        }
    }
}
