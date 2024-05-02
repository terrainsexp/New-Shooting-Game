using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{

    public float speedRotatorX;
    public float speedRotatorY;
    public float speedRotatorZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(speedRotatorY * Time.deltaTime, speedRotatorX * Time.deltaTime, speedRotatorZ * Time.deltaTime);
    }
}
