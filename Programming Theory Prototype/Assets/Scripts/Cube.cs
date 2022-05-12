using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public override string DisplayText()
    {
        return $"It's a {shapeColor.Split()[0].ToLower()} {shapeName.ToLower()}!";
    }
}
