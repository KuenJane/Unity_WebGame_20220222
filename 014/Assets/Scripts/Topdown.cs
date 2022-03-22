using UnityEngine;

namespace Jane
{
    /// <summary>
    /// �W�U�������ⱱ�
    /// ����� �ʵe��s
    /// </summary>
    public class Topdown : MonoBehaviour 
    {
        #region ���:�O�s���ʳt��/�ʵe�ѼƦW�٩Τ��󵥸��
        //���:�׹���/�������/���W��(���w �w�]��);
        [SerializeField, Header("���ʳt��"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "�}��_�]�B";
        private string parameterDead= "�}��_���`";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;

        #endregion
        #region �ƥ�:�{�����J�f(unity)
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //��s�ƥ�: 60fps
        private void Update()
        {
            GetInput();
            Move();
            Rotate();
        }
        #endregion
        #region ��k:�������欰/���ʥ\��/��s�ʵe
        private void GetInput() 
        {
            //�ϥ��R�A���
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            print("�����b�V��:" + h);
        }

        private void Move()
        {
            rig.velocity = new Vector2(h, v)* speed;
            ani.SetBool(parameterRun, h != 0 || v !=0);

        }

        private void Rotate() 
        {
            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
        #endregion
    }

}

