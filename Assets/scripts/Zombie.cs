using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform endWaypoint;
    [SerializeField] Animator animator;
    [SerializeField] Door door;
    [SerializeField] int damage;
    [SerializeField] int hp;
    [SerializeField] float timeToDestroy;
    [SerializeField] Collider collider;
    [SerializeField] ZombieDeathCounter counter;

    bool isArrived = false;


    private void Start()
    {
        endWaypoint = GameObject.FindWithTag("EndWaipoint").transform;
        door = GameObject.FindObjectOfType<Door>();
        counter = GameObject.FindObjectOfType<ZombieDeathCounter>();

        var path = new NavMeshPath();
        agent.CalculatePath(endWaypoint.position, path);
        agent.SetPath(path);
    }

    void Update()
    {
        if (isArrived == false) 
        {
            agent.SetDestination(endWaypoint.position);
        }

/*        if (agent.remainingDistance == 0)
        {
            animator.SetBool("attack", true);
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Door")
        {
            animator.SetBool("attack", true);
            isArrived = true;
            agent.Stop();
        }
    }
    public void GetDamage(int damage)
    { 
        hp-= damage;

        if (hp <= 0)
        {
            counter.OnZombieDeath();
            Destroy(gameObject,timeToDestroy);
            collider.enabled = false;
            animator.SetTrigger("die");
            this.enabled = false;
            agent.enabled = false;
        }
    }



    public void SetDamage()
    {
        if (door != null)
        {
            door.GetDemage(damage);
        }
    }
}
