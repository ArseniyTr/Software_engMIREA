using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Tooltip("Начальная скорость шарика")]
    public float speed = 4f;
    [Tooltip("Максимальная скорость, которую может развить шарик")]
    public float maxSpeed = 8f;
    [HideInInspector]
    public Vector3 forward = -Vector3.up;

    void Update()
    {
        transform.position += forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        forward = Vector3.Reflect(forward, collision.contacts[0].normal);

        if (speed <= maxSpeed) speed *= 1.2f;

        if(collision.gameObject.layer == 8)
        {
            Destroy(collision.gameObject);
        }
    }
}
