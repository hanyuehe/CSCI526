using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 40.0f;
    private float turnSpeed = 25.0f;
    private float horizentalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // get user input
        horizentalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if(transform.position.z >= -1){
            // move vehicle forward and back
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
            // mover vehicle right and left
            transform.Rotate(Vector3.up, turnSpeed * horizentalInput * Time.deltaTime);
            // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizentalInput);  
        }
    }
}
