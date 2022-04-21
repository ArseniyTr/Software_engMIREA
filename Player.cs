using UnityEngine;

public abstract class Player : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody rb;
    public Canvas canvas;

    abstract public void Move();
}
