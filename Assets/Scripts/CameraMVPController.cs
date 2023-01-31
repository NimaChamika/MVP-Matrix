using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMVPController : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Camera.main.projectionMatrix);
    }
}
