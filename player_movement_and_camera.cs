using UnityEngine;

public class PlayerMovementAndCamera : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 50f;
    public float groundDrag = 4f;
    public float jumpForce = 10f;
    public float jumpCooldown = 0.25f;
    public float airMultiplier = 0.4f;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerHeight = 2f;
    public LayerMask whatIsGround;

    [Header("Camera Rotation")]
    public float lookSpeedX = 2f; 
    public float lookSpeedY = 2f; 

    private bool grounded;
    private bool readyToJump = true;
    private float horizontalInput, verticalInput;
    private Vector3 moveDirection;

    private Rigidbody rb;

    private float currentMouseX = 0f; 
    private float currentMouseY = 0f;
    private float xRotation = 0f;     

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        
        if (Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            Jump();
        }

        
        currentMouseX = Input.GetAxis("Mouse X") * lookSpeedX;
        currentMouseY = Input.GetAxis("Mouse Y") * lookSpeedY;

        transform.Rotate(Vector3.up * currentMouseX);  

        
        xRotation -= currentMouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        
        DetectObjectInFront();

        
        SpeedControl();
        rb.linearDamping = grounded ? groundDrag : 0;
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        
        moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;
        float currentSpeed = grounded ? moveSpeed : moveSpeed * airMultiplier;

        
        gameObject.transform.position += moveDirection.normalized * currentSpeed * Time.fixedDeltaTime;
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if (flatVel.magnitude > moveSpeed)
        {
            rb.linearVelocity = new Vector3(flatVel.normalized.x * moveSpeed, rb.linearVelocity.y, flatVel.normalized.z * moveSpeed);
        }
    }

    private void Jump()
    {
        readyToJump = false;
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        Invoke(nameof(ResetJump), jumpCooldown);
    }

    private void ResetJump()
    {
        readyToJump = true;
    }

    private void DetectObjectInFront()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward); 
        float raycastDistance = 5f;  
        LayerMask interactableLayer = LayerMask.GetMask("Interactable"); 

        if (Physics.Raycast(ray, out hit, raycastDistance, interactableLayer))
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                
                switch (hit.collider.gameObject.name)
                {
                    case "Button":
                        Debug.Log("Button clicked: " + hit.collider.gameObject.name);
                        break;
                    case "Cameras":
                        Debug.Log("Cameras clicked: " + hit.collider.gameObject.name);
                        break;
                    case "System Infos":
                        Debug.Log("System Infos clicked: " + hit.collider.gameObject.name);
                        break;
                    case "Phone":
                        Debug.Log("Phone clicked: " + hit.collider.gameObject.name);
                        break;
                    case "Open doors":
                        Debug.Log("Open doors clicked: " + hit.collider.gameObject.name);
                        break;
                }
            }
        }
    }
}