using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;

    private Vector3 targetPos;

    [SerializeField] private float speed;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get target position
        targetPos = GameObject.Find("Player").transform.position;

        //Move towards target
        enemyRb.velocity = (targetPos - gameObject.transform.position).normalized * speed;

        //Check if dead
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
