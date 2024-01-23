using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToTheMoonReset : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        SceneManager.LoadScene("ToTheMoon");
        Physics.gravity = new Vector3(0, -1.63f, 0);
    }
}

