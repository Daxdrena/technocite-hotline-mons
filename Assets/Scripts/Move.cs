using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private Transform myTransform;

    private void Start(){
        myTransform = transform;
    }

    private void Update(){

        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.Z)){
            direction += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S)){
            direction -= Vector3.forward;
        }

        if (Input.GetKey(KeyCode.Q)){
            direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D)){
            direction += Vector3.right;
        }

        direction = direction.normalized;

        myTransform.Translate(direction * Time.deltaTime * speed, Space.World);
    }
}
