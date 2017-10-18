using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleMovementScript : MonoBehaviour {

    [SerializeField]
    private GameObject needleBody;

    private bool canFireNeedle;
    private bool touchedTheCircle;

    private float forceY = 70f;

    private Rigidbody2D myBody;

    void Awake() {
        Initialize();
    }

	void Initialize()
    {
        needleBody.SetActive(false);
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (canFireNeedle)
        {
            myBody.velocity = new Vector2(0, forceY);
        }
    }

    public void FireTheNeedle()
    {
        needleBody.SetActive(true);
        myBody.isKinematic = false;
        canFireNeedle = true;
    }
}
