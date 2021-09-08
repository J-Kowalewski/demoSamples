using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsParallax : MonoBehaviour
{
    private float textureUnitSizeX;
    private Transform cameraTransform;
    public Camera camera;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
        cameraTransform = camera.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position += new Vector3(-0.1f*speed, 0, 0)*Time.deltaTime;

        if(Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitSizeX)
        {
            float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitSizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
        }
    }
}
