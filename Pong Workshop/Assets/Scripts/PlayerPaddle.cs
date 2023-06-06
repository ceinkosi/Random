using UnityEngine;

public class PlayerPadel : Paddle
{
    private Vector2 _direction;
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

   private void FixedUpdate()
   {
        if(_direction.sqrMagnitude != 0)
        {
            rb.AddForce(_direction * this.speed);
        }
   }
}
