using UnityEngine;

public class Controls : MonoBehaviour
{
    public float gravity = 20.0f;
    public float jumpSpeed = 20.5f;
    public Vector3 moveDirection = Vector3.zero;
    public float speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController characterController = GetComponent<CharacterController>();

        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") + 3, 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpSpeed;
            }
        }
        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
