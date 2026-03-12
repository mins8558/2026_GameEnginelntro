using UnityEngine;
using UnityEngine.InputSystem;

    // Update is called once per frame
public class PlayerController : MonoBehaviour
{
   public float movespeed = 7f; 
      private Vector2 moveInput;
      
      public void OnMove(InputValue value)
      {
      moveInput = value.Get<Vector2>();
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
      transform.Translate(Vector3.right * movespeed * moveInput.x * Time.deltaTime);
   } 
 }


