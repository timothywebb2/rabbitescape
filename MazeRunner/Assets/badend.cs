using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badend : MonoBehaviour
{

    public float badTime = 12.0f;
    public Renderer myRenderer;
      AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

         badTime -= Time.deltaTime;

        if (badTime <= 0.0f)
{
   worstEnd();
}
        
    }

    void worstEnd()
{
    myRenderer.enabled = true;
     GetComponent<AudioSource>().Play();
       Time.timeScale = 0;
}
}
