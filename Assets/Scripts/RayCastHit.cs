using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastHit : MonoBehaviour {

    public GameObject pelota;
    Rigidbody m_Rigidbody;
    float m_Speed;
    void Start()
    {

        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
    }

    void update()
    {

        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "End")
            {
                pelota.transform.Translate(Vector3.forward * Time.deltaTime* m_Speed);
                Debug.Log("Tocado");
            }
        }
    }
}

 
 
    