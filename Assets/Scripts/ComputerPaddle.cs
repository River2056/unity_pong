using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(0, 0);
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.transform.position.y < this.ball.transform.position.y)
                direction = Vector2.up;
            else if (this.transform.position.y > this.ball.transform.position.y)
                direction = Vector2.down;
        }
        else
        {
            if (this.transform.position.y > 0.0f)
                direction = Vector2.down;
            else if (this.transform.position.y < 0.0f)
                direction = Vector2.up;
        }
        this._rigidbody.AddForce(direction * this.speed);
    }
}
