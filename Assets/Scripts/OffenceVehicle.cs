using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffenceVehicle : MonoBehaviour
{
    private float _speed = 17f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(_speed*Time.deltaTime*Vector3.forward);

        if (transform.position.y<-2)
        {
            Destroy(gameObject);
        }
    }
}
