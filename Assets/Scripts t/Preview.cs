using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Preview : MonoBehaviour
{
    private Vector3 posOffset = new Vector3(0, 2, 0);
    private MainCanvas mainCanvas;

    [SerializeField] private int placeable = 0;
    // Start is called before the first frame update
    void Start()
    {
        mainCanvas = GameObject.Find("Canvas").GetComponent<MainCanvas>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColour();
        FollowCursor();
        //Check for placement
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            if(placeable == 0)
            {
                StartCoroutine(PlaceStructure());
            }
            
        }
    }

    //Check if placeable
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Building"))
        {
            placeable++;
        }
    }
        
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Building"))
        {
            placeable--;
        }
    }

    IEnumerator PlaceStructure()
    {
        yield return new WaitForSeconds(Time.deltaTime * 3);

        Instantiate(mainCanvas.buildingPrefabs[mainCanvas.buildingSelected - 1], transform.position, transform.rotation);
        Destroy(gameObject);
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
        if(placeable > 0)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.85f, 0, 0, 0.8f));
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0.85f, 0, 0.8f));
        }
        
    }
}
