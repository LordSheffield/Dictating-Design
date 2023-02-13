using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulerActivation : MonoBehaviour
{
    public GameObject ruler;

    public void DeActivate()
    {
        ruler.SetActive(false);
    }

    public void Activate()
    {
        ruler.SetActive(true);
    }
}
