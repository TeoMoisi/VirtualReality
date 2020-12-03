using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5.0f;
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * movementSpeed * Time.smoothDeltaTime);
    }
}
