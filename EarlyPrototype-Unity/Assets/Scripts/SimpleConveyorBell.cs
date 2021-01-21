using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleConveyorBell : MonoBehaviour
{
    public float speed = 0.7f;
    public float scrollSpeed = 0.1f;

    public Rigidbody rb;
    public Renderer rend;



    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = rb.position;
        rb.position += transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(new Vector3(pos.x, pos.y, pos.z));
        
        
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_BaseMap", new Vector2(0, offset));
        
    }
}
