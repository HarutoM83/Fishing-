using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    PlayerInput playerInput;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var move = playerInput.actions["Move"].ReadValue<Vector2>();

        if (move.x != 0f || move.y !=0f )
        {
            rb.linearVelocity = new Vector3(
            move.x * speed,
            rb.linearVelocity.y,
            move.y * speed
            );
            // Œü‚«
            var rotation = transform.rotation;
            if (move.x < 0)
            {
                rotation.y = 0f;
            }
            else if (move.x > 0)
            {

                rotation.y = -90f;
            }
            else if (move.y < 0)
            {
                rotation.y = 180f;
            }
            else
            {
                rotation.y = 0f;
            }
            transform.rotation = rotation;
        }
    }
}
