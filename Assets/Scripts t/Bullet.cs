using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move towards target
        if(target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
            transform.LookAt(target.transform);
            Debug.DrawRay(transform.position, target.transform.position-transform.position, Color.red);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy bullet if hitting enemy
        if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
