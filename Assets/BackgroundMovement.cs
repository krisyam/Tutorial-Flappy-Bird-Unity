using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float backgroundSpeed = 1.5f;
    public float endPosition = -20.1f;
    public GameObject dayBackground;
    public GameObject nightBackground; 

    TimeSpan nightTime = new TimeSpan(20, 0, 0);
    TimeSpan currentTime = DateTime.Now.TimeOfDay;

    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        if (currentTime < nightTime)
        {
            dayBackground.SetActive(false);
            nightBackground.SetActive(true);
        }
        else
        {
            dayBackground.SetActive(true);
            nightBackground.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * backgroundSpeed) * Time.deltaTime;
        if (transform.position.x < endPosition)
        {
            transform.position = startPosition;
        }
    }
}
