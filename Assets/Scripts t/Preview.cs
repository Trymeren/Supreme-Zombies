using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preview : MonoBehaviour
{
    public bool follow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Kys()
    {
        Destroy(gameObject);
    }

    public void FollowCursor()
    {
        follow = true;
        StartCoroutine("MoveToCursor()");
    }

    private void MoveToCursor()
    {
        for(int i = 0; i < 1;)
        {
            transform.position = GameObject.Find("Cursor").transform.position;
            if(follow)
            {
                i++;
            }
        }
    }
}
