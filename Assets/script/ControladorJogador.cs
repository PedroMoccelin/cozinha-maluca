using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public float taxaMovimentacao;
    public geral juizDoJogo;



    // Update is called once per frame
    void Update()
    {
        {
            float altX, altY;

            // Para cima e para baixo
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 470)


                altY = 60 * Time.deltaTime * taxaMovimentacao;
            else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > 38)
                altY = -60 * Time.deltaTime * taxaMovimentacao;
            else
                altY = 0;

            // Para os lados
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 34)
                altX = -60 * Time.deltaTime * taxaMovimentacao;
            else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 925)
                altX = 60 * Time.deltaTime * taxaMovimentacao;
            else
                altX = 0;

            // Modificar posi��o:

            Vector3 novaPos = new Vector3(altX, altY, 0);
            transform.position += novaPos;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Voador")
        {
            juizDoJogo.MarcarPonto();
            collision.GetComponent<ControladorVoador>().posicaoObj.x = 
            collision.GetComponent<ControladorVoador>().posInicialX;



        }




    }


}










