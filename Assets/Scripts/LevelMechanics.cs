using UnityEngine;

public class LevelMechanics : MonoBehaviour
{
    public Movements Dead;
    public Movements Started;
    private float levelVel;
    private Rigidbody2D levelrb2D;
    public Vector3 startPosition;
    void Start()
    {
        levelVel = 0;
        levelrb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Started.hasStarted == true)
        {
            levelVel = 10f;
            levelrb2D.linearVelocity = new Vector3(levelrb2D.linearVelocity.x, levelVel);
        }
        if (Dead.isDead == true)
        {
            levelVel = 0f;
            transform.position = startPosition;
        }
    }
}
