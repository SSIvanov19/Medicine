using System;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private float initialFingersDistance;

    private bool isDragging = false;
    private Rigidbody rb;

    private Vector3 initialScale;
    private Vector2 touchPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2)
        {
            isDragging = false;
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);
           
            if (touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
            {
                initialFingersDistance = Vector2.Distance(touch1.position, touch2.position);
                initialScale = transform.localScale;
            }
            else if(touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
                var currentFingersDistance = Vector2.Distance(touch1.position, touch2.position);
                var scaleFactor = currentFingersDistance / initialFingersDistance;
                transform.localScale = initialScale * scaleFactor;
            }
        }
    }

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                isDragging = true;
            }
        }
        
        if (Input.touchCount == 0)
        {
            isDragging = false;
        }
        
        if (isDragging)
        {
            touchPosition = Input.GetTouch(0).deltaPosition;
            float x = touchPosition.x * rotationSpeed * Time.fixedDeltaTime;
            float y = touchPosition.y * rotationSpeed * Time.fixedDeltaTime;
            
            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }

        if (!isDragging)
        {
            rb.angularVelocity = Vector3.zero; 
        }
    }

    public void Reset()
    {
        rb.angularVelocity = Vector3.zero;

        transform.localScale = new Vector3(6, (float) 2.5, 1);
        transform.rotation = new Quaternion(0, 180, 0, 0);
    }
}
