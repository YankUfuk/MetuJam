using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumppVelocity;
    [SerializeField] private Vector2 velocity;

    private void Update()
    {
        Vector2 pos = transform.position;
        pos.y += velocity.y * UnityEngine.Time.deltaTime;
        velocity.y += TimeController.gravity * UnityEngine.Time.deltaTime;

        if (velocity.y < 1f)
        {
            pos.y = 1;
            velocity.y = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity.y = jumppVelocity * UnityEngine.Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            pos.x += moveSpeed * UnityEngine.Time.deltaTime;
        }
        else
        {
            velocity.x = 0;
        }

        transform.position = pos;
    }
}