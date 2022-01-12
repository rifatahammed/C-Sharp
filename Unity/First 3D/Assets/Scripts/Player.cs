using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;

    private int superJumpsRemaining;
    
    // private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true){
            // Debug.Log("Space Key was pressed down");
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate() {

        rigidbodyComponent.velocity = new Vector3(horizontalInput,rigidbodyComponent.velocity.y,0);

        // if(!isGrounded){
        //     return;
        // }
        if(Physics.OverlapSphere(groundCheckTransform.position,0.1f,playerMask).Length==0){
            return;
        }


         if(jumpKeyWasPressed == true){
            // Debug.Log("Space Key was pressed down");
            float jumpPower = 5f;
            if(superJumpsRemaining>0){
                jumpPower *=2;
                superJumpsRemaining--;
            }
            rigidbodyComponent.AddForce(Vector3.up *jumpPower, ForceMode.VelocityChange);

            // If we dont fixed it in false , it will go forever
            jumpKeyWasPressed = false;
        }

        
    }

    // private void OnCollisionEnter() {
    //  isGrounded = true;
    // }

    // private void OnCollisionExit(Collision other) {
    //     isGrounded = false;
    // }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer == 9){
            Destroy(other.gameObject);
            superJumpsRemaining++;
        }
    }
}
