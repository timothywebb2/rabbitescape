using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro: MonoBehaviour {

public float targetTime = 2.0f;

void Update(){

targetTime -= Time.deltaTime;

if (targetTime <= 0.0f)
{
   timerEnded();
}

}

void timerEnded()
{
   Destroy(gameObject);
}


}
