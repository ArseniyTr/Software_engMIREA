using UnityEngine;

public class Cube : MonoBehaviour
{
    ParticleSystem exhaust;
    void Start()
    {
        transform.rotation = Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
        
    }
}
