
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Translate : MonoBehaviour
{
    private Rigidbody2D rb;
    public float initialForce = 5f;
    public float upForce = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null ) rb = gameObject.AddComponent<Rigidbody2D>();
        float angle = Random.Range(270f, 450f);
        float upwardForce = initialForce * upForce; 
        Vector2 direction = Quaternion.Euler(0,0, angle) * Vector2.up;
        rb.velocity = direction.normalized* initialForce;
        rb.angularVelocity = Random.Range(-180f, 180f);
       
    }

    private void Update()
    {
        

        if(transform.position.y<Camera.main.ViewportToWorldPoint(Vector3.zero).y-1f)
        {
            Destroy(gameObject);
        }
       
    }
    // Update is called once per frame
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Dcnhtxf");
        rb.velocity = Vector2.down * 2f;
        rb.gravityScale = 1f;
    }

}
