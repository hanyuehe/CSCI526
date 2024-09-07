using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 positionChange;
    private bool movingLeft;
    void Start()
    {
        movingLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingLeft == true) {
            transform.position -= positionChange;
            if (transform.position.x <= -4) movingLeft = false;
        } else {
            transform.position += positionChange;
            if (transform.position.x >= + 4) movingLeft = true;
        }
        
    }
}
