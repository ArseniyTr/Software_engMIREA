using UnityEngine;

public class FirstPlayer : Player
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector3.forward, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Vector3.right, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right, ForceMode.Force);
        }
    }

    public void TakePause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.enabled)
            {
                canvas.enabled = false;
                Time.timeScale = 1;
            }
            else if (Time.timeScale == 1)
            {
                canvas.enabled = true;
                Time.timeScale = 0;
            }
        }
    }
}
