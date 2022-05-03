using UnityEngine;
namespace Jane 
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "騎士";
        [SerializeField, Header("攻擊動畫參數")]
        private string parameterAttack = "觸發攻擊";

        private Transform traPlayer;
        private float timerAttack;
        private Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();
            //玩家物件變形 = 遊戲物件.尋找(玩家物件名稱).變形
            traPlayer = GameObject.Find(namePlayer).transform;

            /*float result = Mathf.Lerp(0, 10, 0.5f);
            float result7 = Mathf.Lerp(0, 10, 0.7f);
            print("0與10的0.5差值" + result);
            print("0與10的0.7差值" + result7);*/
        }
        private void Update()
        {
            MoveToPlayer();
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0.5f, 0, 0.6f);
            Gizmos.DrawSphere(transform.position, data.stopDistance);
        }
        private void MoveToPlayer() 
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;
            float dis = Vector3.Distance(posEnemy, posPlayer);
            //print("<color=yellow>距離:" + dis + "</color>");

            //如果 距離 小於停止距離 就處理...
            if (dis < data.stopDistance) 
            {
                Attack();
            }
            else 
            {
                transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

                float y = transform.position.x > traPlayer.position.x ? 180 : 0;
                transform.eulerAngles = new Vector3(0, y, 0);

            }
        }

        private void Attack() 
        {
            if(timerAttack < data.cd) 
            {
                timerAttack += Time.deltaTime;
                //print("<color=red>攻擊計時器:" + timerAttack + "</color>");
            }
            else 
            {
                ani.SetTrigger(parameterAttack);
                timerAttack = 0;
            }
        }
    }
}

 
