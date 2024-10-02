using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;

    // Character movement speed
    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component from the character
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the "W" key is pressed to move forward
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        // Move left with the "A" key
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        // Move right with the "D" key
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        // Move backward with the "S" key
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        // "J" key for punching
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("Punch"); // Trigger punch animation
        }

        // "K" key for kicking
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("Kick"); // Trigger kick animation
        }
    }
}
