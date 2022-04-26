using UnityEngine;
namespace Jane 
{
    [CreateAssetMenu(menuName = "Jane/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject 
    {
        [Header("���ʳt��"), Range(0, 3500)]
        public float speed = 30;
        [Header("�����O"), Range(0, 500)]
        public float attack = 10;
        [Header("�����N�o"), Range(0, 5)]
        public float cd = 3.5f;
        [Header("��q"), Range(0, 5000)]
        public float hp = 100;
        [Header("�����g����v"), Range(0, 1)]
        public float expDropProbability = 1;
        [Header("�����g������")]
        public TypeExp typeExp;

        public enum TypeExp 
        {
            small,middle,big
        }


    }
}

