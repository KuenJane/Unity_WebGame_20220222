using UnityEngine;
namespace Jane 
{
    public class EnemyHurt : HurtSystem
    {
        //enemyhurt : hurtsystem
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Awake()
        {
            hp = data.hp;
        }
    }
}
