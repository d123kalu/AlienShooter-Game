using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController2D))]
public class PlayerInput : MonoBehaviour {
    public float runSpeed = 40f;

    private CharacterController2D controller;
    private Animator animator;

    private float horizontalMove = 0f;
    private bool jumping = false;
    private bool shooting = false;

    void Start() {
        controller = GetComponent<CharacterController2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")) {
            jumping = true;
        }

        animator.SetFloat("Speed", controller.speed);
        animator.SetBool("Jumping", !controller.isGrounded);


    }

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jumping);
        jumping = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
}
