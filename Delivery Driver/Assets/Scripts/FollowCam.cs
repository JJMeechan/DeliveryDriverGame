using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    //This things position(camera) should be the same as the cameras position

    [SerializeField] GameObject Target;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Target.transform.position + new Vector3(0,0,-10);
    }
}
