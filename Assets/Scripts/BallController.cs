using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class BallController : MonoBehaviour
{
    [SerializeField] Transform _positifBall;
    [SerializeField] Transform _negativeBall;
    private float countdownTime;
    public float invertCountdown;
    public float negativeBallDistance;
    public Vector2 _worldPosition;
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
        countdownTime += Time.deltaTime;
        //_mousePostition = Input.mousePosition;
        _worldPosition = Camera.main.ScreenToWorldPoint(_mousePostition);
        //transform.position = Vector2.Lerp(transform.position, _mousePostition, Time.deltaTime * _speed);
        _positifBall.position = Vector2.SmoothDamp(_positifBall.position, _worldPosition, ref _velocity, 1 / _speed);
        _negativeBall.position = Vector2.Lerp(_negativeBall.position, -_positifBall.position.normalized * negativeBallDistance, 10 * Time.deltaTime); 
    }

    void OnMousePosition(InputValue Value)
    {
        _mousePostition = Value.Get<Vector2>();
    }

    void OnInversePosition()
    {
        if(countdownTime >= invertCountdown)
        {
            Mouse.current.WarpCursorPosition(Camera.main.WorldToScreenPoint(_negativeBall.position));
            countdownTime = 0;
        }
    }
}
