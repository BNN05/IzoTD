
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;
    public float startHealth;
    public float health = 150;
    public int worth = 50;
    private Transform target;
    private int wavepointIndex = 0;
    void Start()
    {
        target = Waypoints.points[0];
        health = startHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += worth;
        Destroy(gameObject);
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        transform.rotation = target.rotation;

        if (Vector3.Distance(transform.position, target.position) <= 0.5f)
        {
            GetNextWaypoints();
        }
    }

    void GetNextWaypoints()
    {
            if (wavepointIndex >= Waypoints.points.Length - 1)
            {
                EndPath(1);
                return;
            }
            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
    }

    void EndPath(int dif)
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
