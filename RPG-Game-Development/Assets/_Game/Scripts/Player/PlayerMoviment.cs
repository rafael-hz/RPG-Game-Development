using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoviment : MonoBehaviour
{
    Rigidbody2D rb;

    PlayerController playerController;

    public Vector2 Movement { get; private set; }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = GetComponent<PlayerController>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * Time.deltaTime * playerController.playerStats.baseSpeed);
    }

    public void GetPlayerMoviment(InputAction.CallbackContext value)
    {
        Movement = value.ReadValue<Vector2>();
    }
}
