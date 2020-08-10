using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRaycasting : MonoBehaviour
{
    private float length = 3;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        bool rayIntersectsSomething = Physics.Raycast(transform.position, -transform.up, length);

        Debug.DrawRay(transform.position, -length * transform.up, Color.black);

        Debug.DrawRay(transform.position, length * transform.up, Color.red);

        Debug.DrawRay(transform.position, length * transform.right + transform.up + transform.forward.normalized, Color.blue);

        Debug.DrawRay(transform.position, -length * transform.right + transform.up + transform.forward.normalized, Color.yellow);

        Debug.DrawRay(transform.position, --length * transform.right + transform.up + transform.forward.normalized, Color.green);

        

        if (rayIntersectsSomething)
        {
            Destroy(GetComponent<Rigidbody>());
        }
    }
}
