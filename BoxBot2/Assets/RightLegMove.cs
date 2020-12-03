using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLegMove : MonoBehaviour
{
    public float x = 0.0f;
    public GameObject knee;
    public RightKneeMove rightKneeMovement;
    
    void Start()
    {
        Debug.Log("Start");
        knee = GameObject.Find("RightKneeMesh");
        rightKneeMovement = knee.GetComponent<RightKneeMove>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            x += Time.deltaTime * 35;
            if (x < 70.0f) {
                transform.rotation = Quaternion.Euler(x, 0, 0);
            } else {
                x = 70.0f;
            }
            rightKneeMovement.parentCallback(x);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            x -= Time.deltaTime * 35;
            if (x > -70.0f) {
                transform.rotation = Quaternion.Euler(x, 0, 0);
            } else {
                x = -70.0f;
            }
            rightKneeMovement.parentCallback(x);
        }
    }
}
