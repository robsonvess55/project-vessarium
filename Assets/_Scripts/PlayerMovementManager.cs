using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementManager : MonoBehaviour
{
    [SerializeField]
    private float thrustForce;

    [SerializeField]
    private Rigidbody2D rigidbody2D;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.AddForce(Vector2.up * thrustForce);
        }
             if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.AddForce(Vector2.down * thrustForce);
        }
             if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.AddForce(Vector2.left * thrustForce);
        }
             if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.AddForce(Vector2.right * thrustForce);
        }
    }


}
