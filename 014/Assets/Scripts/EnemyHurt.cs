using UnityEngine;
namespace Jane 
{
    public class EnemyHurt : HurtSystem
    {
        //enemyhurt : hurtsystem
        [SerializeField, Header("¼Ä¤H¸ê®Æ")]
        private DataEnemy data;

        private void Awake()
        {
            hp = data.hp;
        }
    }
}
