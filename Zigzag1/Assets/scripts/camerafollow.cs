using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    public bool gameover;
    public float lerpRate;


    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - transform.position;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            follow();

        }
    }

    void follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetpos = ball.transform.position - offset;
        pos = Vector3.Lerp(pos, targetpos, lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
