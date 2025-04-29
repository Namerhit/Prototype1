using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    void Start()
    {
        
    } 
    void Update()
    {
      transform.Translate(Vector3.forward*speed*Time.deltaTime*speed*Input.GetAxis("Vertical"));
      transform.Rotate(Vector3.up, Time.deltaTime*turnSpeed*Input.GetAxis("Horizontal"));
    }
}
