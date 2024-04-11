using UnityEngine;


//Codigo que vai da a altura maxima e altura minima do objeto do jogo  

public class SpawnObject : MonoBehaviour
{
    public GameObject prefab;
    public float maxHeight;
    public float minHeight;
    public float maxTime;

    private float _timer;  


    private void Start()
    {
        InstantiateObject();
    }

    private void Update() {
      if (_timer > maxTime){
            InstantiateObject();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }


    private void InstantiateObject()
    {
        var instance = Instantiate(prefab);
        var y = Random.Range(minHeight, maxHeight);
        instance.transform.position
            = transform.position + new Vector3(0, y);

        //destruir objeto a cada 10 segundos se não é infitito e deixa o jogo pesado 
      Destroy(instance, 10f); //10f é 10 segundos 
    }
}
