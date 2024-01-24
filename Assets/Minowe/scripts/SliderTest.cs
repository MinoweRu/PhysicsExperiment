using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
   public float SUUJI = -9.8f;
   public void Func1()
    {
       Physics.gravity = new Vector3(0,SUUJI,0);
    }
}