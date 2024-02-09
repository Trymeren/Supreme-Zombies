using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preview : MonoBehaviour
{
    private Vector3 posOffset = new Vector3(0, 2, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColour();
        FollowCursor();
    }

    public void Kys()
    {
        Destroy(gameObject);
    }

    public void FollowCursor()
    {
        transform.position = GameObject.Find("Cursor").transform.position + posOffset;
    }

    private void ChangeColour()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0.85f, 0, 0.8f));
    }
}
