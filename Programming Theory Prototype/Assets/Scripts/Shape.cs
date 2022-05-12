using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string _shapeName;
    public string shapeName
    {
        get { return _shapeName; }
        set { _shapeName = value; }
    }

    private string _shapeColor;
    public string shapeColor
    {
        get { return _shapeColor; }
        set { _shapeColor = value; }
    }

    void Awake()
    {
        var gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        int index = Random.Range(0, gameManager.materials.Length);
        GetComponent<Renderer>().material = gameManager.materials[index];
        shapeName = name;
        shapeColor = GetComponent<Renderer>().material.name;
    }

    public abstract string DisplayText();
}
