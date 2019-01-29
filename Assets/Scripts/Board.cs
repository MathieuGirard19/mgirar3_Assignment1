using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    bool limitForward;
    // Start is called before the first frame update
    void Start()
    {
        limitForward = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
            if (!limitForward)
                {
                    transform.Rotate(Vector3.forward, 5, Space.World);
                    float angle = transform.eulerAngles.z;
                    angle = (angle > 180) ? angle - 360 : angle;
                    Debug.Log(angle);
                    if (angle > 40)
                    {
                        limitForward = true;
                    }
                }

            else 
            {
                transform.Rotate(Vector3.back, 5, Space.World);
                float angle = transform.eulerAngles.z;
                angle = (angle > 180) ? angle - 360 : angle;
                Debug.Log(angle);
                if (angle < -40)
                {
                    limitForward = false;
                }
            }
    }
}
