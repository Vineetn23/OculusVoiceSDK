using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjects : MonoBehaviour
{
    public List<GameObject> shapes;
    public void DeleteObject(string[] response)
    {
        string shape = response[0];

        switch (shape)
        {
            case "Cube":
                shapes[0].SetActive(false);
                break;
            case "Sphere":
                shapes[1].SetActive(false);
                break;
            case "Cylinder":
                shapes[2].SetActive(false);
                break;
        }
        Debug.Log(response[0]);
    }
}
