using UnityEngine;
namespace Jane 
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;
        [SerializeField, Header("���a����W��")]
        private string namePlayer = "�M�h";
        [SerializeField, Header("�����ʵe�Ѽ�")]
        private string parameterAttack = "Ĳ�o����";

        private Transform traPlayer;
        private float timerAttack;
        private Animator ani;

        private void Awake()
        {
            ani = GetComponent<Animator>();
            //���a�����ܧ� = �C������.�M��(���a����W��).�ܧ�
            traPlayer = GameObject.Find(namePlayer).transform;

            /*float result = Mathf.Lerp(0, 10, 0.5f);
            float result7 = Mathf.Lerp(0, 10, 0.7f);
            print("0�P10��0.5�t��" + result);
            print("0�P10��0.7�t��" + result7);*/
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
            //print("<color=yellow>�Z��:" + dis + "</color>");

            //�p�G �Z�� �p�󰱤�Z�� �N�B�z...
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
                //print("<color=red>�����p�ɾ�:" + timerAttack + "</color>");
            }
            else 
            {
                ani.SetTrigger(parameterAttack);
                timerAttack = 0;
            }
        }
    }
}

 