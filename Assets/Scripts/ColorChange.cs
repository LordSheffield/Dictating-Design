using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit;
public class ColorChange : MonoBehaviour
{

    public GameObject threeDCanvas;
    private IMixedRealityEyeGazeProvider EyeTrackingProvider => eyeTrackingProvider ?? (eyeTrackingProvider = CoreServices.InputSystem?.EyeGazeProvider);
    private IMixedRealityEyeGazeProvider eyeTrackingProvider = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Get the Renderer component from the new cube
            var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

            // Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
    }

    public void turnRed()
    {
        if (EyeTrackingProvider?.GazeTarget == gameObject)
        {
            var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

            cubeRenderer.material.SetColor("_Color", Color.red);
        }
        
    }
    public void turnBlue()
    {
        if (EyeTrackingProvider?.GazeTarget == gameObject)
        {
            var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

            cubeRenderer.material.SetColor("_Color", Color.blue);
        }
        
    }
    public void turnGreen()
    {
        if (EyeTrackingProvider?.GazeTarget == gameObject)
        {
            var cubeRenderer = threeDCanvas.GetComponent<Renderer>();

            cubeRenderer.material.SetColor("_Color", Color.green);
        }
    
    }


}

