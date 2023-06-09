using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 0, -10);
    private float smoothTime = .25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Start is called before the first frame update
   
    void Start()
    {
       
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;

        if (targetPosition.y >= 113.4f)
            targetPosition.y = 113.4f;
        else if (targetPosition.y <= -.4f)
            targetPosition.y = -.4f;
        if (targetPosition.x <= -48.6f)
            targetPosition.x = -48.6f;
        else if (targetPosition.x >= 61.4f)
            targetPosition.x = 61.4f;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
