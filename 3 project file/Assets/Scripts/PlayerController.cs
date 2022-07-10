using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    private CharacterController cc;
    public float moveSpeed;
    public float jumpSpeed;

    private float horizontalMove, verticalMove;
    private Vector3 dir;

    public float gravity;
    private Vector3 velocity;

    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundLayer;
    public bool isGround;

    public GameObject canvas;
    public Text canvas_text;
    private int if_canvas_show = 0;
    private int canvas_text_number = 0;

    private void Start () {
        cc = GetComponent<CharacterController> ();
    }

    private void Update () {
        isGround = Physics.CheckSphere (groundCheck.position, checkRadius, groundLayer);

        if (isGround && velocity.y < 0) {
            velocity.y = -2f;
        }

        horizontalMove = Input.GetAxis ("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis ("Vertical") * moveSpeed;

        dir = transform.forward * verticalMove + transform.right * horizontalMove;
        cc.Move (dir * Time.deltaTime);

        if (Input.GetButtonDown ("Jump") && isGround) {
            velocity.y = jumpSpeed;
        }

        velocity.y -= gravity * Time.deltaTime;
        cc.Move (velocity * Time.deltaTime);




        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("GameScene");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Vector3 this_position = this.transform.position;

            GameObject obj1 = GameObject.Find("girl1"); //1号NPC，纪念碑旁边的人
            GameObject obj2 = GameObject.Find("girl2"); //2号NPC，亭子旁边的人
            GameObject obj3 = GameObject.Find("girl3"); //3号NPC，图书馆旁边的人
            GameObject obj4 = GameObject.Find("girl4"); //4号NPC，校史馆旁边的人
            GameObject obj5 = GameObject.Find("girl5"); //5号NPC，机械大楼旁边的人

            Vector3 pos1 = obj1.transform.position;
            Vector3 pos2 = obj2.transform.position;
            Vector3 pos3 = obj3.transform.position;
            Vector3 pos4 = obj4.transform.position;
            Vector3 pos5 = obj5.transform.position;

            // 如果在 1号NPC 的附近
            if ((pos1 - this_position).magnitude < 6)
            {
                if (if_canvas_show == 0)
                {
                    if_canvas_show = 1;
                    canvas.SetActive(true);
                    canvas_text.text = "欢迎来到华中科技大学。"
                        + "\n\n此处为建校纪念碑，位于华中科技大学青年园旁，是其前身华中工学院建校后所立。纪念碑的四足鼎立代表了建校时的四所学校。"
                        + "\n\n下一站，请前往青年园凉亭。";
                }
                else
                {
                    if_canvas_show = 0;
                    canvas.SetActive(false);
                }
            }

            // 如果在 2号NPC 的附近
            if ((pos2 - this_position).magnitude < 6)
            {
                if (if_canvas_show == 0)
                {
                    if_canvas_show = 1;
                    canvas.SetActive(true);
                    canvas_text.text = ""
                        + "此处为青年园凉亭，位于华中科技大学青年园内。"
                        + "\n\n下一站，请前往图书馆。";
                }
                else
                {
                    if_canvas_show = 0;
                    canvas.SetActive(false);
                }
            }

            // 如果在 3号NPC 的附近
            if ((pos3 - this_position).magnitude < 6)
            {
                if (if_canvas_show == 0)
                {
                    if_canvas_show = 1;
                    canvas.SetActive(true);
                    canvas_text.text = ""
                        + "此处为图书馆，是湖北省优秀级图书馆和研究级文献收藏单位，同时也是中国高等教育文献保障系统(CALIS)中心成员馆。"
                        + "\n\n按\"T\"键，可进入拾取书本小游戏"
                        + "\n\n下一站，请前往校史馆。";
                }
                else
                {
                    if_canvas_show = 0;
                    canvas.SetActive(false);
                }
            }

            // 如果在 4号NPC 的附近
            if ((pos4 - this_position).magnitude < 6)
            {
                if (if_canvas_show == 0)
                {
                    if_canvas_show = 1;
                    canvas.SetActive(true);
                    canvas_text.text = ""
                        + "此处为校史馆，华中科技大学将喜迎建校70周年华诞。学校与新中国共成长，经过悠悠七十年岁月的沉淀，形成了自己独特一格，红专并存的历史文化。"
                        + "\n\n下一站，请前往机械大楼。";
                }
                else
                {
                    if_canvas_show = 0;
                    canvas.SetActive(false);
                }
            }

            // 如果在 5号NPC 的附近
            if ((pos5 - this_position).magnitude < 6)
            {
                if (if_canvas_show == 0)
                {
                    if_canvas_show = 1;
                    canvas.SetActive(true);
                    canvas_text.text = ""
                        + "此处为机械大楼，露天电影院中正在播放电影。";
                }
                else
                {
                    if_canvas_show = 0;
                    canvas.SetActive(false);
                }
            }

        }

    }
}