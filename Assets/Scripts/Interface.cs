using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class Interface : MonoBehaviour
{
    public float TextBounceDuration;
    public AnimationCurve Curve;
    [SerializeField] TMP_Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreText(int score)
    {
        Text.text = score.ToString();
        Text.transform.DOScale(Vector3.one * 1.5f, TextBounceDuration/2).SetEase(Curve)
            .OnComplete(() => Text.transform.DOScale(Vector3.one, TextBounceDuration/2)).SetEase(Curve);
    }
}
