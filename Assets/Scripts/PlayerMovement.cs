using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var rb = FindAnyObjectByType<Rigidbody2D>();
        rb.linearVelocity = (Vector3.left * Input.GetAxis("Horizontal"));
    }
}
