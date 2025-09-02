using UnityEditor;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public float givenSpeed;
    public float horizontalSpeed;
    private float horizontalDir;
    private Rigidbody2D rb2D;
    public bool hasStarted = false;
    public bool isDead = false;
    void Start()
    {
        hasStarted = false;
        isDead = false;
        horizontalSpeed = 0f;
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F) == true)
        {
            isDead = false;
            hasStarted = true;
            horizontalSpeed = 30f;
        }
        if (hasStarted == true)
        {
            horizontalDir = Input.GetAxis("Horizontal");
            Vector3 movement = transform.right * horizontalDir * horizontalSpeed;
            rb2D.linearVelocity = new Vector3(movement.x, rb2D.linearVelocity.y, movement.z);
        }
        if (isDead == true)
        {
            transform.position = Vector3.zero;
            hasStarted = false;
            horizontalSpeed = 0f;
        }
    }
    private void OnCollisionEnter2D(Collision2D dead)
    {
        isDead = true;
        hasStarted = false;
    }
}
