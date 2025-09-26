using System;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float strength = 10f;
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log(transform.position);
        Vector3 a = transform.position;
        Vector3 b = other.transform.position;
        Vector3 direction;
        direction = b - a;
        direction = direction.normalized;
        
        other.rigidbody.AddForce(direction*strength);

    }
}
