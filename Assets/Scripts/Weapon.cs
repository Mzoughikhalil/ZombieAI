using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] float damage = 30;

    ZombieHP zombiehp;

    private void Start()
    {
        zombiehp = transform.GetComponent<ZombieHP>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Zombie")
        {
            zombiehp.TakeDamage(damage);
        }
        
    }
}
