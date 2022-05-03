using UnityEngine;
using System.Collections;
namespace Jane 
{
    public class HurtNumber : MonoBehaviour
    {
        private CanvasGroup group;
        private void Start()
        {
            StartCoroutine(Test());
        }

        private IEnumerator Test() 
        {
            print("第一行");
            yield return new WaitForSeconds(2);
            print("一秒後，第二行");
        }
    }
}
