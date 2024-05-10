using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    [SerializeField] private int _layerCapacity;
    private float intervalLayerLength = 0.5f;
    [SerializeField] private  List<Layer> layerList;

    [SerializeField] private GameObject _gameObject;
    // [ContextMenu("Auto generate layers")]

    public void Start()
    {
        GenerateLayers();
        SpawnPanelOnEveryLayer();
    }
    public void GenerateLayers()
    {
        int currentLayer = 0;
        Vector3 currentPosition = Vector3.zero;
        while (currentLayer < _layerCapacity)
        {
            layerList.Add(new Layer(currentLayer, currentPosition));
            ++currentLayer;
            currentPosition += Vector3.forward * intervalLayerLength;
        }
    }

    public void SpawnPanelOnEveryLayer()
    {
        foreach (var item in layerList)
        {
            Instantiate(_gameObject, item.Position, Quaternion.identity);
        }
       
    }
}
