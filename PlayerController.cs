using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Tooltip("Очки здоровья игрока")]
    public int Health = 4;
    private static Rigidbody rb;
    [SerializeField]
    private Player player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        player.Move();

        if((player as FirstPlayer) != null)
            (player as FirstPlayer).TakePause();
    }
}
