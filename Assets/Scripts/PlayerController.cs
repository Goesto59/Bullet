using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerController : MonoBehaviour
{
    public Vector2 _mousePostition;
    public float _speed;
    public Vector2 _velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //_mousePostition = Input.mousePosition;
        _mousePostition = Camera.main.ScreenToWorldPoint(_mousePostition);
        //transform.position = Vector2.Lerp(transform.position, _mousePostition, Time.deltaTime * _speed);
        transform.position = Vector2.SmoothDamp(transform.position, _mousePostition, ref _velocity, 1 / _speed);
    }

    void OnMousePosition(InputValue Value)
    {
        _mousePostition = Value.Get<Vector2>();
    }
}
