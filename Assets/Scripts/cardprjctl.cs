using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 0.01f;
    public Rigidbody2D rb;
    Vector2 diff;
    public GameObject player; //make this the actual player position later
    Vector2 playerPos;
    Vector2 mousePos;
    public float angle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPos = player.GetComponents<BoxCollider2D>()[0].bounds.center;
        rb.MovePosition(playerPos);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        diff=mousePos-playerPos;
        angle = Mathf.Atan2(diff.y,diff.x)*Mathf.Rad2Deg-90;
        rb.rotation = angle;
        diff.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + diff*moveSpeed*Time.deltaTime);
    }
}
