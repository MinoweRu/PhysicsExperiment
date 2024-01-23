using UnityEngine;
using UnityEngine.UI;

public class SliderTest1 : MonoBehaviour
{
   Slider hpSlider;
   public float SUUJI = -1.63f;
   public void Func1()
    {
       Physics.gravity = new Vector3(0,SUUJI,0);
    }
}