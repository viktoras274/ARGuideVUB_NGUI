using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasDisable : MonoBehaviour
{
    public GameObject panelController;

    public void DisableCanvas()
    {
        GameObject.Find("VUB Panel");
        panelController.SetActive(false);
    }

    public void EnableCanvas()
    {
        GameObject.Find("VUB Panel");
        panelController.SetActive(true);
    }
}
