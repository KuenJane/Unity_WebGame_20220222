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
            print("�Ĥ@��");
            yield return new WaitForSeconds(2);
            print("�@���A�ĤG��");
        }
    }
}
