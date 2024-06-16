using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleOfPipeTrigger : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.AddScore(1);
    }
}
