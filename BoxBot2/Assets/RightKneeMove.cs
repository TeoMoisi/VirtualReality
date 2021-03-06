using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightKneeMove : MonoBehaviour
{
    public float x = 0.0f;
    public float startX = 0.0f;
    public float oldParentX = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }
    
    // Update is called once per frame
    void Update()
    {
        //var angles = transform.rotation.eulerAngles;
        if (Input.GetKey("b")) { //back
            x -= Time.deltaTime * 35;
            if (x - oldParentX > -130.0f) {
                transform.rotation = Quaternion.Euler(x, 0, 0);
            } else {
                x = -130.0f + oldParentX;
            }
        }
        
        if (Input.GetKey("f")) { // front
            x += Time.deltaTime * 35;
            if (x < oldParentX) {
                transform.rotation = Quaternion.Euler(x, 0, 0);
            } else {
                x = oldParentX;
            }
        }
    }
    
    public void parentCallback(float newParentX) {
        float diff = newParentX - oldParentX;
        oldParentX = newParentX;
        x += diff;
        
        
    }
}
