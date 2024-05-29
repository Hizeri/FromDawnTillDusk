using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int damage;

    private void Start()
    {
        Destroy(gameObject, 15f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Zombie"))
        {
            collision.gameObject.GetComponent<Zombie>().GetDamage(damage);
        }

        Destroy(gameObject);
    }
}
