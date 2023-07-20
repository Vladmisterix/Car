using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public WheelCollider[] wheel_col;
    public Transform[] wheels;
    float torgue = 100;
    float angle = 45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i = 0; i < wheel_col.Length; i++)
        {
            wheel_col[i].motorTorque = Input.GetAxis("Vertical") * torgue;
            if (i == 0 || i == 1)
            {
                wheel_col[i].steerAngle = Input.GetAxis("Horizontal") * angle;
            }
            var pos = transform.position;
            var rot = transform.rotation;
            wheel_col[i].GetWorldPose(out pos, out rot);
            wheels[i].position = pos;
            wheels[i].rotation = rot;
        }
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var i in wheel_col)
                    i.brakeTorque = 1000;
            }
            else
            {
                foreach (var i in wheel_col)
                    i.brakeTorque = 0;
            }
        }
    }
}
