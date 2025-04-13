using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Rigidbody2D rb;    
    Vector2 diff;
    Vector2 playerpos = Vector2.zero; //make this the actual player position later
    public Camera cam;
    Vector2 mousePos;
    public float angle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.MovePosition(playerpos);
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        diff=mousePos-playerpos;
        angle = Mathf.Atan2(diff.y,diff.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + diff*moveSpeed*Time.deltaTime);
    }
}
