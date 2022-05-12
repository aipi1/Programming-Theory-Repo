using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Material[] materials;
    public TextMeshProUGUI text;
    [SerializeField]private int textCount;

    void Update()
    {
        // Check for mouse input
        if (Input.GetMouseButton(0))
        {
            HandleMouseClick();
        }
    }

    private void HandleMouseClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        // Casts the ray and get the first game object hit
        if (Physics.Raycast(ray, out hit))
        {
            var shape = hit.collider.GetComponentInParent<Shape>();
            if (shape)
            {
                text.text = shape.DisplayText();
                text.gameObject.SetActive(true);
                textCount++;
                StartCoroutine(SetTextInactive());
            }
        }
    }

    IEnumerator SetTextInactive()
    {
        yield return new WaitForSeconds(2);
        textCount--;
        if (textCount == 0)
        {
            text.gameObject.SetActive(false);
        }
    }
}
