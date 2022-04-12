using UnityEngine;
namespace Jane 
{
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DetaWeapon dataWeapon;

        private float timer;

        private void OnDrawGizmos()
        {
            //�C��
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            //
            for (int i =0; i < dataWeapon.v2SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[i], 0.1f);
            }
            

        }

        private void Start()
        {
            //2d ���z �����ϼh�I��(�ϼh 1 /�ϼh 2)
            Physics2D.IgnoreLayerCollision(3, 6);//���a �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 6);//�Z�� �Z�� ���I��
        }

        private void Update()
        {
            SpawnWeapon();
        }

        private void SpawnWeapon() 
        {
            //int random=Random.Range(0,dataWeapon.v2SpawnPoint.Length);

            //print("�g�L�ɶ�:" + timer);

            if(timer >= dataWeapon.interval) 
            {
                int random = Random.Range(0, dataWeapon.v2SpawnPoint.Length);

                Vector3 pos = transform.position + dataWeapon.v2SpawnPoint[random];
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speedFly);

                
                timer = 0;
            }
            else 
            {
                timer += Time.deltaTime;
            }
        }
    }

}

