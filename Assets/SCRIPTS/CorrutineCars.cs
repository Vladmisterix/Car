using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutineCars : MonoBehaviour
{
    public GameObject cars;
    private Coroutine spawn;
    static public bool isStarted;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isStarted = true;
        }
    }
    private void Update()
    {
        if (isStarted && spawn == null)
            spawn = StartCoroutine(CreateCars());
        if (Input.GetKey(KeyCode.Q))
            StopCoroutine(spawn);
    }
    IEnumerator CreateCars()
    {
        while (true)
        {
            var a = Instantiate(
                cars,
                new Vector3
                (Random.Range(-10.5f, 20.3f), 0.7f, 208.4f),
                Quaternion.Euler(0f,180f,0f));
            a.gameObject.GetComponent<ConstantForce>().relativeForce = new Vector3(0f, 0f, 13f);
            yield return new WaitForSeconds(2f);
        }
    }
}
