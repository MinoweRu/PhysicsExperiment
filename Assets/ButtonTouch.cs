using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTouch : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("DistanceGrab");
        Physics.gravity = new Vector3(0, -9.8f, 0);
    }
}