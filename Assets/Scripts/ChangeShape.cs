using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;
    public GameObject capsule;

    public void Sphere()
    {
        if (cube.active == true)
        {
            sphere.transform.position = cube.transform.position;
            cube.SetActive(false);
            sphere.SetActive(true);
        }
        else if (cylinder.active == true)
        {
            sphere.transform.position = cylinder.transform.position;
            cylinder.SetActive(false);
            sphere.SetActive(true);
        }
        else if (capsule.active == true)
        {
            sphere.transform.position = capsule.transform.position;
            capsule.SetActive(false);
            sphere.SetActive(true);
        }
    }
    public void Cube()
    {
        if (sphere.active == true)
        {
            cube.transform.position = sphere.transform.position;
            sphere.SetActive(false);
            cube.SetActive(true);
        }
        else if (cylinder.active == true)
        {
            cube.transform.position = cylinder.transform.position;
            cylinder.SetActive(false);
            cube.SetActive(true);
        }
        else if (capsule.active == true)
        {
            cube.transform.position = capsule.transform.position;
            capsule.SetActive(false);
            cube.SetActive(true);
        }
    }
    public void Cylinder()
    {
        if (sphere.active == true)
        {
            cylinder.transform.position = sphere.transform.position;
            sphere.SetActive(false);
            cylinder.SetActive(true);
        }
        else if (cube.active == true)
        {
            cylinder.transform.position = cube.transform.position;
            cube.SetActive(false);
            cylinder.SetActive(true);
        }
        else if (capsule.active == true)
        {
            cylinder.transform.position = capsule.transform.position;
            capsule.SetActive(false);
            cylinder.SetActive(true);
        }
    }
    public void Capsule()
    {
        if (sphere.active == true)
        {
            capsule.transform.position = sphere.transform.position;
            sphere.SetActive(false);
            capsule.SetActive(true);
        }
        else if (cube.active == true)
        {
            capsule.transform.position = cube.transform.position;
            cube.SetActive(false);
            capsule.SetActive(true);
        }
        else if (cylinder.active == true)
        {
            capsule.transform.position = cylinder.transform.position;
            cylinder.SetActive(false);
            capsule.SetActive(true);
        }

    }
}
