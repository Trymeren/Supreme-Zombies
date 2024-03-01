using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject target;
    public float damage;
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
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy bullet if hitting enemy and take damage
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().health -= damage;
            Destroy(gameObject);
            Debug.Log("yes");
        }
    }
}
