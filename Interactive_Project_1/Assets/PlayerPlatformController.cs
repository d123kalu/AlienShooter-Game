using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerPlatformController : MonoBehaviour {
    public float movementSpeed = 5.0f;
    public float jumpForce = 500.0f;

    private Rigidbody2D rigidBody;
    private bool isGrounded = true;

    private void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float movementX = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump")) {
            rigidBody.AddForce(transform.up * jumpForce);
        }

        transform.Translate(new Vector3(movementX, 0.0f, 0.0f));
    }
}
