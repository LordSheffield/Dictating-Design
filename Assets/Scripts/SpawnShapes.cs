using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShapes : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;
    public GameObject capsule;
    public GameObject ring;
    public GameObject cone;

    public void CreateSphere()
    {
        Instantiate(sphere, transform.position, Quaternion.identity);
    }
    public void CreateCube()
    {
        Instantiate(cube, transform.position, Quaternion.identity);
    }
    public void CreateCylinder()
    {
        Instantiate(cylinder, transform.position, Quaternion.identity);
    }
    public void CreateCapsule()
    {
        Instantiate(capsule, transform.position, Quaternion.identity);
    }
    public void CreateRing()
    {
        Instantiate(ring, transform.position, Quaternion.identity);
    }
    public void CreateCone()
    {
        Instantiate(cone, transform.position, Quaternion.identity);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            CreateCone();
        }

    }
    
}

