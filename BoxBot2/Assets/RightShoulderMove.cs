using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightShoulderMove : MonoBehaviour
{
    public float x = 0.0f;
    public float movementVolicity = 5.0f;
    public GameObject elbow;
    public RightElbowMove rightElbowMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        elbow = GameObject.Find("RightElbowMesh");
        rightElbowMovement = elbow.GetComponent<RightElbowMove>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            x += Time.deltaTime * 35;
            transform.rotation = Quaternion.Euler(x, 0, 0);
            rightElbowMovement.parentCallback(x);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            x -= Time.deltaTime * 35;
            transform.rotation = Quaternion.Euler(x, 0, 0);
            rightElbowMovement.parentCallback(x);
        }
    }
}
