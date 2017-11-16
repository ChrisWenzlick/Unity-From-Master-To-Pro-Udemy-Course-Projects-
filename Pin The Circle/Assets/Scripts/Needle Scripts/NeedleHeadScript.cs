using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleHeadScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Needle Head")
        {
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
    }
}
