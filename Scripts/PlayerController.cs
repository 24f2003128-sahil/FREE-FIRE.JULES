using UnityEngine;

/// <summary>
/// A basic player controller script for a 3D character.
/// Handles movement (forward, backward, left, right) and jumping.
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5.0f; // Controls how fast the player walks.
    public float jumpForce = 7.0f; // Controls how high the player jumps.

    private Rigidbody rb;
    private bool isGrounded;

    /// <summary>
    /// This method is called once when the script instance is being loaded.
    /// It's used for initialization.
    /// </summary>
    void Start()
    {
        // Get the Rigidbody component attached to the same GameObject as this script.
        // The Rigidbody is necessary for physics-based movement.
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// This method is called once per frame.
    /// It's used for handling input and non-physics related updates.
    /// </summary>
    void Update()
    {
        HandleMovementInput();
        HandleJumpInput();
    }

    /// <summary>
    /// Reads keyboard input for horizontal and vertical movement.
    /// </summary>
    private void HandleMovementInput()
    {
        // Get input from the keyboard (W, A, S, D or arrow keys).
        // These axes are pre-configured in Unity's Input Manager.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a direction vector based on the input.
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        // Move the Rigidbody's position. We multiply by Time.deltaTime
        // to make the movement frame-rate independent.
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.deltaTime);
    }

    /// <summary>
    /// Checks for the jump key input.
    /// </summary>
    private void HandleJumpInput()
    {
        // Check if the "Jump" button (default is Space bar) is pressed and if the player is on the ground.
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Apply an upward force to the Rigidbody to make it jump.
            // ForceMode.Impulse applies the force instantly.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // The player is now in the air.
        }
    }

    /// <summary>
    /// This method is called when this collider/rigidbody has begun touching another rigidbody/collider.
    /// </summary>
    /// <param name="collision">The collision data associated with this collision event.</param>
    void OnCollisionEnter(Collision collision)
    {
        // A simple way to check if the player is grounded.
        // For a more robust solution, you might use a Raycast pointing downwards.
        // We assume any object tagged "Ground" is a surface we can jump from.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
