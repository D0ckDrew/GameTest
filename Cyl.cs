using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyl : MonoBehaviour
{
    public GameObject cube;
    public float speed, tilt;

    void Update()
    {
        transform.RotateAround(cube.transform.position,new Vector3(0,1,0), 1/(tilt/7));
    }
}

