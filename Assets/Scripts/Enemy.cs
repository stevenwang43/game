using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10;
    
    public GameObject player;
    public float speed;
    private float distance;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

void Update()
{
    BoxCollider2D[] colliders = player.GetComponents<BoxCollider2D>();

    if (colliders.Length > 1)
    {
        BoxCollider2D secondCollider = colliders[1];

        distance = Vector2.Distance(transform.position, secondCollider.bounds.center);
        transform.position = Vector2.MoveTowards(transform.position, secondCollider.bounds.center, speed * Time.deltaTime);
    }
}

    public float Health {
        set {
            health = value;
            if (health <= 0) {
                Defeated();
            }
        }
        get {
            return health;
        }
    }

    public void Defeated() {
        Destroy(gameObject);
    }
}
