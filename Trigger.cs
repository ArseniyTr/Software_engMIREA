using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;
    [SerializeField]
    private Projectile projectile;
    [SerializeField]
    private Text healthText;

    private float speed;

    private void Start()
    {
        healthText.text = player.Health.ToString();

        speed = projectile.speed;
    }

    private void OnTriggerEnter()
    {
        player.Health--;
        healthText.text = player.Health.ToString();

        if (player.Health == 0)
        {
            print(player.gameObject.name + " проиграл!");

            EditorApplication.ExitPlaymode();
        }
        else
        {
            projectile.transform.position = new Vector3(-5, -2, 19);
            projectile.forward = -Vector3.up;
            projectile.speed = speed;
        }
    }
}
