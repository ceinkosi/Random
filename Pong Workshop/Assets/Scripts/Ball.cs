using UnityEngine;

public class Ball : MonoBehaviour
{
   public float BallSpeed;
   public Rigidbody2D ballRB;

     private void Awake() 
    {
        ballRB = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        ballRB.velocity = Vector2.zero;
        ballRB.position = Vector2.zero;
    }

    public void StartForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range (-1, -0.5f) : Random.Range(1f, 0.5f);

        Vector2 direction = new Vector2(x, y);
        ballRB.AddForce(direction * BallSpeed);

    }
}
