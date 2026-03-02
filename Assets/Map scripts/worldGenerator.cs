using UnityEngine;

public class worldGenerator : MonoBehaviour
{

    public GameObject wallPrefab;
    public int width = 10;
    public int height = 5;

    void Start() {
        // Top & bottom
        for (int x = -width; x <= width; x++) {
            Instantiate(wallPrefab, new Vector2(x, height), Quaternion.identity);
            Instantiate(wallPrefab, new Vector2(x, -height), Quaternion.identity);
        }

        // Left & right
        for (int y = -height; y <= height; y++) {
            Instantiate(wallPrefab, new Vector2(width, y), Quaternion.identity);
            Instantiate(wallPrefab, new Vector2(-width, y), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
