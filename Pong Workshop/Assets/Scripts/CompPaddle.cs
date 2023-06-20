using UnityEngine;

public class CompPaddle : Paddle
{
    public Rigidbody2D ball;
   private void FixedUpdate() 
   {
        if(ball.velocity.x > 0f) //ball is moving towards computer paddle
        {

            if(ball.position.y > rb.position.y)
            {
               rb.AddForce(Vector2.up * speed);
            }
        
            else if(ball.position.y < rb.position.y)
            {
             rb.AddForce(Vector2.down * speed);
            }
        }
            else
            {
            if(rb.position.y > 0f)
            {
                rb.AddForce(Vector2.down * speed);
            }
            else if (rb.position.y < 0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
   }
}
