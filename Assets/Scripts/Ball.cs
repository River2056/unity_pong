using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }
    
    public void AddStartingForce()
    {
        float x = Random.value > 0.5f ? 1.0f : -1.0f;
        float y = Random.value > 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }
    
    public void ResetPosition()
    {
        this._rigidbody.position = Vector3.zero;
        this._rigidbody.velocity = Vector3.zero;
    }

    public void AddForce(Vector2 force)
    {
        this._rigidbody.AddForce(force);
    }
}
