using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Ground : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public GameManager gameManager;
    public Player player;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {

        float speed = GameManager.Instance.gameSpeed / transform.localScale.x;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameManager.gameSpeed = 0;
            gameManager.gameSpeedIncrease = 0;
            

        }

        
        meshRenderer.material.mainTextureOffset += speed * Time.deltaTime * Vector2.right;
        
    }
    
}
