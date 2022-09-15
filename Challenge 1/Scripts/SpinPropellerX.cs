using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private Vector3 degreePerSecond = new Vector3(0, 0, 2000);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(degreePerSecond * Time.deltaTime);
    }
}