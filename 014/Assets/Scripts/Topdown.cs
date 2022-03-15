using UnityEngine;

namespace Jane
{
    /// <summary>
    /// 上下類型角色控制器
    /// 控制移動 動畫更新
    /// </summary>
    public class Topdown : MonoBehaviour 
    {
        #region 資料:保存移動速度/動畫參數名稱或元件等資料
        //欄位:修飾詞/資料類型/欄位名稱(指定 預設值);
        [SerializeField, Header("移動速度"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "開關_跑步";
        private string parameterDead= "開關_死亡";
        private Animator ani;
        private Rigidbody2D rig;

        #endregion
        #region 事件:程式的入口(unity)
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //更新事件: 60fps
        private void Update()
        {
            GetInput();
        }
        #endregion
        #region 方法:較複雜行為/移動功能/更新動畫
        private void GetInput() 
        {
            //使用靜態資料
            float h = Input.GetAxis("Horizontal");
            print("水平軸向值:" + h);
        }
        #endregion
    }

}

