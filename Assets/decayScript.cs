using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decayScript : MonoBehaviour
{
    public Animator anim;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.CurrentState == GameManager.GameState.GameOver)
        {
            Destroy(gameObject);
        }
    }
}
