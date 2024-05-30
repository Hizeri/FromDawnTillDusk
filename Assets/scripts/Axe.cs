using UnityEngine;

public class Axe : MonoBehaviour
{
    [SerializeField] int damage;

   

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"оноюкх: {collision.gameObject.name}");

        if (collision.collider.CompareTag("Ladder"))
        {
            collision.gameObject.GetComponent<Ladder>().GetDemage(damage);
            
        }

        
    }
}
