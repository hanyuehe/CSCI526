using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed = 200.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

    }
}
