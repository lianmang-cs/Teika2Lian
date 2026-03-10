using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public float speed; 
    public float pivotPoint; 
    public GameObject backPrefab; 
    private GameObject[] bcks; 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcks = new GameObject[3]; 
        for(i = 0; i < 3; i++) {
            float xPos = pivotPoint - (pivotPoint/2 * i); 
            float yPos = pivotPoint - (pivotPoint/2 * i); 
            Vector3 position = new Vector3(xPos, yPos, 0.0f); 
            bcks[i] = Instantiate(backPrefab, position, Quaternion.identity);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
