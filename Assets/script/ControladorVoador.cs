using UnityEngine;
using UnityEngine.UI;

public class ControladorVoador : MonoBehaviour
{
    public float incrementoVelocidade; //velocidade por segundo
    public float deslocamentoObjeto; //velocidade inicial
    public Sprite[] imagensObjetos;

    internal int sentidoV;
    internal Vector3 posicaoObj;
    internal float deslocamentoAbs;
    internal int numImagemAtual = 0;

    public float posInicialX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        sentidoV = 1;
        posicaoObj = transform.position;
        posInicialX = transform.position.x;

        deslocamentoAbs = deslocamentoObjeto;

    }

    // Update is called once per frame
    void Update()
    {
        //Movimentaçao do objeto:Velocidade do deslocamento do objeto,vezes
        //sentido(vertical),vezes "Time.deltaTime",vezes velocidade dinamica
        posicaoObj.y += (deslocamentoAbs * sentidoV * Time.deltaTime);
        posicaoObj.x += (deslocamentoAbs * Time.deltaTime);

        deslocamentoAbs += incrementoVelocidade * Time.deltaTime;

        transform.position = posicaoObj;


        //limitador Obj 
        if (transform.position.y > 470)
            sentidoV = -1;

        else if (transform.position.y < 38)
            sentidoV = 1;

    }

    public void MudarImagem()
    {
        numImagemAtual += 1;

        if (numImagemAtual == imagensObjetos.Length)
            numImagemAtual = 0;

        GetComponent<Image>().sprite = imagensObjetos[numImagemAtual];

    }



}
