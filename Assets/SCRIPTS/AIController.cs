using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    private NavMeshAgent agent;
    public Camera cam;
    private AudioSource start;
    private AudioSource stop;
    public Light[] front;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        start = GetComponent<AudioSource>();
        stop = gameObject.transform.GetChild(9).GetComponent<AudioSource>();
        foreach (Light i in front)
        {
                i.enabled = false;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                foreach(Light i in front)
                {
                    if(i.enabled == false) 
                        i.enabled = true;
                }
                stop.Pause();
                start.Play();
                Debug.Log("start");
                agent.SetDestination(hit.point);
                Debug.Log(hit.collider.gameObject);
                if (agent.remainingDistance == 0)
                {
                    foreach (Light i in front)
                    {
                        if (i.enabled == true)
                            i.enabled = false;
                    }
                    start.Pause();
                    stop.Play(); 
                    Debug.Log("stop");
                }
            }
        }
    }
}
