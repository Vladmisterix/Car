using Unity.VisualScripting;
using UnityEngine;

public class MovementCar : MonoBehaviour
{
    public float speed = 10f;
    public float RotateSpeed = 15f;

    private Rigidbody rb;

    public Light lightFrontRight;
    public Light lightFrontLeft;
    public Light lightBackRight;
    public Light lightBackLeft;

    private AudioSource start;
    private AudioSource stop;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        start = GetComponent<AudioSource>();
        stop = gameObject.transform.GetChild(9).GetComponent<AudioSource>();
    }
    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");
        rb.MovePosition(transform.position + transform.TransformDirection(new Vector3(0f,0f, speed * verMove)) * Time.fixedDeltaTime);
        transform.Rotate(Vector3.up * RotateSpeed * horMove * Time.fixedDeltaTime);
        if (verMove > 0 && start.isPlaying == false)
        {
            stop.Pause();
            start.Play();
        }
        else if(verMove < 0 && stop.isPlaying == false)
        {
            start.Pause();
            
            stop.Play();
        }
        else if(verMove == 0)
        {
            start.Pause();
            stop.Pause();
        }  
        if (verMove < 0)
        {
            LightOn();
        }
        else
        {
            LightOff();
        }
    }
    private bool LightOn()
    {
        lightFrontRight.enabled = false;
        lightFrontLeft.enabled = false;
        lightBackRight.enabled = true;
        lightBackLeft.enabled = true;
        return true;
    }
    private bool LightOff()
    {
        lightFrontRight.enabled = true;
        lightFrontLeft.enabled = true;
        lightBackRight.enabled = false;
        lightBackLeft.enabled = false;
        return false;
    }
}
