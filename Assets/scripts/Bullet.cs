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
        Debug.Log($"ПОПАЛИ: {collision.gameObject.name}");

        if (collision.collider.CompareTag("Zombie"))
        {
            collision.gameObject.GetComponent<Zombie>().GetDamage(damage);
            Debug.Log("ПОПАЛИ: попали в зомби");
        }

        Destroy(gameObject);
    }
}
