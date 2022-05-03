using UnityEngine;
namespace Jane 
{
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DetaWeapon dataWeapon;
        [SerializeField, Header("武器刪除時間"),Range(0,5)]
        private float weaponDestroyTime = 3.5f;
        private float timer;

        private void OnDrawGizmos()
        {
            //顏色
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            //
            for (int i =0; i < dataWeapon.v2SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[i], 0.1f);
            }
            

        }

        private void Start()
        {
            //2d 物理 忽略圖層碰撞(圖層 1 /圖層 2)
            Physics2D.IgnoreLayerCollision(3, 6);//玩家 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 6);//武器 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 7);
        }

        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon() 
        {
            //int random=Random.Range(0,dataWeapon.v2SpawnPoint.Length);

            //print("經過時間:" + timer);

            if(timer >= dataWeapon.interval) 
            {
                int random = Random.Range(0, dataWeapon.v2SpawnPoint.Length);

                Vector3 pos = transform.position + dataWeapon.v2SpawnPoint[random];
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speedFly);

                
                timer = 0;

                Destroy(temp,weaponDestroyTime);//刪除物件(遊戲物件，延遲時間)
                temp.GetComponent<Weapon>().attack = dataWeapon.attack;
            }
            else 
            {
                timer += Time.deltaTime;
            }
        }
    }

}

