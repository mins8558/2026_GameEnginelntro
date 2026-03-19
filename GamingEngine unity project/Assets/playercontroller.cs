using UnityEngine;
using UnityEngine.InputSystem;

    // Update is called once per frame
public class PlayerController : MonoBehaviour
{
   public float movespeed = 7f; 
   private Vector2 moveInput;
   public float jumpForce = 7f;
   private Rigidbody2D rb;
   private Animator myAnimator;

     void Start() 
     {
         rb = GetComponent<Rigidbody2D>();
         myAnimator = GetComponent<Animator>();
         myAnimator.SetBool("move", false);
     }
     
     
      public void OnMove(InputValue value)
      {
         moveInput = value.Get<Vector2>();
      }
   

      public void OnJump(InputValue value)
      {
         if(value.isPressed)
         {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
         }
      }
   void Update()
   {
      if(moveInput.x > 0)
      {
         transform.localScale = new Vector3(1, 1, 1);
      }

      else if(moveInput.x < 0)
      {
         transform.localScale = new Vector3(-1, 1, 1);
      }

      if(moveInput.magnitude > 0)  {
          myAnimator.SetBool("move", true);
      }
      else {
         myAnimator.SetBool("move", false);
      }

      transform.Translate(Vector3.right * movespeed * moveInput.x * Time.deltaTime);
   } 
 }


