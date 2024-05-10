using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchInput : MonoBehaviour
{
    public Text timeDisplayTxt;
    public Text DirectionDisplayText;
    public Touch theTouch;

    public Vector2 touchStartPosition, touchEndPosition;

    public float touchDuration = 0.0f;

    public string Direction { get; private set; }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        GetTouch();
    }
    
    public void GetTouch()
    {

        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if (theTouch.phase == TouchPhase.Began)
            {
                touchStartPosition = theTouch.position;
            }
            else if (theTouch.phase == TouchPhase.Moved )
            {
                DirectionDisplayText.enabled = true;
                touchEndPosition = theTouch.position;
                float x = touchEndPosition.x - touchStartPosition.x;
                float y = touchEndPosition.y - touchStartPosition.y;
                touchStartPosition = touchEndPosition;
                // if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
                // {
                //     Direction = "Tapped";
                // }
                if (Mathf.Abs(x) > Mathf.Abs(y))
                {
                    // Direction = x > 0 ? "Right ": (x < 0) ?"Left" : "";
                    if (x > 0) Direction = "Right";
                    else if (x < 0) Direction = "Left";
                }
                

                else {
                    if (y > 0) Direction = "Up";
                    else if (y < 0) Direction = "Down";
                }

                
            }else{
                DirectionDisplayText.enabled = false;
            }
        }

        
        DirectionDisplayText.text = Direction;

    }
}
