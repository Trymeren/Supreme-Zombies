using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Enemy");
        InvokeRepeating("Fire", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        GameObject clone = Instantiate(bullet, transform.position, bullet.transform.rotation);
        clone.GetComponent<Bullet>().target = target;
    }
}
