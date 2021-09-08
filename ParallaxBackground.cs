using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    public GameObject player;
    public float parallaxEffectMultiplier = .5f;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = player.transform;
        lastCameraPosition = cameraTransform.position;
}

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position -= deltaMovement / parallaxEffectMultiplier;
        lastCameraPosition = cameraTransform.position;
    }
}
