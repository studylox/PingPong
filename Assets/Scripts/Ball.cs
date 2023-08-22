using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    public float speed = 260.0f;
    

    private void Awake()
    {
        _rigidbody=GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        Debug.Log("Œª÷√÷ÿ÷√¡À");
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
       
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;

        
    }
    public void AddStartingForce()
   {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x,y);
       
        _rigidbody.AddForce(direction*speed);
    }
    public void Force(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

}
