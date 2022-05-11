using UnityEngine;
namespace Jane 
{
    public class EnemyHurt : HurtSystem
    {
        //enemyhurt : hurtsystem
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("畫布傷害數值")]
        private GameObject goCanvasHurt;
        [SerializeField, Header("敵人系統")]
        private EnemySystem enemySystem;

        private string parameterDead = "觸發死亡";
        private Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();
            enemySystem = GetComponent<EnemySystem>();
            hp = data.hp;

        }
        public override void GetHurt(float damage) 
        {
            base.GetHurt(damage);
            GameObject temp =Instantiate(goCanvasHurt, transform.position, Quaternion.identity);
            temp.GetComponent<HurtNumber>().UpdateDamage(damage);
        }

        protected override void Dead()
        {
            base.Dead();
            ani.SetTrigger(parameterDead);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 1.5f);
        }
    }
}
