using UnityEngine;
 
public class playermove : MonoBehaviour {
 
    float speed = 10f;
    Rigidbody rigidbody;
    Vector2 movement;
    float horizontal, vertical;

    void Start()=>rigidbody = GetComponent<Rigidbody>();
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        movement.Set(horizontal, vertical, 0f);
        movement = movement.normalized * speed * Time.deltaTime;
        rigidbody.MovePosition(transform.position + movement);
    }
}
