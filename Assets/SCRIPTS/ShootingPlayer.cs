using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShootingPlayer : MonoBehaviour
{
    public Camera cam;
    public float range = 100f;
    public ParticleSystem shootEffect;
    public float force = 5f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }   
    }
    void Shoot()
    {
        shootEffect.Play();
        RaycastHit hit;
        Vector3 shootPos = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range)) 
        {
           if(hit.transform.gameObject.CompareTag(""))
            {
                hit.transform.gameObject.GetComponent<TakeDamage>().Damage();
                if(hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(-hit.normal * force);
                }
            }
        }
    }
}
