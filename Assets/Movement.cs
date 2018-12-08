using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Transform ball;
    public Vector3 offset;

    void Update()
    {
        transform.position = ball.position + offset;
        transform.rotation = Quaternion.Euler(new Vector3(0, ball.rotation.y, 0));
    }

}
