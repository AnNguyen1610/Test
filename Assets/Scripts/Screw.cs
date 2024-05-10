using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screw : MonoBehaviour,ILayerBelong, IColorable
{

    public bool interactable = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Layer LayerInfo { get; set; }

    public ColorType color { get; set; }

    [SerializeField]
    private ScrewState CurrentState { get; set; }

    
    // Start is called before the first frame update
    

    

    public void MoveToBox()
    {
        
    }

    public enum ScrewState
    {
        JAMMED,
        INTERACTABLE,
        IN_QUEUE,
        UNLOCKED,
    }

   

    public void CheckUnJam()
    {
        
    }

    public ColorType Color { get; set; }

    public bool CheckSameColor(IColorable otherColorable)
    {
        if (this != (Screw)otherColorable &&
            otherColorable.Color == this.color)
        {
            return true;
        }

        return false;
    }
}
