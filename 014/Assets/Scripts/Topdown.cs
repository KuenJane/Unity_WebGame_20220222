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
        }
        #endregion
        #region ��k:�������欰/���ʥ\��/��s�ʵe
        private void GetInput() 
        {
            //�ϥ��R�A���
            float h = Input.GetAxis("Horizontal");
            print("�����b�V��:" + h);
        }
        #endregion
    }

}

