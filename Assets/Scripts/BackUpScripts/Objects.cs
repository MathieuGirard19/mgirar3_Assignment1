using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    private Vector3 cubePos;
    private Vector3 cylinderPos;
    private Vector3 capsulePos;
    private GameObject cube;
    private GameObject cylinder;
    private GameObject capsule;
    private GameObject board;
    private bool limitForward;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindWithTag("Cube");
        cylinder = GameObject.FindWithTag("Cylinder");
        capsule = GameObject.FindWithTag("Capsule");
        board = GameObject.FindWithTag("Board");
        cubePos = new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z);
        capsulePos = new Vector3(capsule.transform.position.x, capsule.transform.position.y, capsule.transform.position.z);
        cylinderPos = new Vector3(cylinder.transform.position.x, cylinder.transform.position.y, cylinder.transform.position.z);
        limitForward = false;
    }

    // Update is called once per frame

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 200f))
            {
                if (hit.collider.tag == "Cube")
                {
                    cube.transform.position = cubePos;
                    cube.transform.rotation = Quaternion.identity;
                    cube.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    cube.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                }
                else if (hit.collider.tag == "Cylinder")
                {
                    cylinder.transform.position = cylinderPos;
                    cylinder.transform.rotation = Quaternion.identity;
                    cylinder.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    cylinder.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                }
                else if (hit.collider.tag == "Capsule")
                {
                    capsule.transform.position = capsulePos;
                    capsule.transform.rotation = Quaternion.identity;
                    capsule.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    capsule.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                }
                
                /*else if (hit.collider.tag == "Board")
                {
                    if (!limitForward)
                    {
                        board.transform.Rotate(Vector3.forward, 2, Space.World);
                        float angle = board.transform.eulerAngles.z;
                        angle = (angle > 180) ? angle - 360 : angle;
                        Debug.Log(angle);
                        if (angle > 35)
                        {
                            limitForward = true;
                        }
                    }

                    else 
                    {
                        board.transform.Rotate(Vector3.back, 2, Space.World);
                        float angle = board.transform.eulerAngles.z;
                        angle = (angle > 180) ? angle - 360 : angle;
                        Debug.Log(angle);
                        if (angle < -35)
                        {
                            limitForward = false;
                        }
                    }
                }*/
            }
            
        }
    }

}
