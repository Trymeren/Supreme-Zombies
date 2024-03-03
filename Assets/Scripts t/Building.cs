using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private float fireRate; //Per second
    [SerializeField] private float damage = 1;
    [SerializeField] private GameObject bullet;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 1, 1/fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        //Select target
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = 10000;
        GameObject closestEnemy = null;
        for(int i = 0; i < enemies.Length;)
        {
            float distance = Vector3.Distance(transform.position, enemies[i].transform.position);
            if(distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemies[i];
            }
            i++;
        }
        target = closestEnemy;

        //fire projectile
        if(target != null && closestDistance < range)
        {
            GameObject clone = Instantiate(bullet, transform.position, bullet.transform.rotation);
            clone.GetComponent<Bullet>().target = target;
            clone.GetComponent<Bullet>().damage = damage;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Vector4(0.3f, 0, 0, 0.1f);
        Gizmos.DrawSphere(transform.position, range);
    }
}
