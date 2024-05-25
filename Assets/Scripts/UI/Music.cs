using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music  : MonoBehaviour
{
    // Start is called before the first frame update
    private static Music instance;
    void Awake()
    {
        // Kiểm tra nếu đã có một instance khác của MusicManager tồn tại
        if (instance != null && instance != this)
        {
            // Nếu có, phá hủy GameObject này để tránh trùng lặp
            Destroy(gameObject);
        }
        else
        {
            // Nếu không, thiết lập instance và không phá hủy GameObject này khi chuyển scene
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
