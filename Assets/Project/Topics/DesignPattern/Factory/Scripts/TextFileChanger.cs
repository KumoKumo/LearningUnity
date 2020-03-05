using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFileChanger : MonoBehaviour
{
    [SerializeField] TextMesh txtMesh;

    private void Awake()
    {
        txtMesh = gameObject.GetComponent<TextMesh>();
        txtMesh.text = "Press 1 or 2 to use abilities! Look at the Console for result";
    }

}
