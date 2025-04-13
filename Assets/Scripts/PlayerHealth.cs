using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float iframeDuration = 1f;
    public bool isInvincible = false;
    public float cooldown = 0f;

    void Update()
    {
        if (isInvincible)
        {
            cooldown -= Time.deltaTime;
            if (cooldown <= 0f)
            {
                isInvincible = false;
            }
        }
    }

    public void TakeDamage(float damage)
    {
        if (!isInvincible)
        {
            health -= damage;
            Debug.Log($"Player health: {health}");

            if (health <= 0)
            {
                Defeated();
            }
            else
            {
                isInvincible = true;
                cooldown = iframeDuration;
            }
        }
    }
    private void Defeated()
    {
        Debug.Log("L");
        Destroy(gameObject);
    }
}
