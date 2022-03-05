using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
{

    [SerializeField] Transform target = null;
    [SerializeField] float cameraMoveSpeed = 50f;

    private void LateUpdate()
    {
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime * cameraMoveSpeed);
        transform.position = smoothedPosition;
    }
}
}
