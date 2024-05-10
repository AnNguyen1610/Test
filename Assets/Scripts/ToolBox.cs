using System.Collections.Generic;
using UnityEngine;


public class ToolBox : MonoBehaviour, IColorable
{

    [SerializeField] private int numberOfSlot;
    [SerializeField] private List<Slot> slotList;
    [SerializeField] private ColorType colorType { get; set; }
    public BoxState CurrentState
    {
        get;
        set;
    }

    public bool CheckSolve()
    {
        foreach (var slot in slotList)
        {
            if (slot.Occupied == false) return false;
        }

        return true;
    }


    public ColorType Color { get; set; }
    public bool CheckSameColor(IColorable otherColorObject)
    {
        if (otherColorObject is Screw && this.Color == otherColorObject.Color) return true;
        return false;
    }
}

public enum BoxState {
    UNSOLVED,
    SOLVED,
}