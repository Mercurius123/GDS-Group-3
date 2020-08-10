using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCollider : MonoBehaviour
{
    public Text myText;
    private Camera myCamera;
    
    void Start()
    {
        myCamera = GetComponent<Camera>();
    }

    
    void Update()
    {
        Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit other;

        if (Physics.Raycast(ray, out other))
        {
            myText.text = other.collider.name;
        }
        else
        {
            myText.text = "Uncollider";
        }
    }
}
