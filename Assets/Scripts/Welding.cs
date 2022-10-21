using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welding : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parent.transform.position + new Vector3(0, parent.gameObject.transform.localScale.y, 0);
    }
}
