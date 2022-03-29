using UnityEngine;
namespace Jane 
{
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DetaWeapon dataWeapon;

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

        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon() 
        {

            print("經過時間:" + timer);

            if(timer >= dataWeapon.interval) 
            {
                Instantiate(dataWeapon.goWeapon);
                timer = 0;
            }
            else 
            {
                timer += Time.deltaTime;
            }
        }
    }

}

