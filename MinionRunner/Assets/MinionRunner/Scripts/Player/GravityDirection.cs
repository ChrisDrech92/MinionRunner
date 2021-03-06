﻿using UnityEngine;
using System.Collections;

public class GravityDirection : MonoBehaviour
{

    public bool grounded;
    private Vector3 posCur;
    private Quaternion rotCur;
    RaycastHit hit;


    void Update()
    {
       
       
                Ray ray = new Ray(transform.position, -transform.up);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 1.5f) == true)
                {

                    Debug.DrawLine(transform.position, hit.point, Color.green);

                    rotCur = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
                    posCur = new Vector3(transform.position.x, hit.point.y, transform.position.z);

                    grounded = true;

                }
                else
                {
                    grounded = false;
                }


                if (grounded == true)
                {

                    transform.position = Vector3.Lerp(transform.position, posCur, Time.deltaTime * 5);
                    transform.rotation = Quaternion.Lerp(transform.rotation, rotCur, Time.deltaTime * 5);
                }
            }
    }
