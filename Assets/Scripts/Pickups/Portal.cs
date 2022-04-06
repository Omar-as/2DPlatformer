using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform destination;

    public Boolean isRed;

    public GameObject Tp_portal;
    public float distance = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        destination = Tp_portal.transform;
        //if (isRed == false)
        //{
          //  destination = GameObject.FindGameObjectWithTag("Red Portal").GetComponent<Transform>();
        //}
        //else
        //{
          //  destination = GameObject.FindGameObjectWithTag("Yellow Portal").GetComponent<Transform>();
        //}
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (Vector3.Distance(transform.position, other.transform.position) > distance)
            {
                GameObject.Find("Player").transform.position = new Vector3(destination.position.x, destination.position.y);
            }
        }
    }
}
