using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerSacling : MonoBehaviour
{
    public bool hasPressedScaleKey = false;
    private float scaleX;
    private float scaleY;
    [SerializeField] KeyCode scaleKey = KeyCode.R;

    void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    void Update()
    {
        if (Input.GetKeyDown(scaleKey) && hasPressedScaleKey == false){
            transform.localScale = new Vector2(scaleX * 4, scaleY * 4);
            hasPressedScaleKey = true;
        }
        else if (Input.GetKeyDown(scaleKey) && hasPressedScaleKey == true)
        {
            transform.localScale = new Vector2(scaleX, scaleY);
            hasPressedScaleKey = false;
        }
    }
}
