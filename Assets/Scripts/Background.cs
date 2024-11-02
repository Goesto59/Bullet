using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public SpriteRenderer _Background; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ColorTime = Mathf.Cos(Time.time);
        Color swapColor = Color.HSVToRGB(Mathf.InverseLerp(-1, 1, ColorTime), 1, 1);
        _Background.color = swapColor;
    }
}
