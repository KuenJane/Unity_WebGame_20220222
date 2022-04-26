using UnityEngine;
namespace Jane 
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "騎士";
        private Transform traPlayer;

        private void Awake()
        {
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
        private void MoveToPlayer() 
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}

 
