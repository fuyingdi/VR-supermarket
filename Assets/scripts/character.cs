using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

    public Transform posBody;
    public Transform eyeBody;
    public Transform ground;

    GameObject go;
    // Update is called once per frame
    void Update () {
        takeObject();
    }

    void takeObject()
    {
       
        if (Input.GetMouseButton(0))
        {
            Ray eye = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(eye, out hitInfo))
            {
                go = hitInfo.collider.gameObject;
                go.GetComponent<Rigidbody>().useGravity = false;
                if (go.tag == "shopping")
                {
                    float x = Input.GetAxis("Mouse X");
                    float y = Input.GetAxis("Mouse Y");
                    if (Mathf.Abs(x)>0.01f)
                    go.transform.parent = posBody;
                    if(Mathf.Abs(y) > 0.01f)
                        go.transform.parent = eyeBody;
                    //    Vector3 targetposition = Camera.main.WorldToScreenPoint(go.transform.position);
                    //    Vector3 mousePos = Input.mousePosition;
                    //    mousePos.z = targetposition.z;
                    //    targetPos.x = Camera.main.ScreenToWorldPoint(mousePos).x;
                    //    targetPos.z = Camera.main.ScreenToWorldPoint(mousePos).z;
                    //    targetPos.y = go.transform.position.y;
                    //    float moveSpeed = 3;
                    //    if (go.transform.position == targetPos)
                    //    {//如果物体移动到了鼠标指定位置时，那么就将物体的速度设置为0
                    //        moveSpeed = 0;
                    //    }
                    //    go.transform.LookAt(targetPos);//物体面向鼠标对应的位置 (这里我们的位置选用世界坐标系)
                    //    go.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
               
            }
        }else if (Input.GetMouseButtonUp(0))
        {
            go.transform.parent = null;//要想把拿起的物体放下，把他的父物体设置为null
            go.GetComponent<Rigidbody>().useGravity = true;


        }

    }
}

