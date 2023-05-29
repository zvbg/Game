using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    public Text Scoretext;
    public float Speed = 5;
    public GameObject Home;
    public Animator animator;
    
    private float Score = 0;
    private bool canJump = true;
    private Rigidbody rb;
    private float Move;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Move = Input.GetAxis("Mouse X");
        if (worldMousePosition.y < -0.5f || true){
        transform.position = new Vector3(transform.position.x + Move * Speed * Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x + Move * Time.deltaTime > 1.5f){
            transform.position = new Vector3(1.5f, transform.position.y, transform.position.z);
        }else if(transform.position.x + Move * Time.deltaTime < -1.5f){
            transform.position = new Vector3(-1.5f, transform.position.y, transform.position.z);
        }
        }
        Score += 1 * Time.deltaTime * 3;
        Scoretext.text = (Mathf.RoundToInt(Score)).ToString();
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetBool("IsJump", true);
            canJump = false;
        }
        else{
            animator.SetBool("IsJump", false);
        }

    }

void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "Wall")
    {
        Home.SetActive(true);
        
        int currentScore = Mathf.FloorToInt(Score);
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
        Cursor.lockState = CursorLockMode.None;
        gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    if (collision.gameObject.tag == "Ground"){
        canJump = true;
        jumpForce = 5;
    }
    if (collision.gameObject.tag == "GameController"){
        jumpForce = 8;
    }
}

}
