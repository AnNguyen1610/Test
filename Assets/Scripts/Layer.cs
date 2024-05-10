using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Layer
{
     [SerializeField] private int layerIndex;
     [SerializeField] private Vector3 position;

     public Layer()
     {
     }


     public Layer(int _layer, Vector3 _position)
     {
          layerIndex = _layer;
          position = _position;
     }

     public int LayerIndex
     {
          get => layerIndex;
          set => layerIndex = value;
     }

     public Vector3 Position
     {
          get => position;
          set => position = value;
     }
     
     

    
}
