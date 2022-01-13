using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 20f;

    private float HorizantalInput;
    private float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizantalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        //Move car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        transform.Rotate(Vector3.up, turnSpeed *Time.deltaTime * HorizantalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * HorizantalInput);
    }
}
